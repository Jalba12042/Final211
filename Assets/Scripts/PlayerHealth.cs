using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100.0f;
    private float currentHealth;
    public Transform respawnPoint; // Set this in the Inspector

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
            Debug.Log("Dead");
        }
    }

    void Die()
    {
        transform.position = respawnPoint.position;
        currentHealth = maxHealth; // Reset the player's health.
        
    }
}
