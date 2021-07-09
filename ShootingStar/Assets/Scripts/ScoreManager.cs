using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    public void CalcScore(int value)
    {
        score += value;
        scoreText.text = "점수: " + score.ToString();
    }
}
