using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu : MonoBehaviour
{
    
    public GameObject charModel;



    // Start is called before the first frame update
    void Start()
    {
      charModel.GetComponent<Animator>().Play("Dancing"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

  
}
