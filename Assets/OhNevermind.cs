using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OhNevermind : MonoBehaviour
{
    private bool entered = false;
    public GameObject setObj;
    AudioSource audioData;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        audioData = GetComponent<AudioSource>();

        if (!entered && other.name == setObj.name)
        {
            audioData.Play();
            entered = true;

        }

    }

}
