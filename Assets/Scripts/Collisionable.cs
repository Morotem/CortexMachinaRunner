using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collisionable : MonoBehaviour
{
    public GameObject player;  
    public GameObject charModel;

    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        GameObject.Find("TimerTracker").SendMessage("Finish");
        PlayAnimation();
        displayEndScreen();
        //display endScreen
    }


    public abstract void displayEndScreen();
    public abstract void PlayAnimation();
}
