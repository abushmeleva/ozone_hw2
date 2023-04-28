using System.Collections.Concurrent;
using WeatherEventGenerator.Models;

namespace WeatherEventGenerator.Services;

public class WeatherEventStore : IWeatherEventStore
{
    private readonly ConcurrentDictionary<long, WeatherChangedEvent> _events = new();
    
    public void AddEvent(WeatherChangedEvent @event)
    {
        _events.AddOrUpdate(@event.Id, _ => @event, (_, _) => @event);
    }

    public void RemoveEvent(int id)
    {
        _events.Remove(id, out _);
    }

    public WeatherChangedEvent GetById(int id)
    {
        if (_events.TryGetValue(id, out var @event))
        {
            return @event;
        }

        return null;
    }
}