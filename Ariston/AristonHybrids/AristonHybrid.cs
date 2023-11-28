using Ariston.Enums;
using Ariston.Interfaces;
using Ariston.Services;

namespace Ariston.AristonHybrids;

public class AristonHybrid
{
    private double _temperature;
    private Mode _mode;
    private bool _isLoggedIn;
    
    private readonly IAriston _ariston;
    private readonly AristonController _aristonController;

    public AristonHybrid(IAriston ariston, AristonController aristonController)
    {
        _ariston = ariston;
        _aristonController = aristonController;
    }
    
    public async Task<(double temperature, Mode mode, bool isLoggedIn)> Login()
    {
        if (!_isLoggedIn)
        {
            _isLoggedIn = await _ariston.Login();
        }

        PlantData? plantData = await _ariston.GetPlantData();
        if (plantData == null)
        {
            throw new Exception("PlantData not found");
        }

        _temperature = plantData.Temp;
        _mode = plantData.Mode;
        return (_temperature, _mode, _isLoggedIn);
    }
    
    public async Task<bool> SetMode(Mode mode)
    {
        if (!_isLoggedIn)
        {
            Console.WriteLine("User not logged in");
            return false;
        }
        
        if (mode == _mode)
        {
            Console.WriteLine("Mode already set");
            return false;
        }
        
        if (mode == Mode.Boost)
        {
            _aristonController.OverrideBoost(true);
        }
        
        return await _ariston.SetMode(mode);
    }
}