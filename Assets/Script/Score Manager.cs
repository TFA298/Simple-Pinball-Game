using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float score;

    private void Start() 
    {
        ResetScore();
    }
    public void AddScore(float addtion)
    {
        score += addtion;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
