using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorseDoorOpen : MonoBehaviour
{
    private Animator anim;
    bool animPlayed = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        GameObject MorseConsole = GameObject.Find("MorseConsole");
        EnterPassword3 enterPassword = MorseConsole.GetComponent<EnterPassword3>();

        if (enterPassword.doorOpened == true && animPlayed == false)
        {
            animPlayed = true;
            anim.Play("door_2_open");
        }
        else if (animPlayed == true) anim.Play("door_2_opened");
    }
}
