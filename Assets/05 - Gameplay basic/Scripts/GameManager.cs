using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStates
{
    InitGame,
    PlayingGame,
    Pause,
    Dead,
    GameOver
}

public class GameManager : MonoBehaviour
{
    public static GameManager _ins;
    [SerializeField] private GameStates currentGameState;

    public GameData gameData;


    private void Awake()
    {
        if (_ins == null)
        {
            _ins = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Buscaremos el GObject que continene las referencias para iniciar las variables referenciadas del GameManager
    void Start()
    {
        //Init the gameData to 0
        gameData.InitCurrentData();
    }

    private void Update()
    {
        switch (currentGameState)
        {
            case GameStates.InitGame:
                InitGame();     //UI con letras de nombre del nivel
                break;
            case GameStates.PlayingGame:
                PlayingGame();  //Gameplay!
                break;
            case GameStates.Pause:
                PauseGame();    //Haré salir la UI
                break;
            case GameStates.Dead:
                HandleDead();   //Tiempo entre que se muere el personaje y cambiamos de pantalla o activamos UI.
                break;
            case GameStates.GameOver:
                GameOver();     //Cambio de escena o activación de UI
                break;
        }
    }

    private void GameOver()
    {
        Debug.Log($"{this.gameObject.name} - GameOver!");
    }

    private void HandleDead()
    {
        Debug.Log($"{this.gameObject.name} - HandleDead!");
    }

    private void PauseGame()
    {
        Debug.Log($"{this.gameObject.name} - PauseGame!");
    }

    private void PlayingGame()
    {
        Debug.Log($"{this.gameObject.name} - PlayingGame!");
    }

    private void InitGame()
    {
        Debug.Log($"{this.gameObject.name} - InitGame!");
    }

    public bool isPlaying()
    {
        return (currentGameState == GameStates.PlayingGame);
    }


    internal void IncreaseCoin()
    {
        gameData.UpdateCurrentCoints(1);
    }
    internal void IncreaseCoin(int coins)
    {
        gameData.UpdateCurrentCoints(coins);
    }



}
