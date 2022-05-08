using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SystemClock : MonoBehaviour
{
    public GameObject theDisplay;
    public int hours;
    public int minutes;
    public int seconds;

    void Update()
    {
        hours = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        seconds = System.DateTime.Now.Second;

        // For a 12 Hour Clock - Remove for 24 Hour Clock
        if (hours > 12)
        {
            hours -= 12;
        }

        theDisplay.GetComponent<TMP_Text>().text = "" + hours + ":" + minutes + ":" + seconds;
    }
}