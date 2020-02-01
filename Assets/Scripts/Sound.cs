using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    private bool entered = false;
    void OnTriggerEnter2D(Collider2D Other) {

        if (!entered)
        {
            GetComponent<AudioSource>().Play();
            entered = true;
        }
    }
    
}
