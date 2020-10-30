using UnityEngine;

public class Shaker : MonoBehaviour
{
    public GameObject[] checkpoints;
    private int current;
    private int counter;

    private void Update()
    {
        if(current >= checkpoints.Length)
        {
            current = 0;
            counter++;
            Debug.Log(counter);
        }

        if(counter == 5) 
        {
            counter = 0;
            GameManager.Instance.startTransition();
        }
    }

    private void Awake()
    {
        current = 0;
        counter = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(current < checkpoints.Length && collision.gameObject == checkpoints[current])
        {
            current++;
        }
        
    }

}