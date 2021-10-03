using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int healthLevel = 10;
    public float maxHealth;
    public float currentHealth;

    public int staminaLevel = 10;
    public float maxStamina;
    public float currentStamina;
    public float staminaRechargeRate = 10f;

    public HealthBar healthBar;
    public StaminaBar staminaBar;
    private AnimatorManager animatorManager;

    private void Awake()
    {
        animatorManager = GetComponent<AnimatorManager>();
        healthBar = FindObjectOfType<HealthBar>();
        staminaBar = FindObjectOfType<StaminaBar>();
    }

    private void Start()
    {
        maxHealth = SetMaxHealthFromHealthLevel();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        maxStamina = SetMaxStaminaFromStaminaLevel();
        currentStamina = maxStamina;
        staminaBar.SetMaxStamina(maxStamina);
    }

    private float SetMaxHealthFromHealthLevel()
    {
        maxHealth = healthLevel * 10;
        return maxHealth;
    }

    private float SetMaxStaminaFromStaminaLevel()
    {
        maxStamina = staminaLevel * 10;
        return maxStamina;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        healthBar.SetCurrentHealth(currentHealth);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            animatorManager.PlayTargetAnimation("Death", true, true);
        }
        else
        {
            animatorManager.PlayTargetAnimation("HitToBody", true, true);
        }
    }

    public void DrainStamina(int drainValue)
    {
        currentStamina -= drainValue;
        if (currentStamina <= 0)
            currentStamina = 0;
        staminaBar.SetCurrentStamina(currentStamina);
    }
}
