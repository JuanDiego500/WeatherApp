using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string weatherApiValue)
        {
            if (weatherApiValue is "open")
            {
                services.AddScoped<IBaseWeatherApiRepository, OpenWeatherApiRepository>();
            }
            else
            {
                services.AddScoped<IBaseWeatherApiRepository, AccuWeatherApiRepository>();
            }
            return services;
        }
    }
}
