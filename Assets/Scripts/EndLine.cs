using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : Collisionable
{
    public string contextMessage = "Congratulations!!! You did it !";
    public string animationName = "Dancing Maraschino Step";
    public override void displayEndScreen()
    {
        GameObject endScreen = GameObject.Find("EndGameScreen");
        endScreen.SetActive(true);
        endScreen.SendMessage("Display", contextMessage);
    }

    public override void PlayAnimation()
    {
        charModel.GetComponent<Animator>().Play(animationName);
    }
}
