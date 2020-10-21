using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apretar : MonoBehaviour
{
    public float scaleSpeed;
    private bool onHeart;
    private bool holding;
    public float minScale;

    private void Awake()
    {
        onHeart = false;
        holding = false;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && onHeart)
        {
            holding = true;
        }
        else
        {
            holding = false;
        }

        if(transform.localScale.x < minScale)
        {
            Debug.Log("Exploto!!!");
        }
    }

    private void FixedUpdate()
    {
        if (holding)
        {
            transform.localScale = new Vector3(transform.localScale.x - scaleSpeed * Time.deltaTime, 1, 1);
        }else if(transform.localScale.x <= 1)
        {
            transform.localScale = new Vector3(transform.localScale.x + scaleSpeed * Time.deltaTime, 1, 1);
        }
    }

    private void OnMouseOver()
    {
        onHeart = true;
    }

    private void OnMouseExit()
    {
        onHeart = false;
    }
}
