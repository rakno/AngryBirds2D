using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefabMonitor : MonoBehaviour
{

    private AudioClip backgroundSound;
    public AudioSource backgroundSource;

    string objectTag = "Pig";
  

    void Update()
    {
        if (GameObject.FindGameObjectWithTag(objectTag) == null)
        {
            SceneManager.LoadScene("winPage");
        }
    }

    void Start()
    {
        backgroundSource.Play();
        if (string.IsNullOrEmpty(objectTag))
        {
            Debug.LogError("Object tag is not set!");
            return;
        }

        GameObject foundObject = GameObject.FindGameObjectWithTag(objectTag);

        if (foundObject == null)
        {
            Debug.LogError("Could not find object to monitor!");
            return;
        }
        else
        {
            Debug.Log("pig found");
        }
    }
}
