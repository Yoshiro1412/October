using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesDetection2 : MonoBehaviour
{
    int cantidadOjos = 0;
    public string collisionTag;
    public bool canChangeScene;
    public int ojosDentro;

    void Update()
    {
        if (cantidadOjos == ojosDentro)
        {
            if (canChangeScene)
            {
                GameManager.Instance.BackToEntrance();
                Debug.Log("Volviendo...");
            }
            GameManager.Instance.startTransition();
            GameManager.Instance.pinchados = 0;   
            cantidadOjos+=10000; // Evitar que se vuelve a llamar startTransition
            print("yei");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == collisionTag) cantidadOjos++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == collisionTag) cantidadOjos--;

    }
}