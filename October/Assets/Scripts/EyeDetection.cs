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
            print("yei");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Ojo")
        {
            cantidadOjos++;
            print(cantidadOjos);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Ojo")
        {
            cantidadOjos--;
            print(cantidadOjos);
        }

    }
}
