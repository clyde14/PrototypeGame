using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartLevel1 : MonoBehaviour
{

    public GameObject player;
    AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().canMove = false;
        audioData = GetComponent<AudioSource>();
        FindObjectOfType<AudioManager>().Play("Theme");
    }

    void Update()
    {
        if (!audioData.isPlaying)
        {
            player.GetComponent<PlayerMovement>().canMove = true;
        }
    }
}
