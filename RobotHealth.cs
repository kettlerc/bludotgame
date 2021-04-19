using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotHealth : MonoBehaviour
{
    public int maxHealth = 9;
    public int currentHealth;
    public HealthBar healthBar;

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
        if (other.gameObject.CompareTag("Crate"))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
