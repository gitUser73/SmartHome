using backend.src.Helper;
using backend.src.Services.Interfaces;
using IO.Swagger.Models;

namespace backend.src.Services
{
    public class TemperatureService : ITemperatureService
    {
        public TemperatureData getCurrentTemperature()
        {
            return CurrentTemperatureHelper.CurrentTemperature;
        }

        public void setCurrentTemperature(TemperatureData temp)
        {
            CurrentTemperatureHelper.CurrentTemperature = temp;
        }
    }
}