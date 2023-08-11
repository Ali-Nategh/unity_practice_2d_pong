using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightWall : MonoBehaviour
{
    public GameObject scoresObject;
    public scores scoresScript;

    void Start()
    {
        scoresScript = scoresObject.GetComponentInChildren<scores>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoresScript.addRightPlayerScore(1);
    }
}
