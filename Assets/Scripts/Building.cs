using System;
using UnityEngine;

public enum BuildState
{
    Built,
    Building,
    Placing
}

public class Building : MonoBehaviour
{
    [SerializeField] public string Name;
    [SerializeField] public Resource[] Cost;

    private float Progress;
    private BuildState BuildState;

    public void OnPointerDown()
    {
        Debug.Log(this.Name);
    }
    public void OnClickedEvent()
    {
        OnClicked?.Invoke(this);
    }
    
    public event Action<Building> OnClicked;
}