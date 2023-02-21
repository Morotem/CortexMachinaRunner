using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdminMenuScript : MonoBehaviour
{
    public Toggle cbStraightRace;
    public Toggle cbChillRun;
    public Toggle cbEmotionOdyssey;
    public Toggle cbSideStepChallenge;
    
    void Start() {
        cbStraightRace.isOn = PlayerPrefs.GetInt("StraightRace", 0) == 1;
        cbChillRun.isOn = PlayerPrefs.GetInt("ChillRun", 0) == 1;
        cbEmotionOdyssey.isOn = PlayerPrefs.GetInt("EmotionOdyssey", 0) == 1;
        cbSideStepChallenge.isOn = PlayerPrefs.GetInt("SideStepChallenge", 0) == 1;
    }
    public void StraightRaceOnChange(){
        PlayerPrefs.SetInt("StraightRace", cbStraightRace.isOn ? 1 : 0);
    }
    public void ChillRunOnChange(){
        PlayerPrefs.SetInt("ChillRun", cbChillRun.isOn ? 1 : 0);
    }
    public void EmotionOdysseyOnChange(){
        PlayerPrefs.SetInt("EmotionOdyssey", cbEmotionOdyssey.isOn ? 1 : 0);
    }
    public void SideStepChallengeOnChange(){
        PlayerPrefs.SetInt("SideStepChallenge", cbSideStepChallenge.isOn ? 1 : 0);
    }
}
