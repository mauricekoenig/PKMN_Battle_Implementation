using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthBarTMP;
    [SerializeField] private Image healthBar;
    [SerializeField] private float damageBuffer;
    [SerializeField] private float totalHealth;
    [SerializeField] [Range(0, 400)] private float currentHealth;
    [SerializeField] private bool actionRequired;
    [SerializeField] private float nextMinValue;
    [SerializeField] private const float maxValue = 1;
    [SerializeField] [Range(0, 150)] private float decreasingSpeed;
    [SerializeField] float percentage;

    private void Update()
    {
        UpdateCurrentHealthOverTime();
        SynchronizeHealthBar();
    }

    public void UpdateCurrentHealthOverTime ()
    {
        if (nextMinValue == -1) return;
        currentHealth = Mathf.Clamp(currentHealth, nextMinValue, totalHealth);

        if (currentHealth == nextMinValue)
        {
            nextMinValue = -1;
            return; 
        }

        currentHealth -= Time.deltaTime * decreasingSpeed;
        percentage = ((currentHealth * 100) / totalHealth);

        if (percentage > 50) healthBar.color = Utility.HpBar_GREEN;
        if (percentage <= 50 && percentage > 20) healthBar.color = Utility.HpBar_YELLOW;
        if (percentage <= 20 && percentage >= 0) healthBar.color = Utility.HpBar_RED;
    }

    public void SendValue (float incomingDamage)
    {
        damageBuffer = 0;
        nextMinValue = -1;
        damageBuffer = incomingDamage;
        nextMinValue = (currentHealth - damageBuffer);
    }

    private void SynchronizeHealthBar ()
    {
        healthBar.fillAmount = (currentHealth / totalHealth);
        healthBarTMP.text = $"{(int)percentage}%";
    }

    public void HealthBarSetup (Pokemon pkmn)
    {
        nextMinValue = -1;
        totalHealth = pkmn.HP;
        currentHealth = pkmn.HP;
        percentage = ((currentHealth * 100) / totalHealth);
        healthBarTMP.text = $"{(int)percentage}%";
    }
}

