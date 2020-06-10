using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    //scroll main texture based on time

    float scrollSpeed = .50f;
    float offset;
    float rotate;

    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10.0f;
        GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(offset, 0));

    }
}