using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traslation : MonoBehaviour
{
    private bool getting = false;
    private float startx;
    private float starty;
    void Update()
    {
        if (getting == true)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x -startx, mousePos.y-starty, 0);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startx = mousePos.x - this.transform.localPosition.x;
            starty = mousePos.y - this.transform.localPosition.y;

            getting = true;
        }
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0)) getting = false;
    }
}