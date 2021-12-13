using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class statueanimstart : MonoBehaviour
{
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Player")
        {
            GetComponent<PlayableDirector>().Play();
        }
    }
}
