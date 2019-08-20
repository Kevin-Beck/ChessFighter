using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public Text scoreBoard;
    private int score;

    private void Start()
    {
        score = 0;
    }
    public void AddScore()
    {
        score += 10;
        scoreBoard.text = "Score: " + score;
    }
    
}
