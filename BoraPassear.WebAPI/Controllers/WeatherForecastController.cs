using Microsoft.AspNetCore.Mvc;

namespace BoraPassear.WebAPI.Controllers
{
    [ApiController]
    [Route("WatherForecast")]
    public class WeatherForecastsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastsController> _logger;

        public WeatherForecastsController(ILogger<WeatherForecastsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Listar")]
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
}