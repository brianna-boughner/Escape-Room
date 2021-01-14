using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTouch : MonoBehaviour
{

    public bool isTouching;
    //change to true if the box is placed on the platform
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Yellow Box") isTouching = true;
    }
    //change back to false if the box is taken off of the platform
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Yellow Box") isTouching = false;
    }
}
