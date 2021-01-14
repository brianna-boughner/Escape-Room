using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPassword : MonoBehaviour
{
    public bool isActive = false;
    public string currentPass = "35967";
    public string input;
    public bool doorOpened;
    public bool keypadScreen;


    private void Update()
    {
        //if escape is pressed, the keypad closes
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Cursor.lockState = CursorLockMode.Locked;
            if (isActive)
            {
                //put game back to normal
                isActive = false;
                keypadScreen = false;
                input = null;
                Time.timeScale = 1f;
            }
        }
        if (input == currentPass)
        {
            doorOpened = true;
        }
    }

    private void OnMouseDown()
    {
        if (!isActive)
        {
            isActive = true;
            Time.timeScale = 0f; //pauses game
            Cursor.lockState = CursorLockMode.None; //frees the cursor
        }
    }
    private void OnGUI() //create keypad
    {
        if (isActive)
        {
          
            GUI.Box(new Rect(0, 0, 320, 455), "");
            GUI.Box(new Rect(5, 5, 310, 25), input);

            if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
            {
                input = input + "1";
            }

            if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
            {
                input = input + "2";
            }

            if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
            {
                input = input + "3";
            }

            if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
            {
                input = input + "4";
            }

            if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
            {
                input = input + "5";
            }

            if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
            {
                input = input + "6";
            }

            if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
            {
                input = input + "7";
            }

            if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
            {
                input = input + "8";
            }

            if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
            {
                input = input + "9";
            }

            if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
            {
                input = input + "0";
            }

        }
    }
}
