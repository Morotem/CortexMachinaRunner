using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject player;  
    public GameObject charModel;  
  
    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        GameObject.Find("TimerTracker").SendMessage("Finish");

    }
}
