using Photon.Pun;
using Photon.Realtime;
using System;
using UnityEngine;

public sealed class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager x;
    public int CurrentRoomMaxSize { get; private set; }
    public NetworkIdentity MyNetworkIdentity { get; private set; }

    private void Awake()
    {
        if (x == null) x = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        TryToConnect();
    }

    public override void OnConnected()
    {
        MyNetworkIdentity = NetworkIdentity.NotSet;
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        Debug.Log("In Lobby!");
    }
    public override void OnCreatedRoom()
    {
        CurrentRoomMaxSize = PhotonNetwork.CurrentRoom.MaxPlayers;
    }
    public override void OnJoinedRoom()
    {
        if (PhotonNetwork.IsMasterClient) // HostLogic
        {
            MyNetworkIdentity = NetworkIdentity.Host;
        }

        if (!PhotonNetwork.IsMasterClient) // Client Logic
        {
            MyNetworkIdentity = NetworkIdentity.Client;
        }
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        if (GetRoomPlayerCount() == CurrentRoomMaxSize)
        {
            Debug.Log("Game can start.");
        }
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        
    }
    public override void OnLeftLobby()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnLeftRoom()
    {
        CurrentRoomMaxSize = 0;
        MyNetworkIdentity = NetworkIdentity.NotSet;
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        PhotonNetwork.LeaveRoom();
        Debug.Log("Left Room. Back in lobby.");
    }

    private void StartNewMatch ()
    {

    }
    private int GetRoomPlayerCount ()
    {
        return PhotonNetwork.CurrentRoom.PlayerCount;
    }
    private void TryToConnect ()
    {
        try
        {
            PhotonNetwork.ConnectUsingSettings();
        }

        catch (Exception e)
        {
            Debug.Log(e);
        }

    }
}
