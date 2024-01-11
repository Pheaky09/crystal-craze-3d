using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour

{
    public float timeRemaining = 0;
    public bool timerIsRunning = true;
    public TextMeshProUGUI timetext;
    private void Start()
    {
        timerIsRunning = true;

    }
    private void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }

        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timetext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }


}
