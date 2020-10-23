using UnityEngine;

public class Eyes : MonoBehaviour
{
    private bool getting = false;
    private Rigidbody2D body;
    private const int force = 17;

    void Start(){
        body =GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (getting == true)
        {
            Vector2 eye;
            eye =new Vector2(transform.position.x, transform.position.y);

            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector2 mov;
            mov = (mousePos - eye)*force;

            body.AddForce(mov);
        }
    }

    private void OnMouseDown(){
        getting = true;
    }

    private void OnMouseUp(){
        if (Input.GetMouseButtonUp(0)) getting = false;
    }

}
