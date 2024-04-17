using Microsoft.Extensions.Configuration;
using WeatherApp.Domain.Shared;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Infrastructure;

public class AccuWeatherApiRepository : IBaseWeatherApiRepository
{
    private readonly IHttpClientFactory _factory;
    private readonly IConfiguration _config;

    public AccuWeatherApiRepository(IHttpClientFactory factory, IConfiguration config)
    {
        _factory = factory;
        _config = config;
    }

    public Task<WeatherInfo?> GetCurrentAsync(Location location, UnitsSystem units, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<WeatherInfo>> GetForecastAsync(Location location, UnitsSystem units, int days, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}