using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenFireWall : MonoBehaviour
{
    public PlayerMovement player;
    private bool isStoppingPlayer = false;
    public const float CONCENTRATION_REQUIRED = 40f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStoppingPlayer)return;
        if(player.concentration<=CONCENTRATION_REQUIRED){
            player.MakePlayerRun();
            player.isInFrontOfFire = false;
            isStoppingPlayer = false;
        }
 
    }

    void OnTriggerEnter(Collider other) {
        if(player.concentration<=CONCENTRATION_REQUIRED)return;
        player.isInFrontOfFire = true;
        isStoppingPlayer = true;
        player.MakePlayerStop();
        Debug.Log("stop");
    }


}
