using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public GameObject LastDoor;

    private void OnMouseDown()
    {
        LastDoor = GameObject.Find("LastDoor");
        LastDoor.GetComponent<FinalDoor>().TempList.Clear();
        StartCoroutine(ButtonPress());
    }
    private IEnumerator ButtonPress()
    {
        transform.Translate(0f, -0.02f, 0f);
        yield return new WaitForSeconds(0.2f);
        transform.Translate(0f, 0.02f, 0f);
    }
}
