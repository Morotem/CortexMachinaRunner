using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLine : MonoBehaviour
{
    public GameObject player;  
    public GameObject charModel;  
  
    void OnTriggerEnter(Collider other) {
        this.gameObject.GetComponent<MeshCollider>().enabled = false;
        player.GetComponent<PlayerMovement>().enabled = false;
        charModel.GetComponent<Animator>().Play("Dancing Maraschino Step");
        GameObject.Find("TimerTracker").SendMessage("Finish");

    }
}
