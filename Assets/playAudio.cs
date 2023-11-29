using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioClip splashSound;
    public AudioSource audioSource; //reference to my audio source

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            audioSource.PlayOneShot(splashSound);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            audioSource.PlayOneShot(splashSound);
        }
    }
}
