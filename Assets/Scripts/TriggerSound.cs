using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerSound : MonoBehaviour
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


    void Update()
    {
        if(audioData.isPlaying)
        {
            Debug.Log("Pause Game");
            Time.timeScale = 0f;
        } else if (entered && !audioData.isPlaying){
            Time.timeScale = 1f;
            Destroy(gameObject);
        }
    }
}



