using System;
using System.Collections.Generic;
using UnityEngine;

public static class TypeUtility
{
    public static void GetWeaknesses (Pokemon pokemon)
    {
        var passedType = pokemon.firstType;
        var passedType2 = pokemon.secondType;
        List<PokemonType> temp = new List<PokemonType>();

        if (passedType != PokemonType.NoType)
        {
            if (passedType == PokemonType.Fire)
            {
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Water);
            }
            if (passedType == PokemonType.Water)
            {
                temp.Add(PokemonType.Electric);
                temp.Add(PokemonType.Grass);
            }
            if (passedType == PokemonType.Grass)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Ice);
            }
            if (passedType == PokemonType.Electric)
            {
                temp.Add(PokemonType.Ground);
            }
            if (passedType == PokemonType.Bug)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Rock);
            }
            if (passedType == PokemonType.Ice)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Steel);
            }
            if (passedType == PokemonType.Dragon)
            {
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Dragon);
                temp.Add(PokemonType.Ice);
            }
            if (passedType == PokemonType.Fairy)
            {
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Steel);
            }
            if (passedType == PokemonType.Poison)
            {
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Psychic);
            }
            if (passedType == PokemonType.Psychic)
            {
                temp.Add(PokemonType.Dark);
                temp.Add(PokemonType.Ghost);
                temp.Add(PokemonType.Bug);
            }
            if (passedType == PokemonType.Steel)
            {
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Fighting);
            }
            if (passedType == PokemonType.Rock)
            {
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Fighting);
            }
            if (passedType == PokemonType.Ground)
            {
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Grass);
            }
            if (passedType == PokemonType.Flying)
            {
                temp.Add(PokemonType.Electric);
                temp.Add(PokemonType.Ice);
                temp.Add(PokemonType.Rock);
            }
            if (passedType == PokemonType.Fighting)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Psychic);
            }
            if (passedType == PokemonType.Ghost)
            {
                temp.Add(PokemonType.Dark);
                temp.Add(PokemonType.Ghost);
            }
            if (passedType == PokemonType.Normal)
            {
                temp.Add(PokemonType.Fighting);
            }
            if (passedType == PokemonType.Dark)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Bug);
            }
        }
        if (passedType2 != PokemonType.NoType)
        {
            if (passedType2 == PokemonType.Fire)
            {
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Water);
            }
            if (passedType2 == PokemonType.Water)
            {
                temp.Add(PokemonType.Electric);
                temp.Add(PokemonType.Grass);
            }
            if (passedType2 == PokemonType.Grass)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Ice);
            }
            if (passedType2 == PokemonType.Electric)
            {
                temp.Add(PokemonType.Ground);
            }
            if (passedType2 == PokemonType.Bug)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Rock);
            }
            if (passedType2 == PokemonType.Ice)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Steel);
            }
            if (passedType2 == PokemonType.Dragon)
            {
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Dragon);
                temp.Add(PokemonType.Ice);
            }
            if (passedType2 == PokemonType.Fairy)
            {
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Steel);
            }
            if (passedType2 == PokemonType.Poison)
            {
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Psychic);
            }
            if (passedType2 == PokemonType.Psychic)
            {
                temp.Add(PokemonType.Dark);
                temp.Add(PokemonType.Ghost);
                temp.Add(PokemonType.Bug);
            }
            if (passedType2 == PokemonType.Steel)
            {
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Fighting);
            }
            if (passedType2 == PokemonType.Rock)
            {
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Fighting);
            }
            if (passedType2 == PokemonType.Ground)
            {
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Grass);
            }
            if (passedType2 == PokemonType.Flying)
            {
                temp.Add(PokemonType.Electric);
                temp.Add(PokemonType.Ice);
                temp.Add(PokemonType.Rock);
            }
            if (passedType2 == PokemonType.Fighting)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Psychic);
            }
            if (passedType2 == PokemonType.Ghost)
            {
                temp.Add(PokemonType.Dark);
                temp.Add(PokemonType.Ghost);
            }
            if (passedType2 == PokemonType.Normal)
            {
                temp.Add(PokemonType.Fighting);
            }
            if (passedType2 == PokemonType.Dark)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Bug);
            }
        }
        for (int i = 0; i < temp.Count; i++)
        {
            pokemon.weaknesses.Add(temp[i]);
        }
    }
    public static void GetResistances (Pokemon pokemon)
    {
        var passedType = pokemon.firstType;
        var passedType2 = pokemon.secondType;
        List<PokemonType> temp = new List<PokemonType>();

        if (passedType != PokemonType.NoType) // First Type
        {
            if (passedType == PokemonType.Fire)
            {
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Ice);
                temp.Add(PokemonType.Steel);
            }
            if (passedType == PokemonType.Water)
            {
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Ice);
            }
            if (passedType == PokemonType.Grass)
            {
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Electric);
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Water);
            }
            if (passedType == PokemonType.Electric)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Electric);
            }
            if (passedType == PokemonType.Bug)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Grass);
            }
            if (passedType == PokemonType.Ice)
            {
                temp.Add(PokemonType.Ice);
            }
            if (passedType == PokemonType.Dragon)
            {
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Electric);
            }
            if (passedType == PokemonType.Fairy)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Dark);
            }
            if (passedType == PokemonType.Poison)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Grass);
            }
            if (passedType == PokemonType.Psychic)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Psychic);
            }
            if (passedType == PokemonType.Steel)
            {
                temp.Add(PokemonType.Normal);
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Psychic);
                temp.Add(PokemonType.Ice);
                temp.Add(PokemonType.Dragon);
                temp.Add(PokemonType.Fairy);
            }
            if (passedType == PokemonType.Rock)
            {
                temp.Add(PokemonType.Normal);
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Fire);
            }
            if (passedType == PokemonType.Ground)
            {
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Rock);
            }
            if (passedType == PokemonType.Flying)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Grass);
            }
            if (passedType == PokemonType.Fighting)
            {
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Dark);
            }
            if (passedType == PokemonType.Ghost)
            {
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Bug);
            }
            if (passedType == PokemonType.Normal)
            {
                
            }
            if (passedType == PokemonType.Dark)
            {
                temp.Add(PokemonType.Dark);
                temp.Add(PokemonType.Ghost);
            }
        }
        if (passedType2 != PokemonType.NoType)
        {
            if (passedType2 == PokemonType.Fire)
            {
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Ice);
                temp.Add(PokemonType.Steel);
            }
            if (passedType2 == PokemonType.Water)
            {
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Ice);
            }
            if (passedType2 == PokemonType.Grass)
            {
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Electric);
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Water);
            }
            if (passedType2 == PokemonType.Electric)
            {
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Electric);
            }
            if (passedType2 == PokemonType.Bug)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Ground);
                temp.Add(PokemonType.Grass);
            }
            if (passedType2 == PokemonType.Ice)
            {
                temp.Add(PokemonType.Ice);
            }
            if (passedType2 == PokemonType.Dragon)
            {
                temp.Add(PokemonType.Fire);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Water);
                temp.Add(PokemonType.Electric);
            }
            if (passedType2 == PokemonType.Fairy)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Dark);
            }
            if (passedType2 == PokemonType.Poison)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Fairy);
                temp.Add(PokemonType.Grass);
            }
            if (passedType2 == PokemonType.Psychic)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Psychic);
            }
            if (passedType2 == PokemonType.Steel)
            {
                temp.Add(PokemonType.Normal);
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Steel);
                temp.Add(PokemonType.Grass);
                temp.Add(PokemonType.Psychic);
                temp.Add(PokemonType.Ice);
                temp.Add(PokemonType.Dragon);
                temp.Add(PokemonType.Fairy);
            }
            if (passedType2 == PokemonType.Rock)
            {
                temp.Add(PokemonType.Normal);
                temp.Add(PokemonType.Flying);
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Fire);
            }
            if (passedType2 == PokemonType.Ground)
            {
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Rock);
            }
            if (passedType2 == PokemonType.Flying)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Grass);
            }
            if (passedType2 == PokemonType.Fighting)
            {
                temp.Add(PokemonType.Rock);
                temp.Add(PokemonType.Bug);
                temp.Add(PokemonType.Dark);
            }
            if (passedType2 == PokemonType.Ghost)
            {
                temp.Add(PokemonType.Poison);
                temp.Add(PokemonType.Bug);
            }
            if (passedType2 == PokemonType.Normal)
            {

            }
            if (passedType2 == PokemonType.Dark)
            {
                temp.Add(PokemonType.Dark);
                temp.Add(PokemonType.Ghost);
            }
        }

        for (int i = 0; i < temp.Count; i++)
        {
            pokemon.resistances.Add(temp[i]);
        }
        Testing.x.visual = pokemon.resistances;
    }
    public static void GetImmunities (Pokemon pokemon)
    {
        var passedType = pokemon.firstType;
        var passedType2 = pokemon.secondType;
        List<PokemonType> temp = new List<PokemonType>();

        if (passedType != PokemonType.NoType)
        {
            if (passedType == PokemonType.Fairy)
            {
                temp.Add(PokemonType.Dragon);
            }
            if (passedType == PokemonType.Steel)
            {
                temp.Add(PokemonType.Poison);
            }
            if (passedType == PokemonType.Ground)
            {
                temp.Add(PokemonType.Electric);
            }
            if (passedType == PokemonType.Flying)
            {
                temp.Add(PokemonType.Ground);
            }
            if (passedType == PokemonType.Ghost)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Normal);
            }
            if (passedType == PokemonType.Normal)
            {
                temp.Add(PokemonType.Ghost);
            }
            if (passedType == PokemonType.Dark)
            {
                temp.Add(PokemonType.Psychic);
            }
        }
        if (passedType2 != PokemonType.NoType)
        {
            if (passedType2 == PokemonType.Fairy)
            {
                temp.Add(PokemonType.Dragon);
            }
            if (passedType2 == PokemonType.Steel)
            {
                temp.Add(PokemonType.Poison);
            }
            if (passedType2 == PokemonType.Ground)
            {
                temp.Add(PokemonType.Electric);
            }
            if (passedType2 == PokemonType.Flying)
            {
                temp.Add(PokemonType.Ground);
            }
            if (passedType2 == PokemonType.Ghost)
            {
                temp.Add(PokemonType.Fighting);
                temp.Add(PokemonType.Normal);
            }
            if (passedType2 == PokemonType.Normal)
            {
                temp.Add(PokemonType.Ghost);
            }
            if (passedType2 == PokemonType.Dark)
            {
                temp.Add(PokemonType.Psychic);
            }
        }
        for (int i = 0; i < temp.Count; i++)
        {
            pokemon.immunities.Add(temp[i]);
        }

        //for (int i = 0; i < temp.Count; i++)
        //{
        //    if (pokemon.resistances.Contains(temp[i]))
        //        pokemon.resistances.Remove(temp[i]);
        //} // REMOVE RESISTANCE IF IMMUNE
    }
    public static float GetEffectiveMultiplier (PokemonMove move, Pokemon defender)
    {
        var incomingType = move.moveType;
        var matchingWeaknesses = new List<PokemonType>(); // übereinstimmende Schwäche
        var matchingResistances = new List<PokemonType>(); // übereinstimmende Resistenz durch Zweittyp

        foreach (var element in defender.resistances)
        {
            if (element == incomingType)
                matchingResistances.Add(element);
        }
        foreach (var element2 in defender.weaknesses)
        {
            if (element2 == incomingType)
                matchingWeaknesses.Add(element2);
        }

        if (matchingWeaknesses.Count == 0 && matchingResistances.Count == 0)
        {
            return 1; // Neutral Damage
        }
        else if (matchingWeaknesses.Count == 2 && matchingResistances.Count == 0)
        {
            return 4; // Double Weakness
        }
        else if (matchingWeaknesses.Count == 1 && matchingResistances.Count == 1)
        {
            return 1; // Outbalanced Weakness
        }
        else if (matchingWeaknesses.Count == 0 && matchingResistances.Count == 2)
        {
            return 0.25f; // Double Resistance
        }
        else if (matchingWeaknesses.Count == 0 && matchingResistances.Count == 1)
        {
            return 0.5f; // Simple Resistance
        }
        else if (matchingWeaknesses.Count == 1 && matchingResistances.Count == 0)
        {
            return 2; // Simple Effective
        }
        else return 0;
    }
    public static float GetSTABMultiplier(PokemonMove move, Pokemon attacker)
    {
        var firstType = attacker.firstType;
        var secondType = attacker.secondType;
        var moveType = move.moveType;

        if (firstType == moveType)
            return 1.5f;

        else if (secondType == moveType)
            return 1.5f;

        else return 1;
    }
    public static void GetWholeTypeInfo (Pokemon pokemon)
    {
        GetResistances(pokemon);
        GetWeaknesses(pokemon);
        GetImmunities(pokemon);
    }
}
