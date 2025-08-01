using EventingApp.ApiService.Controllers.WeatherForecast.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EventingApp.ApiService.Controllers.WeatherForecast;

public class WeatherForecastController : ApiControllerBase
{
    private readonly string[] _summaries =
        ["Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"];

    [HttpGet("all")] //GET api/WeatherForecast/all
    public WeatherForecastResponseDto[] GetAll()
    {
        return Enumerable.Range(1, 5).Select(index =>
                new WeatherForecastResponseDto
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    _summaries[Random.Shared.Next(_summaries.Length)]
                ))
            .ToArray();
    }
}