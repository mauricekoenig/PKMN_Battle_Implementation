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
            double value = 0;
            int F1 = Burn * Reducing * WeatherBoost * OtherBoostingSources;

            value = 100 * 2;
            value = Math.Floor(value / 5);
            value = Math.Floor(value + 2);
            value = Math.Floor(value * Move.moveBasePower);
            value = Math.Floor(value * attacker.PhysicalAttack);
            value = Math.Floor(value / defender.PhysicalDefense);
            value = Math.Floor(value / 50);
            value = Math.Floor(value + 2);

            value = Math.Floor(value * F1);
            value = Math.Floor(value * CriticalHit);
            value = Math.Floor(value * DamageBoostingItem);
            value = Math.Floor(value * Testing.x.roll);
            value = Math.Floor(value / 100);
            value = Math.Floor(value * TypeUtility.GetSTABMultiplier(Move, Attacker));
            value = Math.Floor(value * TypeUtility.GetEffectiveMultiplier(Move, Defender));
            value = Math.Floor(value * BerryOrExpertBelt);
            return (int)Math.Floor(value);
        }
        else if (MoveCategory == PokemonMoveCategory.Special)
        {
            double value = 0;
            int F1 = 1 * Reducing * WeatherBoost * OtherBoostingSources;

            value = 100 * 2;
            value = Math.Floor(value / 5);
            value = Math.Floor(value + 2);
            value = Math.Floor(value * Move.moveBasePower);
            value = Math.Floor(value * attacker.SpecialAttack);
            value = Math.Floor(value / defender.SpecialDefense);
            value = Math.Floor(value / 50);
            value = Math.Floor(value + 2);

            value = Math.Floor(value * F1);
            value = Math.Floor(value * CriticalHit);
            value = Math.Floor(value * DamageBoostingItem);
            value = Math.Floor(value * Testing.x.roll);
            value = Math.Floor(value / 100);
            value = Math.Floor(value * TypeUtility.GetSTABMultiplier(Move, Attacker));
            value = Math.Floor(value * TypeUtility.GetEffectiveMultiplier(Move, Defender));
            value = Math.Floor(value * BerryOrExpertBelt);
            return (int)Math.Floor(value);
        }

        else return -1000;
    }
}
