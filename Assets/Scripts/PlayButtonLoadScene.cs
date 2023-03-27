using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonLoadScene : MonoBehaviour
{
    public void LoaddingScene(string sceneName)
    {
        SceneManager.LoadScene("Levels");
    }
}
