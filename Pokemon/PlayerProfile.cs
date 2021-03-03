using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PlayerProfile : MonoBehaviour
{
    public string Name { get; set; }
    public float TimePlayed { get; set; }
    public int Victories { get; set; }
    public int Defeats { get; set; }

    public List<Pokemon> ActiveTeam = new List<Pokemon>();
    //public List<Team> StoredTeams = new List<Team>();

    public static PlayerProfile x;

    public void Awake()
    {
        if (x == null) x = this;
        Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        ActiveTeam.Clear();
    }

}
