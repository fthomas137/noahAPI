using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Services
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> GetAll();
    }
}
