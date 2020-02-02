using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroStart : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    AudioSource audioData;

    void Start()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().canMove = false;
        audioData = GetComponent<AudioSource>();
        FindObjectOfType<AudioManager>().Play("IntroDialogue");
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioData.isPlaying)
        {
            player.GetComponent<PlayerMovement>().canMove = true;
        }
    }
}
