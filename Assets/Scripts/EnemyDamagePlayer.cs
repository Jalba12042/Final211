using UnityEngine;

public class EnemyDamagePlayer : MonoBehaviour
{
    public float damageRate = 10f; // Damage per second
    public int damageRadius = 4; // Proximity radius to damage the player
    public LayerMask Player; // Layer to detect the player

    private float lastDamageTime;
    private PlayerHealth playerHealth;

    private void Start()
    {
        lastDamageTime = Time.time;
        playerHealth = FindObjectOfType<PlayerHealth>(); // Assuming there's a PlayerHealth script on the player
    }

    private void Update()
    {
        if (playerHealth != null && Vector3.Distance(transform.position, playerHealth.transform.position) <= damageRadius)
        {
            // Check if enough time has passed to damage the player again
            if (Time.time - lastDamageTime >= 1.0f / damageRate)
            {
                lastDamageTime = Time.time;
                playerHealth.TakeDamage(1); // Adjust the damage amount as needed
                Debug.Log("Damage");
            }
        }
    }
}
