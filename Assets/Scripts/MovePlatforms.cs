using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatforms : MonoBehaviour
{
    private float startposX;
    private float startPosY;
    private bool isBeingHeld = false;
    public BoxCollider2D toggleBox;

    private void Start()
    {
        if (toggleBox == null)
        {
            toggleBox = GetComponent<BoxCollider2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startposX, mousePos.y - startPosY, 0);
            toggleBox.enabled = false;
        }
        else
        {
            toggleBox.enabled = true;
        }
    }
    private void OnMouseDown()
    {

        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);


            startposX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }
       

    }
    private void OnMouseUp()
    {
        isBeingHeld = false;
    }
}
