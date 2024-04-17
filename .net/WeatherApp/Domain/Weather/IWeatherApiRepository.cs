using WeatherApp.Domain.Shared;

namespace WeatherApp.Domain.Weather;

public interface IBaseWeatherApiRepository
{
    Task<WeatherInfo?> GetCurrentAsync(Location location, UnitsSystem units, CancellationToken cancellationToken = default);
    Task<IEnumerable<WeatherInfo>> GetForecastAsync(Location location, UnitsSystem units, int days, CancellationToken cancellationToken = default);
}