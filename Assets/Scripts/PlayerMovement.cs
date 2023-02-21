using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float concentration = 10f;
    public int RestfullnessWeight;
    public float valueOfConcentrationChange = 5f;
    public const float MIN_CONCENTRATION_TO_MOVE = 20f;
    public const float MAX_CONCENTRATION_VALUE = 100f;
    public const float MIN_CONCENTRATION_VALUE = 0f;
    public const float MAX_CONCENTRATION_TO_DESTROY_WALL = 5f;
    public const float DIRECTION_OFFSET = 2;
    public float centerPositionOnX;
    public bool isMoving = false;
    public GameObject charModel;
    private Scene scene;
    public int indexOfStraightForwardScene = 3; 
    public int indexOfSideStepChallengeScene = 6;

    private bool needToRun;
    public GameObject WallToDestroy;
    public bool isInFrontOfFire;
    private Lvl4Dto dtoReceived = new Lvl4Dto{
            ConcentrationRatio = 0,
            RestfullnessWeight = 0,
            emotions = null,
            motion = new MotionWeight{
                Left = 0,
                Neutral = 1,
                Right = 0

            }
        };


    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        needToRun = (scene.buildIndex == indexOfStraightForwardScene);
        centerPositionOnX = transform.position.x;
        isInFrontOfFire = false;
    }

    // Update is called once per frame
    void Update()
    {
        handleRestfullnessValueChanged();
        HandleConcentrationValueChange();
        if(isInFrontOfFire)return;
        if(!needToRun) {
            if (RestfullnessWeight == 1){
                WallToDestroy.SetActive(false);
                needToRun = true;
            }
            return;
        }
        HandleMoveForward();
        if(scene.buildIndex == indexOfSideStepChallengeScene){
            HandleChangeDirection();
        }
    }

    private void handleRestfullnessValueChanged()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RestfullnessWeight = RestfullnessWeight == 0 ? 1 : 0;
        }
    }

    void HandleConcentrationValueChange(){
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            concentration = concentration - valueOfConcentrationChange < MIN_CONCENTRATION_VALUE ? 
                            MIN_CONCENTRATION_VALUE : concentration - valueOfConcentrationChange;
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            concentration = concentration + valueOfConcentrationChange > MAX_CONCENTRATION_VALUE ? 
                            MAX_CONCENTRATION_VALUE : concentration + valueOfConcentrationChange;
        }
    }

    void HandleMoveForward()
    {
        if(concentration > MIN_CONCENTRATION_TO_MOVE){
            if(isMoving == false){
                MakePlayerRun();
                
            }
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * (concentration/10));
            
        }else 
        {
            if(isMoving == true)
            {
                MakePlayerStop();

            }
        }
    }
    public void MakePlayerStop(){
        isMoving = false;
        charModel.GetComponent<Animator>().Play("Idle"); 
    }
    public void MakePlayerRun(){
        isMoving = true;
        charModel.GetComponent<Animator>().Play("Run");
        Debug.Log("run");
    }

    void HandleChangeDirection()
    {
        //this part will be removed when we will get input from Headset
        ///////////////////////////////
        
        
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dtoReceived.motion.Left = 1;
            //transform.position = new Vector3(centerPositionOnX - DIRECTION_OFFSET, transform.position.y, transform.position.z);

        } else if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            dtoReceived.motion.Left = 0;
            //transform.position = new Vector3(centerPositionOnX, transform.position.y, transform.position.z);
        }
        

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            dtoReceived.motion.Right = 1;
            //transform.position = new Vector3(centerPositionOnX + DIRECTION_OFFSET, transform.position.y, transform.position.z);

        }else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            dtoReceived.motion.Right = 0;
            //transform.position = new Vector3(centerPositionOnX, transform.position.y, transform.position.z);
        }
        /////////////////////////////////////////

        if(dtoReceived.motion.Left == 1){
            transform.position = new Vector3(centerPositionOnX - DIRECTION_OFFSET, transform.position.y, transform.position.z);
        }else if(dtoReceived.motion.Right == 1){
            transform.position = new Vector3(centerPositionOnX + DIRECTION_OFFSET, transform.position.y, transform.position.z);
        }else{
            transform.position = new Vector3(centerPositionOnX, transform.position.y, transform.position.z);
        }
        
        
    }
}
