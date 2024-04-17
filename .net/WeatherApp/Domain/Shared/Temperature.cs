namespace WeatherApp.Domain.Shared;

public record Temperature
{
    private readonly double _kelvin;
    private readonly UnitsSystem _unitSystem;

    private const string CelsiusSymbol = "°C";
    private const string FahrenheitSymbol = "°F";

    public Temperature(double kelvin, UnitsSystem unitSystem)
    {
        if (kelvin < 0)
            throw new InvalidOperationException("Temperature in kelvin cannot be negative");

        this._kelvin = kelvin;
        this._unitSystem = unitSystem;
    }

    public double Kelvin => _kelvin;

    public double Fahrenheit => (_kelvin - 273.15) * 9 / 5 + 32;

    public double Celsius => _kelvin - 273.15;

    public override string ToString()
    {
        return _unitSystem == UnitsSystem.Imperial
            ? $"{Fahrenheit:0.##} {FahrenheitSymbol}"
            : $"{Celsius:0.##} {CelsiusSymbol}";
    }
}