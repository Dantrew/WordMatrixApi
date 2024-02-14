using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WordMatrixApi.Data;
using WordMatrixApi.Models;

namespace WordMatrixApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly WordMatrixContext _context;

        public WeatherForecastController(WordMatrixContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetWords")]
        public async Task<ActionResult<IEnumerable<Glossary>>> GetWords()
        {
            return await _context.Glossary.Take(100).ToListAsync();
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;


        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
    }
}
