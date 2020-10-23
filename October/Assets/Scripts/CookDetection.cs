using UnityEngine;
using UnityEngine.UI;

public class CookDetection : MonoBehaviour
{
    bool cociendo;
    float proceso;
    bool listo;
    bool quemar;
    public float tiempo;
    public Text text;
    
    void Awake()
    {
        proceso = 0f;   
    }
    void Update()
    {
     if (cociendo)
        {
            proceso+=Time.deltaTime;
            if (proceso < tiempo)
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
                text.gameObject.SetActive(true);
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
            GameManager.Instance.BackToEntrance();
            print("Lo has hecho!!!!!");
        }
    }
}
