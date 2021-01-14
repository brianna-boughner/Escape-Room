using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorseCode : MonoBehaviour
{
    int x = 0;
    Light morseLight;
    
    private void Start()
    {
        morseLight = GetComponentInChildren<Light>();
        StartCoroutine("ControlLight");
    }
    private IEnumerator ControlLight()
    {
        while (x == 0)
        {
            morseLight.enabled = false;
            yield return new WaitForSeconds(2f);

            //E: .

            morseLight.enabled = true;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = false;
            yield return new WaitForSeconds(1.2f);

            //A: .-

            morseLight.enabled = true;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = false;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = true;
            yield return new WaitForSeconds(1.0f);
            morseLight.enabled = false;
            yield return new WaitForSeconds(1.2f);

            //S: ...

            morseLight.enabled = true;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = false;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = true;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = false;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = true;
            yield return new WaitForSeconds(0.3f);
            morseLight.enabled = false;
            yield return new WaitForSeconds(1.2f);

            //T: -

            morseLight.enabled = true;
            yield return new WaitForSeconds(1.0f);
            morseLight.enabled = false;
        }
    }

}
