using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startstatlevcutscene : MonoBehaviour
{
    private const string Message = "hey!";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tag: "player"))
        {
            Debug.Log(Message);
        }

    }
}
