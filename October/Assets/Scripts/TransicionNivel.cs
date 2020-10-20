using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransicionNivel : MonoBehaviour
{
    public Transform[] levelCenter;
    public float transitionSpeed;
    private Vector3 targetPos;

    private void Start()
    {
        GameManager.Instance.level = 0;
        GameManager.Instance.startTransition();
    }

    private void FixedUpdate()
    {

        if (GameManager.Instance.changeScene)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                                                    targetPos, 
                                                    transitionSpeed * Time.deltaTime);
            GameManager.Instance.changeScene = (transform.position != targetPos);
        }


    }

    public void MoveToNextPoint()
    {
        Debug.Log("moviendo");
        GameManager.Instance.changeScene = true;
        targetPos = new Vector3(levelCenter[GameManager.Instance.level].position.x, 
                                levelCenter[GameManager.Instance.level].position.y, 
                                transform.position.z);
        if(GameManager.Instance.level < levelCenter.Length-1) GameManager.Instance.level++;
    }    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) GameManager.Instance.startTransition();
    }

    
}
