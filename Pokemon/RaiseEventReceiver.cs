using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;
using System.Linq;

public sealed class RaiseEventReceiver : MonoBehaviour, IOnEventCallback
{

    public static RaiseEventReceiver x;
    [SerializeField] private GameObject LocalModel;
    [SerializeField] private GameObject OpponentModel;

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

        if (eventCode == 2)
        {
            ReceiveBattleSetupEvent(photonEvent);
        }
    }

    private void ReceiveTeamSyncEvent(EventData eventObject)
    {
        string[] data = (string[])eventObject.CustomData;

        for (int i = 0; i < data.Length; i++)
        {
            BattleInfo.x.OtherPlayerTeam.Add(Databases.x.GetPokemon(data[i]));
        }
    }
    private void ReceiveBattleSetupEvent (EventData eventObject)
    {
        CreatePokemonModels();
    }
    private void CreatePokemonModels ()
    {
        Vector3 localPosition = new Vector3(-3.85f, -2.11f, 0);
        Vector3 opponentPosition = new Vector3(2.85f, -0.07f, 0);

        GameObject local = Instantiate(LocalModel, localPosition, Quaternion.identity);
        local.GetComponent<PokemonController>().HandOverInfo(PlayerProfile.x.ActiveTeam[0]);

        GameObject opponent = Instantiate(OpponentModel, opponentPosition, Quaternion.identity);
        opponent.GetComponent<PokemonController>().HandOverInfo(BattleInfo.x.OtherPlayerTeam[0]);
    }
    
}
