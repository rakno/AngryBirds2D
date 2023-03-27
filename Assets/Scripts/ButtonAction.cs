using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public GameObject Level_ID;
    public void OnButtonClick()
    {
        PreFabSelection.selectedPrefab = Level_ID;
        SceneManager.LoadScene("GameScene_1");
    }
}
