using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    private Animator anim;
    public GameObject hallwayCollider;
    public bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        hallwayCollider = GameObject.Find("TriggerEnd");
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hallwayCollider.GetComponent<FadeOut>().Triggered == true)
        {
            AnimationPlay();
        }
    }
    public void AnimationPlay()
    {
        
        if(check==false)anim.Play("Fade_in");
        check = true;
    }
}
