using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Destination;
 
    void OnMouseDown()
    {
        //this turns the gravity off when mouse button is pressed and brings it to the 'hand' (picks up the object) 
        if (GetComponent<Rigidbody>().useGravity == true)
        {
            
            GetComponent<Rigidbody>().useGravity = false;

            //turn off collider between player and object
            Physics.IgnoreCollision(GameObject.Find("Player").GetComponent<Collider>(), GetComponent<Collider>());
            
            //added this to freeze the movement of the object after it's been picked up
            GetComponent<Rigidbody>().freezeRotation = true; 
            //turn kinematics on
            this.GetComponent<Rigidbody>().isKinematic = true;

            this.transform.position = Destination.position;
            this.transform.parent = GameObject.Find("Hand").transform;

        
        }
        //if gravity is already off, the mouse click will turn it back on again (drop the object)
        else
        {
            this.transform.parent = null;
            //turn collision back on
            Physics.IgnoreCollision(GameObject.Find("Player").GetComponent<Collider>(), GetComponent<Collider>(), false);
            //turn kinematics off
            this.GetComponent<Rigidbody>().isKinematic = false;
            //turns off freeze rotation
            GetComponent<Rigidbody>().freezeRotation = false;
            GetComponent<Rigidbody>().useGravity = true;
        }
     
    }
  
}
