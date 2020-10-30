using UnityEngine;
using UnityEngine.ParticleSystemJobs;

public class RotateCheck : MonoBehaviour
{
    public GameObject checkpoint;
    private bool count;
    private float tiempo;
    public Animator anim;
    public string stateName;

    private bool started;

    // Start is called before the first frame update
    private void Awake()
    {
        count = false;
        tiempo = 0f;
        started = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if(count) 
        {
            tiempo += Time.deltaTime;
            if(tiempo >= 6f) {
                anim.SetBool("isFull", true);
                GameManager.Instance.startTransition();
                count = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Colisiono");
        if(collision.gameObject == checkpoint)
        {
            count = true;

            if(anim != null && !started)
            {
                anim.SetBool("isFilling", true);
                anim.Play(stateName, 0, 0);
                started = true;
            }
            else if(anim != null && started)
            {
                anim.speed = 1;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if(collision.gameObject == checkpoint) 
        {
            count = false;
            anim.speed = 0;
        }
    }
}
