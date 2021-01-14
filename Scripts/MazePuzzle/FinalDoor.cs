using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FinalDoor : MonoBehaviour
{
    //three different pathways
    List<int> PathOne = new List<int>() { 1, 2, 1, 2, 1, 4, 1, 4, 1, 4, 1 };
    List<int> PathTwo = new List<int>() { 1, 2, 1, 1, 4, 1, 4, 1, 4, 1, 2, 3, 2, 1, 2, 1, 4, 1, 4, 1};
    List<int> PathThree = new List<int>() { 1, 2, 1, 1, 1, 4, 1, 1, 2, 1, 4 , 1, 4, 1};

    int counterEqual1 = 0;
    int counterEqual2 = 0;
    int counterEqual3 = 0;

    int counterTotal = 0;

    public bool doorOpen = false; 

    //public list 
    public List<int> TempList = new List<int>();

    private Animator anim;
    bool animPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //reset counters
        counterEqual1 = 0;
        counterEqual2 = 0;
        counterEqual3 = 0;

        counterTotal = 0;
        //run if the door is still closed
        if (doorOpen == false)
        {
            foreach (int i in TempList)
            {
                if (counterTotal < 10)
                {
                    if (i == PathOne[counterTotal])
                    {
                        counterEqual1++; //if the two spots in the lists are the same, increse counter 
                    }
                }
                if (counterTotal < 19)
                {
                    if (i == PathTwo[counterTotal])
                    {

                        counterEqual2++;
                    }
                }
                if (counterTotal < 13)
                {
                    if (i == PathOne[counterTotal])
                    {
                        counterEqual3++;
                    }
                }
                counterTotal++;
            }
        }
        if (counterEqual1 == 10) doorOpen = true;
        else if (counterEqual2 == 19) doorOpen = true;
        else if (counterEqual3 == 13) doorOpen = true;

        if (doorOpen == true && animPlayed == false) //play animation if one of the lists is equal 
        {
            animPlayed = true;
            anim.Play("door_2_open");
        }
        else if (animPlayed == true) anim.Play("door_2_opened");
    }
}
