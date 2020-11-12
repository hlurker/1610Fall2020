
using UnityEngine;

[CreateAssetMenu]
public class Weapons : ScriptableObject
{
    public enum GameStates
    {
        Sword,
        Knife,
        Gun,
        Rope,
    }

    public GameStates currentGameState = GameStates.Sword;

    public void ChangeToPlaying()
    {
        currentGameState = GameStates.Sword;
    }

    public void RunCurrentState()
    {
        switch (currentGameState)
        {
            case GameStates.Sword:
                Debug.Log(message: "Sword");
                break;
            case GameStates.Knife:
                Debug.Log(message: "Knife");
                break;
            case GameStates.Gun:
                Debug.Log(message: "Gun");
                break;
            case GameStates.Rope:
                Debug.Log(message: "Rope");
                break;
        }
    }
}
