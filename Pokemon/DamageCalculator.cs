using System;
using System.Collections.Generic;
using UnityEngine;

public static class DamageCalculator
{
    private static Weather CurrentWeather;
    public static List<IDamageReducingEffect> HostDamageReductions = new List<IDamageReducingEffect>();
    public static List<IDamageReducingEffect> ClientDamageReductions = new List<IDamageReducingEffect>();

    #region FactorModifier
    private const double MultiTargetModifier = 1;
    private static double BurnModifier = 1;
    private static double DamageReductionModifier = 1;
    private static double WeatherModifier = 1;
    private static double StatChargedModifier = 1;
    private static double CriticalHitModifier = 1;
    private static double ItemModifier = 1;
    private static double RollModifier = 100;
    private static double BerryOrExpBeltModifier = 1;
    #endregion

    public static int GetDamage (PokemonMove attackingMove, Pokemon attacker, Pokemon defender)
    {
        var Attacker = attacker;
        var Defender = defender;
        var Move = attackingMove;
        var MoveCategory = attackingMove.moveCategory;

        SpecifyWeatherInfluence(Move.moveType);

        if (MoveCategory == PokemonMoveCategory.Physical)
        {
            double value = 0;
            double F1 = BurnModifier * DamageReductionModifier * WeatherModifier * StatChargedModifier;

            value = 100 * 2;
            value = Math.Floor(value / 5);
            value = Math.Floor(value + 2);
            value = Math.Floor(value * Move.moveBasePower);
            value = Math.Floor(value * Attacker.PhysicalAttack);
            value = Math.Floor(value / Defender.PhysicalDefense);
            value = Math.Floor(value / 50);
            value = Math.Floor(value + 2);

            value = Math.Floor(value * F1);
            value = Math.Floor(value * CriticalHitModifier);
            value = Math.Floor(value * ItemModifier);
            value = Math.Floor(value * Testing.x.roll);
            value = Math.Floor(value / 100);
            value = Math.Floor(value * TypeUtility.GetSTABMultiplier(Move, Attacker));
            value = Math.Floor(value * TypeUtility.GetEffectiveMultiplier(Move, Defender));
            value = Math.Floor(value * BerryOrExpBeltModifier);

            ResetModifier();
            return (int)Math.Floor(value);
        }
        else if (MoveCategory == PokemonMoveCategory.Special)
        {
            double value = 0;
            double F1 = 1 * DamageReductionModifier * WeatherModifier * StatChargedModifier;

            value = 100 * 2;
            value = Math.Floor(value / 5);
            value = Math.Floor(value + 2);
            value = Math.Floor(value * Move.moveBasePower);
            value = Math.Floor(value * Attacker.SpecialAttack);
            value = Math.Floor(value / (Defender.SpecialDefense * GetSandMultiplier(Defender)) );
            value = Math.Floor(value / 50);
            value = Math.Floor(value + 2);

            value = Math.Floor(value * F1);
            value = Math.Floor(value * CriticalHitModifier);
            value = Math.Floor(value *ItemModifier);
            value = Math.Floor(value * Testing.x.roll);
            value = Math.Floor(value / 100);
            value = Math.Floor(value * TypeUtility.GetSTABMultiplier(Move, Attacker));
            value = Math.Floor(value * TypeUtility.GetEffectiveMultiplier(Move, Defender));
            value = Math.Floor(value * BerryOrExpBeltModifier);

            ResetModifier();
            return (int)Math.Floor(value);
        }
        else return -1000;
    }
    public static Weather GetWeather ()
    {
        return CurrentWeather;
    }
    private static double GetSandMultiplier(Pokemon pokemon)
    {
        if (GetWeather() != Weather.Sand) return 1;

        var firstType = pokemon.firstType;
        var secondType = pokemon.secondType;

        if (firstType == PokemonType.Rock || secondType == PokemonType.Rock)
        {
            return 1.5;
        }

        else return 1;

    }
    public static void SetWeather(Weather newWeather)
    {
        CurrentWeather = newWeather;
    }
    private static void SpecifyWeatherInfluence (PokemonType attackType)
    {
        if (GetWeather() == Weather.Sun)
        {
            if (attackType == PokemonType.Fire)
            {
                WeatherModifier = 1.5;
            }

            if (attackType == PokemonType.Water)
            {
                WeatherModifier = 0.5;
            }
        }

        if (GetWeather() == Weather.Rain)
        {
            if (attackType == PokemonType.Water)
            {
                WeatherModifier = 1.5;
            }

            if (attackType == PokemonType.Fire)
            {
                WeatherModifier = 0.5;
            }
        }
    }
    private static void ResetModifier ()
    {
        WeatherModifier = 1;
        StatChargedModifier = 1;
        DamageReductionModifier = 1;
        BurnModifier = 1;
    }
}
