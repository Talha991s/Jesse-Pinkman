using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath : MonoBehaviour
{
    [SerializeField]
    private int startingHealth =5;

    private int CurrentHealth;

    private void OnEnable()
    {
        CurrentHealth = startingHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
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
