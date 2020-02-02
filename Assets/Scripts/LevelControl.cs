using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public int index;
    bool entered = false;
    public string levelName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !entered)
        {
            FindObjectOfType<AudioManager>().Play("Victory");
            entered = true;
            StartCoroutine(WaitToLoad());
            //SceneManager.LoadScene(levelName);
        }

        
    }

    IEnumerator WaitToLoad()
    {
        yield return new WaitForSeconds(2.8f);
        SceneManager.LoadScene(levelName);
    }
}
