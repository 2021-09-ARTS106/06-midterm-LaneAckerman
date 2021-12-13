using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictransition : MonoBehaviour
{
    private static musictransition instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
