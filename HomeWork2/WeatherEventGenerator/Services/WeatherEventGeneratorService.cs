using Grpc.Core;
using WeatherEventGenerator;

namespace WeatherEventGenerator.Services;

public class WeatherEventGeneratorService2222 : WeatherEventGenerator.WeatherEventGeneratorService.WeatherEventGeneratorServiceBase
{
    private readonly ILogger<WeatherEventGeneratorService2222> _logger;

    public WeatherEventGeneratorService2222(ILogger<WeatherEventGeneratorService2222> logger)
    {
        _logger = logger;
    }

    
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        return Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
    }
}