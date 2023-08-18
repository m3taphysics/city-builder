using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] private Button regularModeButton;
    [SerializeField] private Button buildModeButton;

    
    private IGameState currentGameState;
    private Dictionary<GameState, IGameState> gameStates = new ();
    
    private Building [] buildings;

    private void Awake()
    {
        regularModeButton.onClick.AddListener(OnRegularModePressed);
        buildModeButton.onClick.AddListener(OnBuildModePressed);

        gameStates[GameState.BUILD] = new BuildGameState();
        gameStates[GameState.REGULAR] = new RegularGameState();

        // Hacky way to get all buildings
        buildings = FindObjectsOfType<Building>();
        foreach (var building in buildings)
        {
            building.OnClicked += OnBuildingClicked;
        }
        
        ChangeGameState(GameState.REGULAR);
    }

    private void OnBuildingClicked(Building building)
    {
        currentGameState.OnBuildingClicked(building);
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

    public void OnBuildingClicked(Building building)
    {
        Debug.Log(building.Name);
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

    public void OnBuildingClicked(Building building)
    {
        
    }
}
