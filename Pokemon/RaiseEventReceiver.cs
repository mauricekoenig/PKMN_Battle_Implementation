using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

public sealed class RaiseEventReceiver : MonoBehaviour, IOnEventCallback
{

    public static RaiseEventReceiver x;

    private void Awake()
    {
        if (x == null) x = this;
        else Destroy(gameObject);

        PhotonNetwork.AddCallbackTarget(this);
    }

    public void OnEvent(EventData photonEvent)
    {
        var eventCode = photonEvent.Code;

        if (eventCode == 1)
        {
            ReceiveTeamSyncEvent(photonEvent);
        }
    }

    private void ReceiveTeamSyncEvent(EventData eventObject)
    {
        string[] data = (string[])eventObject.CustomData;
        if (NetworkManager.x.GetPlayerIdentity() == NetworkIdentity.Host)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Debug.Log(data[i]);
                BattleInfo.x.ClientTeamAsStrings.Add(data[i]);
            }
        }
        if (NetworkManager.x.GetPlayerIdentity() == NetworkIdentity.Client)
        {
            for (int i = 0; i < data.Length; i++)
            {
                Debug.Log(data[i]);
                BattleInfo.x.HostTeamAsStrings.Add(data[i]);
            }
        }
    }
    
}
