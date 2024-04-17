using WeatherApp.Domain.Shared;

namespace WeatherApp.Domain.Weather;

public record WeatherInfo(
    Location Location,
    DateTime Date,
    string Description,
    Temperature Temperature);
