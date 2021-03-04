using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public sealed class Databases : MonoBehaviour
{

    public static Databases x;
    public List<Pokemon> Pokemon = new List<Pokemon>();
    public Pokemon pokemon;

    private void Awake()
    {
        if (x == null) x = this;
        else Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }
    public Pokemon GetPokemon (string pkmnName)
    {
        var match = Pokemon.Where(x => x.pokemonName == pkmnName).ToArray();
        return match[0];
    }

}
