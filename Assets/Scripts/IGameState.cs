public interface IGameState
{
    void Enable();
    void Disable();
    void OnBuildingClicked(Building building);
}