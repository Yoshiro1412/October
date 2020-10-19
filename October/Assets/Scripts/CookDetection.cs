using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookDetection : MonoBehaviour
{
    bool cociendo;
    float proceso;
    bool listo;
    bool quemar;
    void Awake()
    {
        proceso = 0f;   
    }
    void Update()
    {
     if (cociendo)
        {
            proceso+=Time.deltaTime;
            if (proceso < 15f)
            {
                print(proceso);
            }
            else if (proceso > 20f)
            {
                print("Se quemó wey D:");
                listo = false;
                quemar = true;
            }
            else
            {
                print("Ya ta wey");
                listo = true;
            }
        }   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        cociendo =true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        cociendo = false;
        if (quemar)
        {
            print("quemado D:");
        }
        if (listo)
        {
            print("Lo has hecho!!!!!");
        }
    }
}
