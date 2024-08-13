using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float StartTime = 90;
    public Text timeText;

    void Update()
    {   
        if (StartTime > 0)
        {
            StartTime =  StartTime - Time.deltaTime;
        }else
        {
            StartTime = 0;
        }
        DisplayTime(StartTime);
                
    }
    void DisplayTime(float TimeToDisplay)
    {
        if (TimeToDisplay < 0)
        {
            TimeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);
        timeText.text = "Time Remaining: "  + string.Format("{0:00}:{1:00}", minutes,seconds);
    }
}
