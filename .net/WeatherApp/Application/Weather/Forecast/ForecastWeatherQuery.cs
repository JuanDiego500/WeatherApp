using WeatherApp.Application.Abstractions;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Application.Weather.Forecast;

public sealed record ForecastWeatherQuery(
    string City,
    string CountryCode,
    string UnitsSystem,
    int Days) : IQuery<IReadOnlyList<WeatherInfo>>
{

}