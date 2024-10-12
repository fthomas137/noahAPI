using Microsoft.AspNetCore.Mvc;
using noahAPI.Domain.Models.Entities;
using noahAPI.Domain.Services;

namespace noahAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;


        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<WeatherForecast> Get()
        {
            return _weatherForecastService.GetAll();
        }
    }
}
