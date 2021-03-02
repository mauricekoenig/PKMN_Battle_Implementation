using System;
using UnityEngine;

public static class DamageCalculator
{
    public static IDamageReducingEffect ClientActives;
    public static IDamageReducingEffect HostActives;

    public const int DoubleHit = 1;
    public const int Burn = 1;
    public const int Reducing = 1;
    public const int WeatherBoost = 1;
    public const int OtherBoostingSources = 1;
    public const int CriticalHit = 1;
    public const int DamageBoostingItem = 1;
    public const int RandomGeneratedFactor = 85;
    public const int BerryOrExpertBelt = 1;

    public static int Attack (PokemonMove attackingMove, Pokemon attacker, Pokemon defender)
    {
        var Attacker = attacker;
        var Defender = defender;
        var Move = attackingMove;
        var MoveCategory = attackingMove.moveCategory;

        if (MoveCategory == PokemonMoveCategory.Physical)
        {
            float value = 0;
            int F1 = Burn * Reducing * WeatherBoost * OtherBoostingSources;

            value = Mathf.Round(100 * 2);
            value = Mathf.Round(value / 5);
            value = Mathf.Round(value + 2);
            value = Mathf.Round(value * Move.moveBasePower);
            value = Mathf.Round(value * attacker.PhysicalAttack);
            value = Mathf.Round(value / defender.PhysicalDefense);
            value = Mathf.Round(value / 50);
            value = Mathf.Round(value + 2);

            value = Mathf.Round(value * F1);
            value = Mathf.Round(value * CriticalHit);
            value = Mathf.Round(value * DamageBoostingItem);
            value = Mathf.Round(value * Testing.x.roll);
            value = Mathf.Round(value / 100);
            value = Mathf.Round(value * TypeUtility.GetSTABMultiplier(Move, Attacker));
            value = Mathf.Round(value * TypeUtility.GetEffectiveMultiplier(Move, Defender));
            value = Mathf.Round(value * BerryOrExpertBelt);
            return Mathf.RoundToInt(value);
        }
        else if (MoveCategory == PokemonMoveCategory.Special)
        {
            float value = 0;
            int F1 = Burn * Reducing * WeatherBoost * OtherBoostingSources;

            value = Mathf.Round(100 * 2);
            value = Mathf.Round(value / 5);
            value = Mathf.Round(value + 2);
            value = Mathf.Round(value * Move.moveBasePower);
            value = Mathf.Round(value * attacker.SpecialAttack);
            value = Mathf.Round(value / defender.SpecialDefense);
            value = Mathf.Round(value / 50);
            value = Mathf.Round(value + 2);

            value = Mathf.Round(value * F1);
            value = Mathf.Round(value * CriticalHit);
            value = Mathf.Round(value * DamageBoostingItem);
            value = Mathf.Round(value * Testing.x.roll);
            value = Mathf.Round(value / 100);
            value = Mathf.Round(value * TypeUtility.GetSTABMultiplier(Move, Attacker));
            value = Mathf.Round(value * TypeUtility.GetEffectiveMultiplier(Move, Defender));
            value = Mathf.Round(value * BerryOrExpertBelt);
            return Mathf.RoundToInt(value);
        }
        else return -1000;
    }
}
