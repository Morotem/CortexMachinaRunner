using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private bool finished = false;
    private float startTime;
    public bool gameStarted = false;
    private bool isPaused = false;
    private float pauseStartTime;
    private float pauseDuration;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(finished || !gameStarted || isPaused) return;
        float chrono = Time.time - startTime;
        //float currentTime = Time.time;
        //TimeSpan time = TimeSpan.FromSeconds(currentTime);
        //textComponent.text = time.ToString("mm':'ss':'fff");
        string minutes = ((int)chrono / 60).ToString();
        string seconds = (chrono % 60).ToString("f3");
        textComponent.text = minutes + ":" + seconds + "";
    }

    public void Finish()
    {
        finished = true;
        textComponent.color = Color.yellow;
    }

    public void BeginTimer(){
        gameStarted = true;
        startTime = Time.time;
    }
    public void PauseTimer()
    {
        if (!isPaused)
        {
            isPaused = true;
            pauseStartTime = Time.time;
        }
    }

    public void ResumeTimer()
    {
        if (isPaused)
        {
            isPaused = false;
            pauseDuration = Time.time - pauseStartTime;
            startTime += pauseDuration;
        }
    }
    

}
