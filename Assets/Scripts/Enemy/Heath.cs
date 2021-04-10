using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    private void Update()
    {
       
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
        SceneManager.LoadScene(3);
        AppEvents.Invoke_OnMouseCursorEnable(true);
    }

    public void Heal( int amount)
    {
        Debug.Log("eating0");
        CurrentHealth += amount;
        if (CurrentHealth == startingHealth)
        {
            startingHealth = CurrentHealth;
           // Heal(0);
        }
        healthBar.Slider.value = CurrentHealth;
    }
}
