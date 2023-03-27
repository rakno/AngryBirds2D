using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFabSelection : MonoBehaviour
{
    public static GameObject selectedPrefab;
    public GameObject levelPositon;
    GameObject newGameObject;



    private void Start()
    {
        Debug.Log(levelPositon.transform.position);
        Debug.Log("level loaded");
       
        newGameObject = Instantiate(selectedPrefab,levelPositon.transform);
        newGameObject.transform.position = levelPositon.transform.position;

    }

   
}
