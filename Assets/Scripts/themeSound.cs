using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class themeSound : MonoBehaviour
{
    private AudioClip themeSong;
    public AudioSource themesongSource;


    private void Start()
    {
        themesongSource.Play();
    }
}
