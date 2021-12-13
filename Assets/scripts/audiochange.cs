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
            // checks which audio source is playing
            if (background.isPlaying)
            {
                //stops background music
                background.Stop();
                //starts tension music
                tensionZone.Play();

            }

            else
            {
                //stops tension music
                tensionZone.Stop();
                //plays tension music
                background.Play();

            }
            Debug.Log(Message);
        }
        }
}
