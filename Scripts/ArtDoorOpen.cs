using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtDoorOpen : MonoBehaviour
{
    private Animator anim;
    bool animPlayed = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        GameObject ArtConsole = GameObject.Find("ArtConsole");
        EnterPassword2 enterPassword = ArtConsole.GetComponent<EnterPassword2>();

        if (enterPassword.doorOpened == true && animPlayed == false)
        {
            animPlayed = true;
            anim.Play("door_2_open");
        }
        else if (animPlayed == true) anim.Play("door_2_opened");
    }
}
