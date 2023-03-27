using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinPage : MonoBehaviour
{
    private AudioClip winClip;
    public AudioSource winSource;
    private void Start()
    {
        winSource.Play();
    }
    public void LoadingLevels(string sceneName)
    {
        SceneManager.LoadScene("Levels");
    }
    
    public void LoadingStart(string sceneName)
    {
        SceneManager.LoadScene("startPage");
    }
}
