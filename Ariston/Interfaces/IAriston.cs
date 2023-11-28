using Ariston.Enums;

namespace Ariston.Interfaces;

public interface IAriston
{
    public Task<bool> Login();
    public Task<PlantData?> GetPlantData();
    public Task<bool> SetMode(Mode mode);
}