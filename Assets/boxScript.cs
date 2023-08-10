using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxScript : MonoBehaviour
{
    public float boxMoveSpeed = 10;
    public double rightWallPositionX = 10.75;
    public double leftWallPositionX = -10.75;
    public bool movingRight = true;

    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.x < rightWallPositionX && movingRight)
        {
            movingRight = true;
            transform.position += (Vector3.right * boxMoveSpeed) * Time.deltaTime;
        }
        else if (transform.position.x > leftWallPositionX)
        {
            movingRight = false;
            transform.position += (Vector3.left * boxMoveSpeed) * Time.deltaTime;
        } else
        {
            movingRight = true;
        }
    }
}
