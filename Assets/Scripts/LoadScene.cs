using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoaddingScene(string sceneName)
    {
        SceneManager.LoadScene("GameScene_1");
    }
}
