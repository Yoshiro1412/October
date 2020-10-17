using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private bool cutting;
    private bool cutMade;
    private Renderer render;

    private void Awake()
    {
        cutMade = false;
        cutting = false;
        render = gameObject.GetComponent<Renderer>();
    }

    private void OnMouseOver()
    {
        render.material.color = Color.blue;
    }

    private void OnMouseDown()
    {
        cutting = true;
        cutMade = true;
    }

    private void OnMouseUp()
    {
        cutting = false;
    }

    private void OnMouseExit()
    {
        render.material.color = cutting ? Color.red : Color.green;
        if (cutting)
        {
            Debug.Log("Wrong");
        }
        else if(cutMade)
        {
            Debug.Log("Good");
            cutMade = false;
        }
    }
}
