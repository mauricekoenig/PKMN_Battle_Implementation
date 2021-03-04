using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public sealed class BattleInfo : MonoBehaviour
{
    public static BattleInfo x;
    public List<Pokemon> OtherPlayerTeam = new List<Pokemon>();

    private void Awake()
    {
        if (x == null) x = this;
        else Destroy(gameObject);
    }
}
