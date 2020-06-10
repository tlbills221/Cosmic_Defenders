using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBug : MonoBehaviour
{
    public AudioClip hit;
    public GameObject queen;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ship")
        {
            queen.GetComponent<killQueen>().bugCount--;
            GetComponent<AudioSource>().PlayOneShot(hit, 0.5f);
            Destroy(gameObject);
        }
    }
}
