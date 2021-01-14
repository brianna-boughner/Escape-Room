using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPassword3 : MonoBehaviour
{
    public bool isActive = false;
    public string currentPass = "EAST";
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

            if (GUI.Button(new Rect(5, 35, 100, 100), "O"))
            {
                input = input + "O";
            }

            if (GUI.Button(new Rect(110, 35, 100, 100), "T"))
            {
                input = input + "T";
            }

            if (GUI.Button(new Rect(215, 35, 100, 100), "N"))
            {
                input = input + "N";
            }

            if (GUI.Button(new Rect(5, 140, 100, 100), "R"))
            {
                input = input + "R";
            }

            if (GUI.Button(new Rect(110, 140, 100, 100), "B"))
            {
                input = input + "B";
            }

            if (GUI.Button(new Rect(215, 140, 100, 100), "E"))
            {
                input = input + "E";
            }

            if (GUI.Button(new Rect(5, 245, 100, 100), "S"))
            {
                input = input + "S";
            }

            if (GUI.Button(new Rect(110, 245, 100, 100), "I"))
            {
                input = input + "I";
            }

            if (GUI.Button(new Rect(215, 245, 100, 100), "H"))
            {
                input = input + "H";
            }

            if (GUI.Button(new Rect(110, 350, 100, 100), "A"))
            {
                input = input + "A";
            }

        }
    }
}
