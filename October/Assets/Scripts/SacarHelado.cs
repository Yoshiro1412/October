using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SacarHelado : MonoBehaviour
{
    private bool agarrando;
    public GameObject startPoint;
    public GameObject endPoint;
    private bool tomarHelado;
    private bool soltarHelado;
    public GameObject Helado;
    public GameObject bolita;
    private GameObject currentBall;
    public Transform posBola;

    private void OnMouseUp()
    {
        DetachChild();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == startPoint.name)
        {
            tomarHelado = true;
            if(currentBall == null) currentBall = Instantiate(bolita, posBola);
        }
        if(collision.gameObject.name == endPoint.name && tomarHelado)
        {
            soltarHelado = true;
            tomarHelado = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name == Helado.name)
        {
            if (!soltarHelado)
            {
                //Debug.Log("se cayo");
                DetachChild();
            }
            else
            {
                Debug.Log("Sueltalo");
            }
            soltarHelado = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) DetachChild();
    }

    private void DetachChild()
    {
        if(currentBall != null)
        {
            currentBall.transform.parent = null;
            currentBall.transform.position = posBola.position;
            currentBall.transform.localScale = Vector3.one;
            currentBall.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        }
        currentBall = null;
    }
}
