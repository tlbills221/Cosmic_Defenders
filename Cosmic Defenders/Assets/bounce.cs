using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    private float height = 0.1f;
    private float iter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, height, 0f);
        height = 0.05f * Mathf.Sin(iter);
        iter = iter + Mathf.PI / 6f;
        if (iter > 2f * Mathf.PI)
        {
            iter = 0f;
        }
    }
}
