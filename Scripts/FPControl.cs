using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//controlling the player in first person
// note: rigidbody component is added to the player, so unity will automatically apply physics (drag/gravity) to the player as they move

public class FPControl : MonoBehaviour
{
    //This part of the code is for movement with arrowkeys

    //variables
    public float speed = 10.0f;
    public float verticalMovement;
    public float horizontalMovement;

    // initialization
    void Start()
    {
        // this turns the cursor off (visual aspect)
        Cursor.lockState = CursorLockMode.Locked;
    }

    //called once per frame (update)
    void Update()
    {
        //Input.GetAxis() - this retrieves the user input 
        verticalMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        horizontalMovement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //moves the player based on input
        transform.Translate(horizontalMovement, 0, verticalMovement);

        if (Input.GetKeyDown("space"))
        {
            // turn on the cursor
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
