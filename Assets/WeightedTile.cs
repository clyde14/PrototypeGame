using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightedTile : MonoBehaviour
{

    private float initialPos;
    public float moveSpeed;
    public float force;
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
            Debug.Log(rise);
            //transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
            rb.AddForce(transform.up * force);
        }
        if (transform.position.y >= initialPos)
        {
            rb.Sleep();
        }

    }

    void OnCollisionStay2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("entered");
            Debug.Log(rise);
           
            rise = false;
            rb.isKinematic = false;
        }
        
    }

    void OnCollisionExit2D(Collision2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("exited");
            Debug.Log(rise);
            
            rise = true;
        }
    }
}

