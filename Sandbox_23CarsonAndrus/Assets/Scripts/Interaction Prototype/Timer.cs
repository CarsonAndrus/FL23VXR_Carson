using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public GameObject Ball;
    void Update()
    {
        //prevents timer going lower than 0
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
       // spawns ball when timer ends
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            Ball.SetActive(true);
        }

        
        
        
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //displays the timer via text and formats text to 00:00
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
