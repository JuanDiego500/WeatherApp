using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using WeatherApp.Domain.Shared;
using WeatherApp.Domain.Weather;

namespace WeatherApp.Infrastructure;

public class OpenWeatherApiRepository : IBaseWeatherApiRepository
{
    private readonly IHttpClientFactory _factory;
    private readonly IConfiguration _config;

    public OpenWeatherApiRepository(IHttpClientFactory factory, IConfiguration config)
    {
        _factory = factory;
        _config = config;
    }
    public async Task<WeatherInfo?> GetCurrentAsync(
        Location location,
        UnitsSystem units,
        CancellationToken cancellationToken = default)
    {
        var apikey = _config["OpenWeatherApi:API_KEY"];
        var client = _factory.CreateClient("open");

        var content = await client.GetStringAsync($"/data/2.5/weather?appid={apikey}&q={location.city}&units={units}");
        var formatedResponseMain = JObject.Parse(content);

        DateTime dateTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(formatedResponseMain["dt"])).UtcDateTime;
        var description = formatedResponseMain["weather"][0]["description"];
        var temp = new Temperature(Convert.ToDouble(formatedResponseMain["main"]["temp"]), units);

        return new WeatherInfo(location,
            dateTime,
            description.ToString(),
            temp);
    }

    public async Task<IEnumerable<WeatherInfo>> GetForecastAsync(
        Location location,
        UnitsSystem units,
        int days,
        CancellationToken cancellationToken = default)
    {
        var apikey = _config["OpenWeatherApi:API_KEY"];
        var client = _factory.CreateClient("open");
        //Unauthorized
        var content = await client.GetStringAsync($"/data/2.5/forecast/daily?appid={apikey}&q={location.city}&units={units}&cnt={days}");
        var formatedResponseMain = JObject.Parse(content);
        return Enumerable.Empty<WeatherInfo>();
    }
}