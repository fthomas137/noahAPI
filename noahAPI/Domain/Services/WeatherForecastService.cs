using noahAPI.Domain.Managers.Repositories;
using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepositories _weatherForecastRepositories;
        public WeatherForecastService(IWeatherForecastRepositories weatherForecastRepositories)
        {
            _weatherForecastRepositories = weatherForecastRepositories;
        }
        public List<WeatherForecast> GetAll()
        {
            return _weatherForecastRepositories.GetAll();
        }
    }
}
