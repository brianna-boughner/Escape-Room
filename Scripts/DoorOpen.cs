using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    private Animator anim;
    int boxesTouching = 0;
    bool isDoorOpen = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    { 
            boxesTouching = 0;
            //check if red box is touching red platform
            GameObject redBox = GameObject.Find("Red Platform");
            ColliderTouch redTouch = redBox.GetComponent<ColliderTouch>();
            if (redTouch.isTouching) boxesTouching++;

            //check if yellow box is touching yellow platform
            GameObject yellowBox = GameObject.Find("Yellow Platform");
            YellowTouch yellowTouch = yellowBox.GetComponent<YellowTouch>();
            if (yellowTouch.isTouching) boxesTouching++;

            //check if blue box is touching blue platform

            GameObject blueBox = GameObject.Find("Blue Platform");
            BlueTouch blueTouch = blueBox.GetComponent<BlueTouch>();
            if (blueTouch.isTouching) boxesTouching++;

            //open door if all boxes are in the correct spot
             if (boxesTouching == 3 && isDoorOpen == false)
             {
                 if (null != anim)
                  {
                         isDoorOpen = true;
                         anim.Play("door_2_open");
                  }
               }
        //play only the door opened animation after the door open animation has played
        else if (boxesTouching == 3 && isDoorOpen == true)
        {
            anim.Play("door_2_opened");
        }

    }
}
