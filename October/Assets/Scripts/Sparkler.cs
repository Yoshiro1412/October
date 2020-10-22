using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparkler : MonoBehaviour
{
    public GameObject collisionCup;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject == collisionCup) 
        {
            print("Le pusiste chispa");
        }
    }
}
