using WeatherApp.Application.Abstractions;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Application.Weather.Current;

public sealed record CurrentWeatherQuery(
    string City,
    string CountryCode,
    string UnitsSystem) : IQuery<WeatherInfo>;
