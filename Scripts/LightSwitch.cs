using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    Light RedSpotLight;
    Light YellowSpotLight;
    Light GreenSpotLight;
    Light BlueSpotLight;

    Light lightStick1;
    Light lightStick2;
    Light lightStick3;
    Light lightStick4;

    Light CeilingLight1;
    Light CeilingLight2;

    public bool LightsOn;

    public bool check = false;

    private void Start()
    {
        LightsOn = true;
        //turn these lights on when the button is pressed
        GameObject RedLight = GameObject.Find("RedSpotLight");
        GameObject YellowLight = GameObject.Find("YellowSpotLight");
        GameObject GreenLight = GameObject.Find("GreenSpotLight");
        GameObject BlueLight = GameObject.Find("BlueSpotLight");

        //turn these lights off when the button is pressed
        GameObject LightStick1 = GameObject.Find("LightStick1");
        GameObject LightStick2 = GameObject.Find("LightStick2");
        GameObject LightStick3 = GameObject.Find("LightStick3");
        GameObject LightStick4 = GameObject.Find("LightStick4");

        GameObject Ceiling1 = GameObject.Find("CeilingLight1");
        GameObject Ceiling2 = GameObject.Find("CeilingLight2");

        RedSpotLight = RedLight.GetComponent<Light>();
        YellowSpotLight = YellowLight.GetComponent<Light>();
        GreenSpotLight = GreenLight.GetComponent<Light>();
        BlueSpotLight = BlueLight.GetComponent<Light>();

        lightStick1 = LightStick1.GetComponentInChildren<Light>();
        lightStick2 = LightStick2.GetComponentInChildren<Light>();
        lightStick3 = LightStick3.GetComponentInChildren<Light>();
        lightStick4 = LightStick4.GetComponentInChildren<Light>();

        CeilingLight1 = Ceiling1.GetComponentInChildren<Light>();
        CeilingLight2 = Ceiling2.GetComponentInChildren<Light>();

        //turn off spotlights 

        RedSpotLight.enabled = false;
        YellowSpotLight.enabled = false;
        GreenSpotLight.enabled = false;
        BlueSpotLight.enabled = false;

        StartCoroutine("ButtonPress");
    }
    private void OnMouseDown()
    {
        ButtonPress();
        if (LightsOn == true)
        {
            RedSpotLight.enabled = true;
            YellowSpotLight.enabled = true;
            GreenSpotLight.enabled = true;
            BlueSpotLight.enabled = true;

            lightStick1.enabled = false;
            lightStick2.enabled = false;
            lightStick3.enabled = false;
            lightStick4.enabled = false;

            CeilingLight1.enabled = false;
            CeilingLight2.enabled = false;
            LightsOn = false;
        }
        else
        {
            RedSpotLight.enabled = false;
            YellowSpotLight.enabled = false;
            GreenSpotLight.enabled = false;
            BlueSpotLight.enabled = false;

            lightStick1.enabled = true;
            lightStick2.enabled = true;
            lightStick3.enabled = true;
            lightStick4.enabled = true;

            CeilingLight1.enabled = true;
            CeilingLight2.enabled = true;
            LightsOn = true;
        }
        StartCoroutine(ButtonPress());
    }

    private IEnumerator ButtonPress()
    {
        check = true;
            transform.Translate(0f, 0.03f, 0f);
            yield return new WaitForSeconds(0.2f);
            transform.Translate(0f, -0.03f, 0f);
    }
   
}
