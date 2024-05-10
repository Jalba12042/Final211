using UnityEngine;
using System.Collections.Generic;

public class VoiceLines : MonoBehaviour
{
    public AudioClip[] voiceLines;

    public float delayBetweenClips = 1.0f;

    private AudioSource audioSource;

    private Queue<AudioClip> clipQueue = new Queue<AudioClip>();

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clipQueue.Clear();

            if (voiceLines != null && voiceLines.Length > 0)
            {
                foreach (AudioClip clip in voiceLines)
                {
                    clipQueue.Enqueue(clip);
                }

                PlayNextClip();
            }
        }
    }

    private void PlayNextClip()
    {
        if (clipQueue.Count > 0)
        {
            AudioClip nextClip = clipQueue.Dequeue();

            audioSource.clip = nextClip;

            float totalTime = nextClip.length + delayBetweenClips;

            Invoke("PlayNextClip", totalTime);

            audioSource.Play();
        }
    }
}
