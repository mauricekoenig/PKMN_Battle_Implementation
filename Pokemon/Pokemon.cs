using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class Pokemon : ScriptableObject
{
    public string pokemonName;
    public string pokemonDexID;
    public PokemonType firstType;
    public PokemonType secondType;
    public PokemonMove[] moves = new PokemonMove[4];

    public List<PokemonType> weaknesses = new List<PokemonType>();
    public List<PokemonType> resistances = new List<PokemonType>();
    public List<PokemonType> immunities = new List<PokemonType>();

    [Header("Base stats")]
    public int HP;
    public int PhysicalAttack;
    public int PhysicalDefense;
    public int SpecialAttack;
    public int SpecialDefense;
    public int Speed;

    [Space]
    public PokemonStatus pokemonStatus;
}

