using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killShip : MonoBehaviour
{
    public int shipStatus = 0;
    //private int iter = 0;
    public bool respawning = false;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bug" && !respawning)
        {
            shipStatus++;
            GetComponent<AudioSource>().Play();
            //check ship status after increment
            if (shipStatus == 1)
            {
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Ship2");
                transform.position = new Vector3(0f, -25f, 0f);
                respawning = true;
            }
            else if (shipStatus == 2)
            {
                GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Ship3");
                transform.position = new Vector3(0f, -25f, 0f);
                respawning = true;
            }
            else if (shipStatus == 3)
            {
                shipStatus++;
                Destroy(gameObject);
                SceneManager.LoadScene("Win");
            }
        }
    }

    void Update()
    {
        if (respawning) //respawn
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0f, -3.5f, 0f), 0.1f);
        }
        if (transform.position == new Vector3(0f, -3.5f, 0f)) //end respawn when it gets there
        {
            respawning = false;
        }
    }
}
