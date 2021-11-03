using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiochange : MonoBehaviour
{
    // Start is called before the first frame update
    public static SoundEffectsHelper Instance;

    public AudioClip explosionSound;
    public AudioClip playerShotSound;
    public AudioClip enemyShotSound;

    void Awake()
    {
        // Register the singleton
        if (Instance != null)
        {
            Debug.LogError("Multiple instances of SoundEffectsHelper!");
        }
        Instance = this;
    }

    public void MakeExplosionSound()
    {
        MakeSound(explosionSound);
    }

    public void MakePlayerShotSound()
    {
        MakeSound(playerShotSound);
    }

    public void MakeEnemyShotSound()
    {
        MakeSound(enemyShotSound);
    }

    /// <summary>
    /// Play a given sound
    /// </summary>
    /// <param name="originalClip"></param>
    private void MakeSound(AudioClip originalClip)
    {
        // As it is not 3D audio clip, position doesn't matter.
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }
}

    void OnTriggerEnter(other : Collider)
        {
        // Make sure your character is tagged 'player'
            if (other.gameObject.tag == "player")
            {
            // Plays the audio that you want...
                audio.Play();
            }
    }
}
