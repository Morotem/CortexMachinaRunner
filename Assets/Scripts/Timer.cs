using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    private bool finished = false;
    
    //private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        //startTime = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if(finished) return;
        //float chrono = Time.time - startTime;
        float currentTime = Time.time;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        textComponent.text = time.ToString("mm':'ss':'fff");
        // string minutes = ((int)chrono / 60).ToString();
        // string seconds = (chrono % 60).ToString("f2");
        // textComponent.text = minutes + ":" + seconds + "s";
    }

    public void Finish()
    {
        finished = true;
        textComponent.color = Color.yellow;
    }

}
