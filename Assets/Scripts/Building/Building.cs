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

    private int cooldownTime;
    
    public AutomaticProductionMethod(int cooldownTime)
    {
        this.cooldownTime = cooldownTime;
        DoAutomaticProduction();
    }
    
    private async Task DoAutomaticProduction()
    {
        while (true)
        {
            await Task.Delay(cooldownTime);
            StartProduction();
        }
    }
    
    public async Task StartProduction()
    {
        
    }

}

public class ManualProductionMethod : IProductionMethod
{

    private int cooldownTime;
    private bool isProducing;

    public ManualProductionMethod(int cooldownTime)
    {
        this.cooldownTime = cooldownTime;
    }
    
    public async Task StartProduction()
    {
        if (isProducing) return;
        
        isProducing = true;
        await Task.Delay(cooldownTime);
        isProducing = false;
    }

}

public interface IProductionMethod
{
    Task StartProduction();
}