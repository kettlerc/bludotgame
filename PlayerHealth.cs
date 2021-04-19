using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;
    public AudioSource takeDamage;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void Update()
    {
        if (currentHealth == 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            takeDamage.Play();
            TakeDamage(1);
        }
        if (other.gameObject.CompareTag("Coffee"))
        {
            GiveLife(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void GiveLife(int damage)
    {
        currentHealth += damage;
        healthBar.SetHealth(currentHealth);
    }
}
