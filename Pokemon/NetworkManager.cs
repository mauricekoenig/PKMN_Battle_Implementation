using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ExitGames.Client.Photon;

public sealed class NetworkManager : MonoBehaviourPunCallbacks
{
    public static NetworkManager x;
    public int CurrentRoomMaxSize { get; private set; }
    public NetworkIdentity PlayerIdentity { get; private set; }

    private void Awake()
    {
        if (x == null) x = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        BuildConnection();
    }
    private void Update()
    {
        if (InLobbyAndReady())
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                CreateNewRoom();
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                PhotonNetwork.JoinRandomRoom();
            }
        }
    }

    public override void OnConnected()
    {
        PlayerIdentity = NetworkIdentity.NotSet;
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
        Debug.Log("OnCreatedRoom " + CurrentRoomMaxSize);
    }
    public override void OnJoinedRoom()
    {
        if (PhotonNetwork.IsMasterClient) // HostLogic
        {
            PlayerIdentity = NetworkIdentity.Host;
            Debug.Log("OnJoinedRoom: " + PlayerIdentity.ToString());
        }

        if (!PhotonNetwork.IsMasterClient) // Client Logic
        {
            PlayerIdentity = NetworkIdentity.Client;
            Debug.Log("OnJoinedRoom: " + PlayerIdentity.ToString());
        }
    }
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        if (GetRoomPlayerCount() == CurrentRoomMaxSize)
        {
            SceneManager.LoadScene("BattleScene");
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
        PlayerIdentity = NetworkIdentity.NotSet;
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        PhotonNetwork.LeaveRoom();
        Debug.Log("Left Room. Back in lobby.");
    }
    private void BuildConnection ()
    {
        try
        {
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }

        catch (Exception e)
        {
            Debug.Log(e);
        }

    }
    private int GetRoomPlayerCount ()
    {
        return PhotonNetwork.CurrentRoom.PlayerCount;
    }
    public void CreateNewRoom ()
    {
        RoomOptions NewRoom = new RoomOptions
        {
            MaxPlayers = 2,
            PlayerTtl = 2000,
            IsOpen = true,
            IsVisible = true
        };

        PhotonNetwork.CreateRoom(Guid.NewGuid().ToString(), NewRoom, TypedLobby.Default);

    }
    private bool InLobbyAndReady ()
    {
        if (PhotonNetwork.InLobby && !PhotonNetwork.InRoom)
        {
            return true;
        }

        else return false;
    }
    public NetworkIdentity GetPlayerIdentity ()
    {
        if (PhotonNetwork.InRoom && PhotonNetwork.IsMasterClient)
            return NetworkIdentity.Host;

        else if (PhotonNetwork.InRoom && !PhotonNetwork.IsMasterClient)
            return NetworkIdentity.Client;

        else return NetworkIdentity.NotSet;
    }
}
