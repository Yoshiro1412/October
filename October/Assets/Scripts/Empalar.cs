using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empalar : MonoBehaviour
{
    float velCaida = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "punta" && velCaida <20)
        {
            print("Pinchado!");
            gameObject.GetComponent<Eyes>().enabled = false;

        }
    }
}
