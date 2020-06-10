using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseMove : MonoBehaviour
{
    private Vector2 targetPosition;
    public Vector2 velDir = new Vector2(0f, 0f);
    public bool bugState = true;
    public bool isClick = false;
    public AudioClip select;
    public Vector2 defaultPos /*= new Vector2(3f, 4f)*/;
    private void Awake()
    {
        targetPosition = defaultPos; //move the bug to its default
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1) && bugState && isClick)
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //point the mouse was at on click
            velDir = targetPosition - new Vector2(transform.position.x, transform.position.y); //vector btwn mouse and bug
            bugState = false;
            isClick = false;
        }
        transform.position += new Vector3(velDir.x / 60, velDir.y / 60, 0f);

        //transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5);
    }

    private void OnMouseDown()
    {
        isClick = true;
        GetComponent<AudioSource>().Play();
    }
}
