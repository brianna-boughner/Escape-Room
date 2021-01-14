using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownButton : MonoBehaviour
{
    public GameObject LastDoor;
    private void OnMouseDown()
    {
        LastDoor = GameObject.Find("LastDoor");
        LastDoor.GetComponent<FinalDoor>().TempList.Add(3);
        StartCoroutine(ButtonPress());
    }
    private IEnumerator ButtonPress()
    {
        transform.Translate(0f, -0.02f, 0f);
        yield return new WaitForSeconds(0.2f);
        transform.Translate(0f, 0.02f, 0f);
    }
}
