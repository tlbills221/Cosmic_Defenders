using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stingMove : MonoBehaviour
{
    public GameObject bee;
    private int iter = 0;
    // Update is called once per frame
    void Update()
    {
        if (iter > 0 && iter % 60 == 0 && !bee.GetComponent<mouseMove>().bugState)
        {
            transform.position = bee.transform.position + new Vector3(0f, -0.8f, 0f);
            GetComponent<AudioSource>().Play();
        } 
        iter++;
        if (iter > 120)
        {
            iter = 0;
        }
        transform.position += new Vector3(0f, -0.25f, 0f);
    }
}
