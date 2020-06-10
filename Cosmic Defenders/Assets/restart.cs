using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    private float iter = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && iter >= 0.120f)
        {
            SceneManager.LoadScene("Title");
        }
        iter = iter + 0.001f;
    }
}
