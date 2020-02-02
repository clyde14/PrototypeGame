using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroStart : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audioData;
    GameObject finish;

    void Start()
    {
        finish = GameObject.Find("Finish");
        finish.SetActive(false);
        audioData = GetComponent<AudioSource>();
        audioData.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioData.isPlaying)
        {
            finish.SetActive(true);
        }
    }
}
