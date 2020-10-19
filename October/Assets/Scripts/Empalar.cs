using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empalar : MonoBehaviour
{
    float velCaida;
    public Rigidbody2D rb;
    public Eyes eye;
    bool ready;
    Vector2 speed;
    public Transform positionEye;
    Vector3 up = new Vector3(0, 1, 0);

    void Update()
    {
        speed = rb.velocity;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "punta" && speed.y < 0f)
        {
            print("Pinchado!");
            eye.enabled= false;
            ready = true;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        }
        if (collision.transform.tag == "point" && ready)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            positionEye.position += up;
            GameManager.Instance.pinchados++;
        }
    }
}
