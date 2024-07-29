using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCount : MonoBehaviour
{
    public int Count = 0;
    public GameObject analyzingWindow, finalWindow, option1, option2, option3, option4, option5;

    public void OnClickPlusOne()
    {
        Count += 1;
        Debug.Log("Count = " + Count);
    }

    public void OnClickPlusTwo()
    {
        Count += 2;
        Debug.Log("Count = " + Count);
    }

    public void OnClickMinusOne()
    {
        Count -= 1;
        Debug.Log("Count = " + Count);
    }

    public void OnClickMinusTwo()
    {
        Count -= 2;
        Debug.Log("Count = " + Count);
    }

    public void OnClickZero()
    {
        Count += 0;
        Debug.Log("Count = " + Count);
    }


    public void Update ()
    {
        if (analyzingWindow.activeSelf)
        {
            finalWindow.SetActive(true);

            if ((-40 <= Count) && (Count <= -24))
            {
                option1.SetActive(true);
            }

            else if ((-24 < Count) && (Count <= -8))
            {
                option2.SetActive(true);
            }

            else if ((-8 < Count) && (Count <= 8))
            {
                option3.SetActive(true);
            }

            else if ((8 < Count) && (Count <= 24))
            {
                option4.SetActive(true);
            }

            else
            {
                option5.SetActive(true);
            }

        }
     }
}
