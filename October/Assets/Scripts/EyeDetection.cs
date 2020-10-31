using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeDetection : MonoBehaviour
{
    int cantidadOjos = 0;
    public string collisionTag;
    public bool canChangeScene;
    public int ojosDentro;
    private float time;
    private bool count;
    public bool eyeBool = false;

    private void Start() {
        time = 0f;
    }

    void Update()
    {
        if (cantidadOjos == ojosDentro)
        {
            Debug.Log("entro");
            count = true;
            if (canChangeScene)
            {
                GameManager.Instance.BackToEntrance();
                Debug.Log("Volviendo...");
            }
            GameManager.Instance.pinchados = 0;   
            cantidadOjos+=10000; // Evitar que se vuelve a llamar startTransition
            print("yei");
        }

        if(eyeBool)
        {
            if(time >= 1f && count){
                GameManager.Instance.startTransition();
                count = false;
            }

            if(count)
            {
                time += Time.deltaTime;
                Debug.Log(time);
            }
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
