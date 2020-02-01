using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSliding : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float verticalDistance = 4f;
    public bool moveUp = false;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > verticalDistance)
            moveUp = false;
        if (transform.position.y < -verticalDistance)
            moveUp = true;

        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);

    }

}
