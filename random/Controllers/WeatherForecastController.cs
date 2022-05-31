using Microsoft.AspNetCore.Mvc;

namespace random.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /// <summary>
        /// returns real weather
        /// </summary>
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// get method teruns fake weather;
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
    [ApiController]
    [Route("[controller]")]

    public class WeatherForecastControllers : ControllerBase
    {
        /// <summary>
        /// returns real weather
        /// </summary>
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastControllers> _logger;

        public WeatherForecastControllers(ILogger<WeatherForecastControllers> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// get method teruns fake weather;
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetWeatherForecastsing")]
        public IEnumerable<WeatherForecasts> Delete()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecasts
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }    
}