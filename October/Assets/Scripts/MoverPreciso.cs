using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPreciso : MonoBehaviour
{

    private Rigidbody2D rb;
    private bool holding;

    private void Awake()
    {
        holding = false;
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(holding) rb.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }

    private void OnMouseDown()
    {
        holding = true;
    }

    private void OnMouseUp()
    {
        holding = false;
    }
}
