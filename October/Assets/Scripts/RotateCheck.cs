using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCheck : MonoBehaviour
{
    public GameObject checkpoint;
    private bool count;
    private float tiempo;

    // Start is called before the first frame update
    private void Awake()
    {
        count = false;
        tiempo = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        if(count) 
        {
            Debug.Log(tiempo);
            tiempo += Time.deltaTime;
            if(tiempo >= 10f) {
                //Termina el juego
                Debug.Log("Termino");
                count = false;
            }
        } 
        else
        {
            tiempo = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Colisiono");
        if(collision.gameObject == checkpoint)
        {
            count = true;
            Debug.Log("Entro al checkpoint");
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject == checkpoint) 
        {
            count = false;
        }
    }
}
