using Microsoft.AspNetCore.Mvc;
using test_progetto_1.DM;

namespace test_progetto_1.Controllers
{
    [ApiController]// Decoration da qui in avanti avremo una clase controller di tipo api
    [Route("[controller]")]// quando avremo una chiamata http  CHE neull'url, dopo il dominio ha la parola WeatherForecast dovremo usaere le action seguenti tutte le classi controller devono finire con la parola "controller"
    public class WeatherForecastController : ControllerBase
    {
        //array  che è condiviso tra tutte le istanze della ControlelrBase questo perchè è statico
        //readonly ->non più essere modificato (se non nel costruttoree)
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]//se la action è di tipo http get , si deve eseguire questo codice
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

        [HttpPost]//se la action è di tipo http post , si deve eseguire questo codice
        public IEnumerable<WeatherForecast> Post()
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