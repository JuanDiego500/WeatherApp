using WeatherApp.Application.Abstractions;
using WeatherApp.Domain.Abstractions;
using WeatherApp.Domain.Shared;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Application.Weather.Current;

public sealed class CurrentWeatherQueryHandler
    : IQueryHandler<CurrentWeatherQuery, WeatherInfo>
{
    private readonly IBaseWeatherApiRepository _weatherRepository;

    public CurrentWeatherQueryHandler(
        IBaseWeatherApiRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    public async Task<Result<WeatherInfo>> Handle(
        CurrentWeatherQuery query,
        CancellationToken cancellationToken)
    {
        var weatherInfo = await _weatherRepository.GetCurrentAsync(
            query.ToLocation(),
            UnitsSystem.FromSystem(query.UnitsSystem),
            cancellationToken);

        if (weatherInfo is null)
        {
            return Result.Failure<WeatherInfo>(WeatherErrors.NotFound);
        }

        return Result.Success(weatherInfo);
    }
}