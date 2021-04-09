using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int startingHealth = 5;

    [SerializeField] private int CurrentHealth;

    private void OnEnable()
    {
        CurrentHealth = startingHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
       // healthBar.SetHealth(CurrentHealth);
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
