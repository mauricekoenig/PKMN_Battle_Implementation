using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PokemonController : MonoBehaviour
{
    private HealthBar healthBar;
    [SerializeField] private Pokemon pkmn;

    private void Awake()
    {
        healthBar = GetComponent<HealthBar>();
    }

    public void SetHealthBarTrigger (float damage)
    {
        healthBar.SendDamageToBar(damage);
    }
    private void SyncHealthBar (Pokemon pokemon)
    {
        healthBar.Synchronize(pokemon);
    }
    public void HandOverInfo (Pokemon pokemon)
    {
        pkmn = pokemon;
        SyncHealthBar(pkmn);
    }

}
