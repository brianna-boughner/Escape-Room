using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    [SerializeField] //forcing unity to serialize the variable
    public float sensitivity = 5.0f;
    [SerializeField]
    public float smoothing = 2.0f;
    ////get the movement of the mouse
    private Vector2 mouseLook;
    ////smooth movement
    private Vector2 smoothV;
    //sensitivity
    public float sensitivityX = 15F;
    public float sensitivityY = 15F;
    //set max/min values for camera y-axis 
    public float minimumY = -90F;
    public float maximumY = 90F;
    //player is the capsule object 
    public GameObject player;
    float rotationY = 0F;

    //Use this for initialization

    void Start()
    {
       player = this.transform.parent.gameObject;
    }

    float rotationX = 0f;
    void Update()
    {
        if (Time.timeScale != 0f)
        {
            //retrieve input from mouse (user)
            var mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), -(Input.GetAxisRaw("Mouse Y")));
            mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));

            //incrementally add to the mouse look pos
            mouseLook += smoothV;
            smoothV.x = Mathf.Lerp(smoothV.x, mouseDelta.x, 1f / smoothing);

            //input for x axis 
            rotationX += Input.GetAxis("Mouse X") * sensitivityX;
            //input for y axis
            rotationY += Input.GetAxis("Mouse Y") * sensitivityY;

            //clamp - restricts movement of the y axis
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            //moves the player in the direction of the camera 
            player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
            transform.localRotation = Quaternion.AngleAxis(-rotationY, Vector3.right);
        }
    }

}




