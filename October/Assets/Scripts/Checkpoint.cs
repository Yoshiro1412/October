using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject[] checkpoints;
    private int current;

    private void Update()
    {
        if(current >= checkpoints.Length)
        {
            Debug.Log("Listoko");
            current = 0;
        }
    }

    private void Awake()
    {
        current = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(current < checkpoints.Length && collision.gameObject == checkpoints[current])
        {
            current++;
        }
    }

}
