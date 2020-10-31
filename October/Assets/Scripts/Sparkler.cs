using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sparkler : MonoBehaviour
{
    public GameObject collisionCup;
    public Animator anim;
    private float time;
    private bool playing;
    public string stateName;

    private void Awake() {
        time = 0f;
        playing = false;
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject == collisionCup)
        {
            if(anim != null)
            {
                anim.SetBool("isPlaying", true);
                anim.Play(stateName, 0, 0);
                playing = true;
            }
        }
    }

    void Update()
    {
        if(playing == true)
        {
            time += Time.deltaTime;
        }

        if(time >= 1.8f)
        {
            GameManager.Instance.BackToEntrance();
        }
    }
}
