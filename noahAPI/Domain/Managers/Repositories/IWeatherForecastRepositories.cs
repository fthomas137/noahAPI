using noahAPI.Domain.Models.Entities;

namespace noahAPI.Domain.Managers.Repositories
{
    public interface IWeatherForecastRepositories
    {
        List<WeatherForecast> GetAll();
    }
}
