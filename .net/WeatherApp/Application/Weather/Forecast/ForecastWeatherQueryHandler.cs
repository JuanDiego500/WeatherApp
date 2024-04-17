using WeatherApp.Application.Abstractions;
using WeatherApp.Domain.Abstractions;
using WeatherApp.Domain.Shared;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Application.Weather.Forecast;

public sealed class ForecastWeatherQueryHandler
    : IQueryHandler<ForecastWeatherQuery, IReadOnlyList<WeatherInfo>>
{
    private readonly IBaseWeatherApiRepository _weatherRepository;

    public ForecastWeatherQueryHandler(
        IBaseWeatherApiRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }
    public async Task<Result<IReadOnlyList<WeatherInfo>>> Handle(
        ForecastWeatherQuery query,
        CancellationToken cancellationToken)
    {
        if (query.Days > 5)
        {
            return Result.Failure<IReadOnlyList<WeatherInfo>>(WeatherErrors.NotFound);
        }
        var weatherInfo = await _weatherRepository.GetForecastAsync(
            query.ToLocation(),
            UnitsSystem.FromSystem(query.UnitsSystem),
            query.Days,
            cancellationToken);

        if (weatherInfo.Count() == 0)
        {
            return Result.Failure<IReadOnlyList<WeatherInfo>>(WeatherErrors.NotFound);
        }

        return weatherInfo.ToList();
    }
}