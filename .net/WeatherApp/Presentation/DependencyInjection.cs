using Microsoft.Extensions.DependencyInjection;

namespace WeatherApp.Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddScoped<WeatherFrm>();

        return services;
    }
}
