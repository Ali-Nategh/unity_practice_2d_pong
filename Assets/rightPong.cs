using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightPong : MonoBehaviour
{
    public float pongMoveSpeed = 20;
    public double upWallPositionY = 3.8;
    public double downWallPositionY = -3.8;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= upWallPositionY)
        {
            transform.position += (Vector3.up * pongMoveSpeed) * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= downWallPositionY)
        {
            transform.position += (Vector3.down * pongMoveSpeed) * Time.deltaTime;
        }
    }
}
