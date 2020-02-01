using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightedTile : MonoBehaviour
{

    private float initialPos;
    public float moveSpeed = 2f;
    private bool rise = true;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (rise && transform.position.y < initialPos) {
            Debug.Log("rising");
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        }
    }

    void OnCollisionStay2D()
    {
        Debug.Log("entered");
        rise = false;
        rb.isKinematic = false;

    }

    void OnCollisonExit2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("exited");
            rise = true;
            rb.isKinematic = true;
        }
    }


}
