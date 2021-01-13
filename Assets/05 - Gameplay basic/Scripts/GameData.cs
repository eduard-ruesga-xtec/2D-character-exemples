using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level
{
    [SerializeField]
    public int Maxscore { get; set; }
    public string Name { get; private set; }
    public Scene numScene;

}


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]

public class GameData :ScriptableObject
{
    //In current Gameplay Data
    [SerializeField] private int currentCoins;
    [SerializeField] private int currentScore;

    [SerializeField]
    public int MaxScore { get; private set; }


    public int CurrentCoins { get { return currentScore; } }
    public int CurrentScore { get; }

    public void UpdateMaxScore(int score)
    {
        score = MaxScore;
    }

    internal void ResetCurrentData()
    {
        InitCurrentData();
    }

    internal void InitCurrentData()
    {
        currentScore = 0;
        currentCoins = 0;
    }

    public void UpdateCurrentScore(int score)
    {
        score += currentCoins;
    }
    public void UpdateCurrentCoints(int score)
    {
        score += currentScore;
    }


    //WIP
    /* public int CurrentScore
     {
         get
         {
             return CurrentScore;
         }
         set
         {
             CurrentScore += value;
         }
     }
     [SerializeField]
     public float CurrentLives { get; set; }
     public Level[] LevelsArray;*/

}
