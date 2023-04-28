using Microsoft.AspNetCore.Mvc;
using WeatherEventGenerator.Models;
using WeatherEventGenerator.Services;

namespace WeatherEventGenerator.Controllers;


[Route("events")]
public class WeatherEventController : Controller
{
    private readonly IWeatherEventStore _storage;

    public WeatherEventController(IWeatherEventStore storage)
    {
        _storage = storage;
    }

    [HttpGet("{id:int}")] // url/events/id
    public async Task<ActionResult<WeatherChangedEvent>> GetWeatherBySensorId()
    {
        var result = new WeatherChangedEvent()
        {
            Date = DateTime.Now,
            Id = 5,
            SensorId = 4,
            Weather = new Weather()
            {
                C02 = 1,
                Temp = 12,
                Wet = 43
            }
        };

        return Ok(result);
    }
}