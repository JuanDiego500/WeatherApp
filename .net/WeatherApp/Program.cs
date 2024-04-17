using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherApp.Application;
using WeatherApp.Infrastructure;
using WeatherApp.Presentation;

namespace WeatherApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            IConfiguration configuration = builder.Build();

            var services = new ServiceCollection();

            services.AddSingleton<IConfiguration>(configuration);

            IConfigurationSection weatherApiSection = configuration.GetSection("WeatherApi");
            string weatherApiValue = weatherApiSection["VALUE"]!;

            if (weatherApiValue is "open")
            {
                services.AddHttpClient("open", (serviceProvider, httpClient) =>
                {
                    httpClient.BaseAddress = new Uri(configuration["OpenWeatherApi:API_URL"]!);
                });
            }
            else if (weatherApiValue == "accu")
            {
                services.AddHttpClient("open", (serviceProvider, httpClient) =>
                {
                    httpClient.BaseAddress = new Uri(configuration["AccuWeatherApi:API_URL"]!);
                });
            }
            else
            {
                throw new InvalidOperationException("Invalid Weather API specified in configuration.");
            }

            services.AddPresentation();
            services.AddInfrastructure(weatherApiValue);
            services.AddApplication();


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var weatherForm = serviceProvider.GetRequiredService<WeatherFrm>();
                weatherForm.ShowDialog();
            }
        }
    }
}