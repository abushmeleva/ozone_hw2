

using WeatherEventGenerator.Services;

namespace WeatherEventGenerator;
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
        b.MapGrpcService<WeatherEventGeneratorService>();
    });
app.Run();*/
public class Startup
{
    private readonly IConfiguration _configuration;
    private readonly IHostEnvironment _hostEnvironment;

    public Startup(IConfiguration configuration, IHostEnvironment hostEnvironment)
    {
        _configuration = configuration;
        _hostEnvironment = hostEnvironment;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        /*
        services.Configure<StoreConfig>(_configuration.GetSection("StoreConfig"));

        services.AddScoped<DemoInterceptor>();
        services.AddGrpcClient<Ozon.EventGenerator.Generator.GeneratorClient>(
            options =>
            {
                options.Address = new Uri("https://localhost:7235/");
            }).AddInterceptor<DemoInterceptor>();

        services.AddSomeServices();*/

        services.AddGrpc();
        services.AddMvcCore();
        services.AddSingleton<IWeatherEventStore, WeatherEventStore>();
        services.AddControllers();
        services.AddMvcCore();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
    {

        app.UseRouting();
        app.UseEndpoints(
            b =>
            {
                b.MapControllers();
                b.MapGrpcService<WeatherEventGeneratorService2222>();
            });
        
        //app.UseEndpoints(endpoints => endpoints.MapControllers());
    }
}