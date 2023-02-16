using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenFireWall : MonoBehaviour
{
    public PlayerMovement player;
    private bool isStoppingPlayer = false;
    public const float CONCENTRATION_REQUIRED = 40f;
    public GameObject[] smokeGrey;
    public GameObject[] smokePurple;

    void Start()
    {
        DesactiveFire();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isStoppingPlayer)return;
        if(player.concentration<=CONCENTRATION_REQUIRED){
            player.isInFrontOfFire = false;
            isStoppingPlayer = false;
            player.MakePlayerRun();
            ActiveFire();
        }
 
    }

    void OnTriggerEnter(Collider other) {
        if(player.concentration<=CONCENTRATION_REQUIRED){
            ActiveFire();
            return;}
        player.isInFrontOfFire = true;
        isStoppingPlayer = true;
        player.MakePlayerStop();
        Debug.Log("stop");
    }

    void ActiveFire(){
        foreach(GameObject purple in smokePurple){
            purple.SetActive(true);
        }
        foreach(GameObject grey in smokeGrey){
            grey.SetActive(false);
        }
    }
    void DesactiveFire(){
        foreach(GameObject purple in smokePurple){
            purple.SetActive(false);
        }
        foreach(GameObject grey in smokeGrey){
            grey.SetActive(true);
        }
    }


}
