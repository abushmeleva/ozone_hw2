using WeatherEventGenerator.Models;

namespace WeatherEventGenerator.Services;

public interface IWeatherEventStore
{
    public void AddEvent(WeatherChangedEvent @event);

    public void RemoveEvent(int id);

    public WeatherChangedEvent GetById(int id);

    //public int GetCountEventsByState(StateType stateType);
}