using WeatherEventGenerator;
using WeatherEventGenerator.Services;
using WeatherEventGeneratorService = WeatherEventGenerator.WeatherEventGeneratorService;
/*
var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<IWeatherEventStore, WeatherEventStore>();
builder.Services.AddMvcCore();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseRouting();
app.UseEndpoints(
    b =>
    {
        b.MapControllers();
        b.MapGrpcService<WeatherEventGeneratorService2222>();
    });
app.Run();

*/
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args)
        => Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
}

