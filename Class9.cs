using System;
using UnityEngine;
using UnityEngine.UI;

public class Class1
{
//Oyun Mekanikleri*
// Ödül Sistemi
  


public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Puan: " + score;
    }
}

//Her doğru cevapta:

FindObjectOfType<ScoreManager>(9,12).AddScore(10); 
	{
	}
}
