using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class detect : MonoBehaviour
{
  
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public float overlap = 0;



    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("yes");
        overlap = overlap + 1;
    }
    private void Start()
    {
        timerIsRunning = true;
    }

    public void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            
        }
        else
        {
            timeRemaining = 0;
            timerIsRunning = false;
            if (overlap >= 6)
            {
                SceneManager.LoadSceneAsync("win");
            }
            else
            {
                SceneManager.LoadSceneAsync("lose");
            }

        }


    }
}

