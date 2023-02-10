using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : Collisionable
{
    public string contextMessage = "So... You can't control yourself right ?";
    public string animationName = "Stumble Backwards";
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
