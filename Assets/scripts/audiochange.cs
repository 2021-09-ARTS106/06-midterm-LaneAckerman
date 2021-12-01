using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiochange : MonoBehaviour
{
    //public AudioClip tension;
    public AudioSource tensionZone;
    public AudioSource background;
    private const string Message = "hey!";

    // Start is called before the first frame update

    void OnTriggerEnter(Collider other)
        {
        // Make sure your character is tagged 'player'
        if (other.gameObject.CompareTag("Player"))
            {
        // Plays the audio that you want...
                background.Stop();
                tensionZone.Play();
                Debug.Log(Message);
        }
        }
}
