using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPos : MonoBehaviour
{
    //Vector2 v = mouseMove.velDir;
    //defaultPos dp = mouseMove.defaultPos;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D col)
    {
       Debug.Log("Collided!");
       if (col.gameObject.tag == "Wall")
        {
            Debug.Log("Collided with wall!");
            GetComponent<mouseMove>().velDir = new Vector2(0f, 0f);
            transform.position = GetComponent<mouseMove>().defaultPos;
            GetComponent<mouseMove>().bugState = true;
        }
    }
}
