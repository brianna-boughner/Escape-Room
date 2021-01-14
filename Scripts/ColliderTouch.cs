using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTouch : MonoBehaviour
{
    public bool isTouching;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Red Box") isTouching = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Red Box") isTouching = false;
    }
}



