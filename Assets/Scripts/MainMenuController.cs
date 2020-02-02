using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void intro()
    {
        Debug.Log("I got to intro!");
        SceneManager.LoadScene("Intro");
    }
    public void exit()
    {
        Application.Quit();
    }
}
