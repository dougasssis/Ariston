using Ariston.Enums;
using Ariston.Interfaces;

namespace Ariston.Services;

public class AristonController : BackgroundService
{
    private readonly IAriston _ariston;
    private bool boostOverridden;

    public AristonController(IAriston ariston)
    {
        _ariston = ariston;
    }
    
    public void OverrideBoost(bool overrideValue)
    {
        boostOverridden = overrideValue;
    }
    
    public async Task MonitorAndControl()
    {
        while (true)
        {
            PlantData? plantData = await _ariston.GetPlantData();
            if (plantData is not null)
            {
                int currentHour = DateTime.Now.Hour;

                if (currentHour is >= 6 and <= 22 && plantData.Temp < 40)
                {
                    await _ariston.SetMode(Mode.Boost);
                }
                else if (plantData.Temp >= 40 && !boostOverridden)
                {
                    await _ariston.SetMode(Mode.Green);
                }
            
                await Task.Delay(TimeSpan.FromMinutes(1));
            }
        }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        throw new NotImplementedException();
    }
}