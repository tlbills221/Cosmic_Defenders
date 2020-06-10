using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beefyBug : MonoBehaviour
{
    private int bugStatus = 0;
    public GameObject queen;
    public AudioClip hit;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ship")
        {
            bugStatus++;
        }
    }

    void Update()
    {
        if (bugStatus == 1)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("alien4");
        }
        if (bugStatus == 2)
        {
            GetComponent<AudioSource>().PlayOneShot(hit, 0.5f);
            queen.GetComponent<killQueen>().bugCount--;
            Destroy(gameObject);
           
        }
    }
}
