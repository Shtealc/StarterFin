using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;





public class timer : MonoBehaviour
{
    public TextMeshProUGUI timedText;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
   
    private void Start()
    {
        timerIsRunning = true;
    }

    public void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            DisplayTime(timeRemaining);
        }
        else 
        {
            timeRemaining = 0;
            timerIsRunning=false;
        }
        

    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        
        timedText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    

}
