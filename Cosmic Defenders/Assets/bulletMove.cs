using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public GameObject ship;
    private int iter = 0;
    // Update is called once per frame
    void Update()
    {
        if (iter > 0 && iter % 240 == 0 && !ship.GetComponent<killShip>().respawning)
        {
            transform.position = ship.transform.position + new Vector3(0f, 1f, 0f);
            GetComponent<AudioSource>().Play();
        }
        iter++;
        if (iter > 240)
        {
            iter = 0;
        }
        transform.position += new Vector3(0f, 0.05f, 0f);
    }
}
