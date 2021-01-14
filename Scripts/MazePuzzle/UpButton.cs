using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour
{
    public GameObject LastDoor;
    private void OnMouseDown()
    {
        LastDoor = GameObject.Find("LastDoor");
        LastDoor.GetComponent<FinalDoor>().TempList.Add(1);
        StartCoroutine(UpButtonPress());
    }
    private IEnumerator UpButtonPress()
    {    
        transform.Translate(0f, -0.02f, 0f);
        yield return new WaitForSeconds(0.2f);
        transform.Translate(0f, 0.02f, 0f);        
    }
}
