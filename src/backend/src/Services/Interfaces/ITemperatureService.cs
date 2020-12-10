using IO.Swagger.Models;

namespace backend.src.Services.Interfaces
{
    public interface ITemperatureService
    {
        public TemperatureData getCurrentTemperature();

        public void setCurrentTemperature(TemperatureData temp);
    }
}