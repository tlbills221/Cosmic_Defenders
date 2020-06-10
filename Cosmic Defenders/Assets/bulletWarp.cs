using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletWarp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bug")
        {
            transform.position = new Vector3(2f, 7.3f, 0f);
        }
    }
}
