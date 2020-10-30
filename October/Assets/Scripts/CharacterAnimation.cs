using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;
    public string stateName;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        //anim.speed = 10;
        if(anim != null)
        {
            anim.Play(stateName, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.5)
        {
            anim.SetBool("isFinished", true);
        }
    }
}
