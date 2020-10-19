using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionNivel : MonoBehaviour
{
    public Transform[] levelCenter;
    private int level;
    public float transitionSpeed;
    private bool hasToMove;
    private Vector3 targetPos;

    private void Awake()
    {
        level = 0;
        MoveToNextPoint();
    }

    private void FixedUpdate()
    {

        if (hasToMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, transitionSpeed * Time.deltaTime);
            hasToMove = (transform.position != targetPos);
        }


    }

    public void MoveToNextPoint()
    {
        targetPos = new Vector3(levelCenter[level].position.x, levelCenter[level].position.y, transform.position.z);
        hasToMove = true;
        if(level < levelCenter.Length-1) level++;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) MoveToNextPoint();
    }

    
}
