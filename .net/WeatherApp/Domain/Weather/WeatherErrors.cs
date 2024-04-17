using WeatherApp.Domain.Abstractions;

namespace WeatherApp.Domain.Weather;

public static class WeatherErrors
{
    public static Error NotFound = new(
        "Weather.NotFound",
        "No weather data found for the given location");

    public static Error MaxForecast = new(
        "Weather.MaxForecast",
        "The max days forecast is five");
}