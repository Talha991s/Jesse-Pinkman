using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Heath : MonoBehaviour
{
    [SerializeField]
    private int startingHealth =50;

    [SerializeField]private int CurrentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        healthBar.SetMaxHealth(startingHealth);
    }
    private void OnEnable()
    {
        CurrentHealth = startingHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        healthBar.SetHealth(CurrentHealth);
        if(CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
