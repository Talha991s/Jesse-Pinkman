using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public AudioSource E_Dying;
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
            E_Dying.Play();
            Die();
        }
    }

    private void Die()
    {
        
        gameObject.SetActive(false);
    }
}
