using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;

    public float smoothSpeed = 2f;

    private void Start()
    {
 
        offset = transform.position - target.position;
      
    }

    private void LateUpdate()
    {
        SmoothFollow();   
    }

    public void SmoothFollow()
    {
        Vector3 targetPos = target.position + offset;
        
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y, targetPos.z);
        newPos = Vector3.Lerp(transform.position, newPos, smoothSpeed);
        transform.position = newPos;

    }
}
