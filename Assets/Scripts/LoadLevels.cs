using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadLevels : MonoBehaviour
{
    public GameObject levelButton;
    public GameObject ButtonParent;

    private AudioClip Levels;
    public AudioSource LevelSource;
    void Start()
    {
        LevelSource.Play();
        Object[] prefabs = Resources.LoadAll("Level_Prefab", typeof(GameObject));
        int i = 1;
        foreach (Object obj in prefabs)
        {
            
           
            GameObject newLevelButton = Instantiate(levelButton, ButtonParent.transform);
            Text LevelNumber = newLevelButton.GetComponentInChildren<Text>();
            LevelNumber.text = i.ToString();
            GameObject prefab = (GameObject)obj;
            newLevelButton.GetComponent<ButtonAction>().Level_ID = prefab;
            i++;
            
        }

    }
}
