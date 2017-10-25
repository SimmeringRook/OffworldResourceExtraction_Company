/// <summary>
/// Base Data structure for ORE-C Buildings
/// </summary>
public class Building
{
    //IBuildable?
    //
    private string _name;
    public string Name
    {
        get;
        protected set;
    }

    public Building()
    {

    }
}

public interface IBuildable
{
    /// <summary>
    /// Place blueprint of building
    /// Add build job to queue
    /// </summary>
    void OnPlaceBuilding();

    /// <summary>
    /// Remove job from queue
    /// Ensure blueprint has been removed
    /// </summary>
    void OnBuildComplete();

    /// <summary>
    /// Update Model/Texture
    /// </summary>
    void UpdateBuildingGraphics();

    /// <summary>
    /// Get Percentage of building to being complete
    /// </summary>
    /// <returns></returns>
    float GetBuildPercent(); 
    
    //Any other functions?
}

public interface ISolidStockpile
{
    void Deposit(ISolidResource solidResourceToAddToStockpile);

    ISolidResource Withdraw(float amountToRemoveFromStockpile);
}

public interface ISolidResource
{
    //float GetAmount(IMeasurement measurementToReturnAmountIn);

    //void AddAmount(IMeasurement measurementToAdd, float amount);
}

/* 
public interface IMeasurement
{

}

or create struct? 

struct ResourceAmountAndMeasurement
{
    float Amount;
    Measurement UnitMeasuredIn;
}
*/
