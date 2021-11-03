using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiochange : MonoBehaviour
{
    //public AudioClip tension;
    public AudioSource tensionZone;
    public AudioSource background;

    // Start is called before the first frame update
    
    void OnTriggerEnter(Collider other)
        {
        // Make sure your character is tagged 'player'
            if (other.CompareTag("player"))
            {
        // Plays the audio that you want...
                background.Stop();
                tensionZone.Play();
            }
        }
}
