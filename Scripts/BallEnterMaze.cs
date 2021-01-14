using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEnterMaze : MonoBehaviour
{
    public bool mazeActive = false;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject ball = GameObject.Find("aMazeBall");
        if (collision.gameObject.name == "aMazeBall") Destroy(ball);
        mazeActive = true;
    }
}
