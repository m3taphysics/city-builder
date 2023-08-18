using System;
using System.Threading.Tasks;
using UnityEngine;

public class Building : MonoBehaviour
{

    [SerializeField] private BuildingScriptableObject buildingDescription;
    private IProductionMethod productionMethod;
    
    

    private void BuildingComplete()
    {
        switch (buildingDescription.BuildingType)
        {
            case BuildingType.RESIDENCE:
                productionMethod = new AutomaticProductionMethod();
                break;
            case BuildingType.WOOD :
            case BuildingType.STEEL:
                productionMethod = new ManualProductionMethod();
                break;
            default:
                productionMethod = new ManualProductionMethod();
                break;
        }
    }

    public void StartProduction()
    {
        productionMethod.StartProduction();
    }

}


public class AutomaticProductionMethod : IProductionMethod
{

    private int constructionTime;
    private int timeToNewAutomaticProduction;
    
    public AutomaticProductionMethod(int constructionTime, int timeToNewAutomaticProduction)
    {
        this.constructionTime = constructionTime;
        this.timeToNewAutomaticProduction = timeToNewAutomaticProduction;
        DoAutomaticProduction();
    }
    
    private async Task DoAutomaticProduction()
    {
        while (true)
        {
            await Task.Delay(timeToNewAutomaticProduction);
            StartProduction();
        }
    }
    
    public async Task StartProduction()
    {
        await Task.Delay(constructionTime);
    }

}

public class ManualProductionMethod : IProductionMethod
{
    public async Task StartProduction()
    {
        await Task.Delay(timeToProduce);
    }

}

public interface IProductionMethod
{
    Task StartProduction();
}