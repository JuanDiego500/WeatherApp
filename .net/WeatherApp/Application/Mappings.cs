using WeatherApp.Application.Weather.Current;
using WeatherApp.Application.Weather.Forecast;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Application;

public static class Mappings
{
    public static Location ToLocation(this CurrentWeatherQuery currentWeatherQuery)
    {
        return new Location(currentWeatherQuery.City, currentWeatherQuery.CountryCode);
    }

    public static Location ToLocation(this ForecastWeatherQuery forecastWeatherQuery)
    {
        return new Location(forecastWeatherQuery.City, forecastWeatherQuery.CountryCode);
    }
}