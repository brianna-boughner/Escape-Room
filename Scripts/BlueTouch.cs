using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTouch : MonoBehaviour
{

    public bool isTouching;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Blue Box") isTouching = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Blue Box") isTouching = false;
    }
}
