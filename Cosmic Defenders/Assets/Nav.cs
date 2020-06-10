using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nav : MonoBehaviour
{
    private float speed = 0.07f;
    private int direction = 1;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bouncer L")
        {
            speed = 0.07f;//Random.Range(0.1f, 0.3f);
            direction = 1;
        }
        if (col.gameObject.tag == "Bouncer R")
        {
            speed = 0.07f;//Random.Range(-0.1f, -0.3f);
            direction = -1;
        }
        if (col.gameObject.tag == "Nav")
        {
            speed = Random.Range(0.07f, 0.15f);
            direction = Random.Range(-1, 2);
            while (direction == 0)
            {
                direction = Random.Range(-1, 2);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<killShip>().respawning)
        {
            transform.position += new Vector3(speed * direction, 0f, 0f);
        }
    }
}
