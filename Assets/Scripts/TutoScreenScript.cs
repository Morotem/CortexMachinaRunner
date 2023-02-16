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
        timer.beginTimer();
        this.gameObject.SetActive(false);
    }
}
