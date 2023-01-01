using System.Collections;
using System.Collections.Generic;
using Pattern;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TMP_Text scoreText;
    
    public void Increase(int increaseValue)
    {
        score += increaseValue;
        scoreText.text = score.ToString();
    }
}
