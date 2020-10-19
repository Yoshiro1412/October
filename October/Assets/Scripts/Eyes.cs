using UnityEngine;

public class Eyes : MonoBehaviour
{
    private bool mantener = false;
    private Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mantener == true)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            rigidbody2D.MovePosition(mousePos);
        }
    }
    
    private void OnMouseDown()
    {
        mantener = true;
    }

    private void OnMouseUp()
    {
        mantener = false;
    }

}
