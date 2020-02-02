using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne : MonoBehaviour
{

    private bool entered = false;
    public GameObject setObj;
    void OnTriggerEnter2D(Collider2D other) {

        if (!entered && other.name == setObj.name)
        {
           
            GetComponent<AudioSource>().Play();
            entered = true;

        }
    }
    
}
