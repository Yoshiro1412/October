using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDetection : MonoBehaviour
{
    int cantidadOjos = 0;
    void Update()
    {
        if (cantidadOjos == 4)
        {
            GameManager.Instance.pinchados = 0;
            GameManager.Instance.startTransition();
            cantidadOjos+=10000; // Evitar que se vuelve a llamar startTransition
            print("yei");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Ojo") cantidadOjos++;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Ojo") cantidadOjos--;

    }
}
