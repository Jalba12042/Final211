using UnityEngine;

public class VoiceLines : MonoBehaviour
{
    // Reference to the audio clip you want to play
    public AudioClip voiceLine;

    // Reference to the audio source component
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to this GameObject
        //audioSource = GetComponent<AudioSource>();

        // Assign the provided AudioClip to the AudioSource component
        //audioSource.clip = voiceLine;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject entering the trigger has a "Player" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("voiceline");
            // Play the assigned voiceline
            //audioSource.Play();
        }
    }
}
