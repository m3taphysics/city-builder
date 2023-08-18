using System;
using UnityEngine;

[CreateAssetMenu(fileName = "BuildingScriptableObject", menuName = "ScriptableObjects/BuildingScriptableObject", order = 1)]
public class BuildingScriptableObject : ScriptableObject
{
    [SerializeField]private BuildingType buildingType;

    public BuildingType BuildingType
    {
        get => buildingType;
    }

    public ResourceBundle[] BuildingCost
    {
        get => buildingCost;
    }

    public int ConstructionTimeInSeconds
    {
        get => constructionTimeInSeconds;
    }

    public ResourceBundle ProductionResource
    {
        get => productionResource;
    }

    public int ProductionTimeInSeconds
    {
        get => productionTimeInSeconds;
    }

    [SerializeField]private ResourceBundle[] buildingCost;
    [SerializeField]private int constructionTimeInSeconds = 10;
    
    [SerializeField]private ResourceBundle productionResource;
    [SerializeField]private int productionTimeInSeconds;

}

[Serializable]
public struct ResourceBundle
{
    [SerializeField]private Resource resource;
    [SerializeField]private int amout;
}

public enum BuildingType
{
    RESIDENCE, WOOD, STEEL, BENCH, TREE 
}

public enum Resource
{
    WOOD,GOLD,STEEL,NONE
}