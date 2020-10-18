using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    private bool mantener = false;
    private Rigidbody2D cuerpo;
    // Start is called before the first frame update
    void Start()
    {
        cuerpo=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mantener == true)
        {
            Vector2 eye;
            eye =new  Vector2(transform.position.x, transform.position.y);

            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector2 mov;
            mov = (mousePos - eye)*17;

            cuerpo.AddForce(mov);
        }
    }
    void Update()
    {
        if (mantener == true)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            //this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0)) {
            mantener = true;
        }
    }

    private void OnMouseUp()
    {
        if (Input.GetMouseButtonUp(0))
        {
            mantener = false;
        }
    }

}
