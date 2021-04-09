using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Heath : MonoBehaviour
{
    public AudioSource damagesound;


    [SerializeField]
    private int startingHealth =50;

    [SerializeField]public int CurrentHealth;

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
        damagesound.Play();
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
