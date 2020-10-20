using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private bool cutting;
    private bool cutMade;
    private bool onLine;
    ///private Renderer render;
    private Vector2 startPoint;
    private Vector2 endPoint;

    private void Awake()
    {
        cutMade = false;
        cutting = false;
        //render = gameObject.GetComponent<Renderer>();
    }

    private void OnMouseOver()
    {
        onLine = true;
        //render.material.color = Color.blue;
    }

    private void OnMouseDown()
    {
        startPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cutting = true;
        cutMade = true;
    }

    private void OnMouseUp()
    {
        endPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (cutting && onLine) {
            Debug.Log("Buena");
            // 10 de size = 3 de maginitud
            Vector2 diff = endPoint - startPoint;
            Debug.Log(diff.magnitude);
        }
        cutting = false;
    }

    private void OnMouseExit()
    {
        
        onLine = false;
        //render.material.color = cutting ? Color.red : Color.green;
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
