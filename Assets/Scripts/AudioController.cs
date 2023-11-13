using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource audioSource; // Assign this in the inspector

    // Call this method when the button is clicked
    public void TogglePlayPause()
    {
        //log we reached here
        Debug.Log("TogglePlayPause");
        if (audioSource.isPlaying)
            audioSource.Pause();
        else
            audioSource.Play();
    }
}

