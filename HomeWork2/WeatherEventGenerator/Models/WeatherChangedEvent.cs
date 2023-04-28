namespace WeatherEventGenerator.Models;

public struct Weather
{
    public int Temp { get; set; }
    public int Wet { get; set; }
    public int C02 { get; set; }
}

public class WeatherChangedEvent
{
    public long Id { get; set; }

    public int SensorId { get; set; }
    
    public DateTime Date { get; set; }

    public Weather Weather { get; set; }
}