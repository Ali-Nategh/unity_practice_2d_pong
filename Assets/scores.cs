using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scores : MonoBehaviour
{
    [SerializeField] private Text leftPlayerScoreText;
    [SerializeField] private Text rightPlayerScoreText;
    public int leftPlayerScore = 0;
    public int rightPlayerScore = 0;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void addLeftPlayerScore(int scoreToAdd)
    {
        rightPlayerScore += scoreToAdd;
        rightPlayerScoreText.text = $"{rightPlayerScore}";
    }
    public void addRightPlayerScore(int scoreToAdd)
    {
        leftPlayerScore += scoreToAdd;
        leftPlayerScoreText.text = $"{leftPlayerScore}";
    }
}
