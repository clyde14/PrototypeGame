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
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
    }

    void Update()
    {
        if (!audioData.isPlaying)
        {
            player.GetComponent<PlayerMovement>().canMove = true;
        }
    }
}
