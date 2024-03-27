using UnityEngine;

public class DamageBoostItem : MonoBehaviour
{
    public float damageBoostMultiplier = 1.5f;
    public float boostDuration = 10.0f;

    private bool isPickedUp = false;
    private float originalDamage;
    private float boostEndTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPickedUp)
        {
            PlayerDamage playerController = other.GetComponent<PlayerDamage>();

            if (playerController != null)
            {
                isPickedUp = true;
                originalDamage = playerController.damage;
                boostEndTime = Time.time + boostDuration;

                playerController.damage *= damageBoostMultiplier;
                Destroy(gameObject);

            }
        }
    }

    private void Update()
    {
        if (isPickedUp && Time.time >= boostEndTime)
        {
            PlayerDamage playerController = FindObjectOfType<PlayerDamage>();
            if (playerController != null)
            {
                playerController.damage = originalDamage;
            }
        }
    }
}
