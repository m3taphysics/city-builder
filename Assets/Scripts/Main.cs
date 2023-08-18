using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] private Button regularModeButton;
    [SerializeField] private Button buildModeButton;

    
    private IGameState currentGameState;
    private Dictionary<GameState, IGameState> gameStates = new ();

    private void Awake()
    {
        regularModeButton.onClick.AddListener(OnRegularModePressed);
        buildModeButton.onClick.AddListener(OnBuildModePressed);

        gameStates[GameState.BUILD] = new BuildGameState();
        gameStates[GameState.REGULAR] = new RegularGameState();
        
        ChangeGameState(GameState.REGULAR);
    }

    private void OnBuildModePressed()
    {
        ChangeGameState(GameState.BUILD);
    }

    private void OnRegularModePressed()
    {
        ChangeGameState(GameState.REGULAR);
    }

    private void ChangeGameState(GameState gameState)
    {
        currentGameState?.Disable();
        currentGameState = gameStates[gameState];
        currentGameState.Enable();
    }
}

public class RegularGameState : IGameState
{
    public void Enable()
    {
        Debug.Log("Regular game state");
    }

    public void Disable()
    {
        
    }
}

public class BuildGameState : IGameState
{
    public void Enable()
    {
        Debug.Log("Build game state");
    }

    public void Disable()
    {
        
    }
}
