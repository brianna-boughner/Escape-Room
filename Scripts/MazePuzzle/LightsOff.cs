using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{
    Light Light1;
    Light Light2;
    Light Light3;
    Light Light4;

    public bool LightsOn;


    private void Start()
    {
        LightsOn = true;
        //turn these lights on when the button is pressed
        GameObject Ceiling1 = GameObject.Find("CeilingBoi1");
        GameObject Ceiling2 = GameObject.Find("CeilingBoi2");
        GameObject Ceiling3 = GameObject.Find("CeilingBoi3");
        GameObject Ceiling4 = GameObject.Find("CeilingBoi4");

        Light1 = Ceiling1.GetComponentInChildren<Light>();
        Light2 = Ceiling2.GetComponentInChildren<Light>();
        Light3 = Ceiling3.GetComponentInChildren<Light>();
        Light4 = Ceiling4.GetComponentInChildren<Light>();
    }
    private void OnMouseDown()
    {
        ButtonPress();
        if (LightsOn == true)
        {
            Light1.enabled = false;
            Light2.enabled = false;
            Light3.enabled = false;
            Light4.enabled = false;
            LightsOn = false;
        }
        else
        {
            Light1.enabled = true;
            Light2.enabled = true;
            Light3.enabled = true;
            Light4.enabled = true;
            LightsOn = true;
        }
    }
    private IEnumerator ButtonPress()
    {
        transform.Translate(0f, -0.03f, 0f);
        yield return new WaitForSeconds(0.2f);
        transform.Translate(0f, 0.03f, 0f);
    }
}
