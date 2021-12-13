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
            if (_AudioSource1.isPlaying)
            {

                _AudioSource1.Stop();

                _AudioSource2.Play();

            }

            else
            {

                _AudioSource2.Stop();

                _AudioSource1.Play();

            }
            Debug.Log(Message);
        }
        }
}
