using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class RotateCheck : MonoBehaviour
{
    public GameObject checkpoint;
    private bool count;
    private float tiempo;
    public ParticleSystem ps;

    // Start is called before the first frame update
    private void Awake()
    {
        count = false;
        tiempo = 0f;
    }

    // Update is called once per frame
    private void Update()
    {
        if(count) 
        {
            ps.Play();
            Debug.Log(tiempo);
            tiempo += Time.deltaTime;
            if(tiempo >= 6f) {
                GameManager.Instance.startTransition();
                count = false;
            }
        } 
        else
        {
            ps.Clear();
            ps.Pause();
            tiempo = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Colisiono");
        if(collision.gameObject == checkpoint)
        {
            count = true;
            Debug.Log("Entro al checkpoint");
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject == checkpoint) 
        {
            count = false;
        }
    }
}
