namespace WeatherApp.Domain.Shared;

public record UnitsSystem
{
    public static readonly UnitsSystem Imperial = new("imperial");
    public static readonly UnitsSystem Metric = new("metric");
    private UnitsSystem(string system) => System = system;

    public string System { get; init; }

    public static UnitsSystem FromSystem(string system)
    {
        return All.FirstOrDefault(u => u.System == system) ??
               throw new ApplicationException("The units system is invalid");
    }

    public static readonly IReadOnlyCollection<UnitsSystem> All = new[]
    {
        Imperial,
        Metric
    };
}