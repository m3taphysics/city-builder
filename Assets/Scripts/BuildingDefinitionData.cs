using UnityEngine;

[CreateAssetMenu(menuName = "Create BuildingDefinitionData", fileName = "BuildingDefinitionData", order = 0)]
public class BuildingDefinitionData : ScriptableObject
{
    public Building[] Buildings;
}