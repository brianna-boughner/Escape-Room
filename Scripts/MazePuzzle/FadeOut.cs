using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public bool Triggered = false;

    private void OnCollisionEnter(Collision collision)
    {
        Physics.IgnoreCollision(GameObject.Find("Player").GetComponent<Collider>(), GetComponent<Collider>());

        if (collision.gameObject.name == "Player")
        {
            Triggered = true;
        }
    }
}
