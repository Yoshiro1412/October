using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookDetection : MonoBehaviour
{
    bool cociendo;
    int proceso;
    bool listo;
    bool quemar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (cociendo)
        {
            proceso++;
            if (proceso < 1000)
            {
                print(proceso);
            }
            else if (proceso > 1500)
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
