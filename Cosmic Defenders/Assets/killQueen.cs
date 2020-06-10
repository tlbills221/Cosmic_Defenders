using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killQueen : MonoBehaviour
{
    public int bugCount = 4;
    public GameObject ship;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ship")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lose");
        }
    }

    void Update()
    {
        if (bugCount == 0 && ship.GetComponent<killShip>().shipStatus != 4)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Lose");
        }
    }
}
