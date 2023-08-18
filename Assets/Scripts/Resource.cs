using System;

[Serializable]
public class Resource
{
    [Serializable]
    public enum ResourceType
    {
        WOOD,
        STEEL,
        GOLD
    }
        
    public ResourceType Type;
    public int Value;
}