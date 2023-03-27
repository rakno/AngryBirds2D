using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPageScroll : MonoBehaviour
{
    public float scrollSpeed = 0.1f;

    private RawImage image;

    private void Start()
    {
        image = GetComponent<RawImage>();
    }

    private void Update()
    {
        float offset = Time.time * scrollSpeed;
        image.uvRect = new Rect(offset, 0, 1, 1);
    }
}
