using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameSwitch : ScriptableObject
{
    public enum GameStates
    {
        Starting,
        Playing, 
        Ending,
        InStore,
        Pausing
    }

    public GameStates currentGameState = GameStates.Starting;

    public void ChangeToPlaying()
    {
        currentGameState = GameStates.Playing;
    }

    public void RunCurrentState()
    {
        switch (currentGameState)
        {
            case GameStates.Starting:
                Debug.Log(message: "Starting");
                break;
            case GameStates.Playing:
                Debug.Log(message: "Playing");
                break;
            case GameStates.Ending:
                Debug.Log(message: "Ending");
                break;
            case GameStates.InStore:
                Debug.Log(message: "InStore");
                break;
            case GameStates.Pausing:
                Debug.Log(message: "Pausing");
                break;
        }
    }
}
