using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourDoorOpen : MonoBehaviour
{
    private Animator anim;
    bool animPlayed = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        GameObject ColoursConsole = GameObject.Find("ColoursConsole");
        EnterPassword enterPassword = ColoursConsole.GetComponent<EnterPassword>();

        if (enterPassword.doorOpened == true && animPlayed == false)
        {
            animPlayed = true;
            anim.Play("door_2_open");
        }
        else if (animPlayed == true) anim.Play("door_2_opened");
    }
}
