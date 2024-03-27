using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    public float speedBoostAmount = 5.0f; // Speed boost amount
    public float boostDuration = 5.0f; // Duration of the speed boost in seconds

    private bool isPickedUp = false;
    private float originalSpeed;
    private float boostEndTime;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPickedUp)
        {
            SC_FPSController playerController = GameObject.Find("Player").GetComponent<SC_FPSController>();

            if (playerController != null)
            {
                isPickedUp = true;
                originalSpeed = playerController.walkingSpeed;
                boostEndTime = Time.time + boostDuration;

                playerController.walkingSpeed += speedBoostAmount;
                Destroy(gameObject); // Remove the item after it's picked up

                // You can play a pickup sound or show a particle effect here
            }
        }
    }

    private void Update()
    {
        if (isPickedUp && Time.time >= boostEndTime)
        {
            SC_FPSController playerController = GameObject.Find("Player").GetComponent<SC_FPSController>();
            if (playerController != null)
            {
                playerController.walkingSpeed = originalSpeed;
            }
        }
    }
}
