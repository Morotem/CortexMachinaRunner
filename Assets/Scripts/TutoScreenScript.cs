using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TutoScreenScript : MonoBehaviour
{
    public Timer timer;
    public PlayerMovement player;

    // Start is called before the first frame update
    void Start()
    {
        player.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginGame(){
        player.enabled = true;
        timer.BeginTimer();
        this.gameObject.SetActive(false);
    }

    public void ResumeGame()
    {
        player.enabled = true;
        timer.ResumeTimer();
    }

}
