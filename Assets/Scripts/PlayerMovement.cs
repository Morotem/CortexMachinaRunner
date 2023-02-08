using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float concentration = 10f;
    public float valueOfConcentrationChange = 5f;
    public const float MIN_CONCENTRATION_TO_MOVE = 20f;
    public const float MAX_CONCENTRATION_VALUE = 100f;
    public const float MIN_CONCENTRATION_VALUE = 0f;
    public const float DIRECTION_OFFSET = 2;
    public float centerPositionOnX;
    public bool isMoving = false;
    public GameObject charModel;



    // Start is called before the first frame update
    void Start()
    {
       centerPositionOnX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        HandleMoveForward();
        HandleChangeDirection();
        
    }

    void HandleMoveForward()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            concentration = concentration - valueOfConcentrationChange < MIN_CONCENTRATION_VALUE ? 
                            MIN_CONCENTRATION_VALUE : concentration - valueOfConcentrationChange;
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            concentration = concentration + valueOfConcentrationChange > MAX_CONCENTRATION_VALUE ? 
                            MAX_CONCENTRATION_VALUE : concentration + valueOfConcentrationChange;
        }

        if(concentration > MIN_CONCENTRATION_TO_MOVE){
            if(isMoving == false){
                isMoving = true;
                charModel.GetComponent<Animator>().Play("Run"); 
            }
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * (concentration/10));
        }else 
        {
            if(isMoving == true)
            {
                isMoving = false;
                charModel.GetComponent<Animator>().Play("Idle"); 

            }
        }
    }

    void HandleChangeDirection()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(centerPositionOnX - DIRECTION_OFFSET, transform.position.y, transform.position.z);

        } else if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(centerPositionOnX, transform.position.y, transform.position.z);
        }
        

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(centerPositionOnX + DIRECTION_OFFSET, transform.position.y, transform.position.z);

        }else if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position = new Vector3(centerPositionOnX, transform.position.y, transform.position.z);
        }
    }
}
