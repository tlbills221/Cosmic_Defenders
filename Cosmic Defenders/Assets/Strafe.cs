using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strafe : MonoBehaviour
{
    private float speed = 0.07f;
    public float height = 0.01f;
    private float iter = 0f;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bouncer L")
        {
            speed = 0.07f;//Random.Range(0.1f, 0.3f);
        }
        if (col.gameObject.tag == "Bouncer R")
        {
            speed = -0.07f;//Random.Range(-0.1f, -0.3f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, height, 0f);
        height = 0.05f * Mathf.Sin(iter);
        iter = iter + Mathf.PI /6f;
        if (iter > 2f * Mathf.PI)
        {
            iter = 0f;
        }
    }
}
