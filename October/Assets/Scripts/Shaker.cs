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
            Debug.Log(counter);
            current = 0;
            counter++;
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