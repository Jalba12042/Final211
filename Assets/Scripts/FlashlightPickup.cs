using UnityEngine;

public class FlashlightPickup : MonoBehaviour
{
    public Transform hand; // The transform of the hand where the flashlight will be placed when picked up
    public Light flashlight; // The flashlight's Light component
    public KeyCode toggleKey = KeyCode.F; // Key to toggle the flashlight

    //public Transform camTransform;//camera's transform
    //public Transform flashlightTransform;

    private bool isPickedUp = false;
    private bool isFlashlightOn = false;

    private void Start()
    {
        // Initially, turn off the flashlight
        flashlight.enabled = false;
    }

    private void Update()
    {
        if (isPickedUp && Input.GetKeyDown(toggleKey))
        {
            ToggleFlashlight();
        }

        
        ////get current rotation of obj
        //Vector3 currentRotation = flashlightTransform.eulerAngles;
        ////get rotation of camera
        //float zRot = camTransform.rotation.z;
        //currentRotation.z += zRot;
        //flashlightTransform.eulerAngles = currentRotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isPickedUp)
        {
            // Parent the flashlight to the player's hand
            transform.parent = hand;
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            isPickedUp = true;
            // Disable the flashlight's collider and renderer
            GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;

            // Enable the flashlight's Light component
            flashlight.enabled = true;
        }
    }

    private void ToggleFlashlight()
    {
        isFlashlightOn = !isFlashlightOn;
        flashlight.enabled = isFlashlightOn;
    }
}
