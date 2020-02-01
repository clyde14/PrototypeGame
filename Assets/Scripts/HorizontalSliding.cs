using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalSliding : MonoBehaviour
{

    public float moveSpeed = 3f;
    public float horizontalDistance = 4f;
    public bool moveRight = false;
    private float initialPos;

    void Start()
    {
        initialPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - initialPos > horizontalDistance)
            moveRight = false;
        if (transform.position.x - initialPos < -horizontalDistance)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);

    }



    void OnCollisionEnter2D(Collision2D col)
    {

        col.transform.parent = this.transform;
    }

    void OnCollisionExit2D(Collision2D col)
    {

        col.transform.parent = null;
    }
}

