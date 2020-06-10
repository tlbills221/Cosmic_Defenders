using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stingWarp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ship")
        {
            transform.position = new Vector3(-3f, -7.3f, 0f);
        }
    }
}
