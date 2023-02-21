using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceMenuScript : MonoBehaviour
{
    public GameObject straightRaceBtn;
    public GameObject chillRunBtn;
    public GameObject emotionOdysseyBtn;
    public GameObject sideStepChallengeBtn;
    void Start(){
        straightRaceBtn.SetActive(PlayerPrefs.GetInt("StraightRace", 1) == 1);
        chillRunBtn.SetActive(PlayerPrefs.GetInt("ChillRun", 1) == 1);
        emotionOdysseyBtn.SetActive(PlayerPrefs.GetInt("EmotionOdyssey", 1) == 1);
        sideStepChallengeBtn.SetActive(PlayerPrefs.GetInt("SideStepChallenge", 1) == 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
