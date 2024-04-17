# Technical Assessment - Weather Console

Implement a console-based weather viewer satisfying the scenarios below.

## Installation .NET

After cloning the repository replace the given api-keys in the appsettings.json file
with your own

```bash
git clone https://github.com/JuanDiego500/WeatherApp.git
cd .\WeatherApp\
cd .\.net\
cd .\WeatherApp\
dotnet run
```
## Scenarios

1. Get the current weather data for the given location.

Arguments:

* Location, in "{city},{country code}" format.

Options:

* --units: Units of measurement must be metric or imperial, metric by default.

## Usage:

```bash
$ myweatherapp current Irvine,US --units=imperial
IRVINE (US)
Jan 31, 2022
> Weather: Clear sky.
> Temperature: 48.72 ºF
```

2. Get the weather forecast for max 5 days for the given location.

Arguments:

* Location, in "{city},{country code}" format.

Options:

* --days: The number of days to retrieve forecast data for, 1 by default.
* --units: Units of measurement must be metric or imperial, metric by default.

## Usage:

```bash
$ myweatherapp forecast Santander,ES --days=3
SANTANDER (ES)
Feb 01, 2022
> Weather: Clouds.
> Temperature: 11.1 ºC
Feb 02, 2022
> Weather: Broken clouds.
> Temperature: 14 ºC
Feb 03, 2022
> Weather: Sunny.
> Temperature: 16 ºC
```

## Details
* Use the language you feel more comfortable.
* The application must use the console for input and output.
* The application must have a small help message (just as normal console commands).
* You can name your application as you wish (in the examples above is "myweatherapp").
* You must use at least one of the following APIs to get the weather data (registration and usage is free).
   * https://developer.accuweather.com/apis
   * https://openweathermap.org/api
* Don't use any framework/3rd party package, we want to see you code.
* requests package is allowed.
* Add instructions about how to run the application.

What we are looking for:

* How your code is organized.
* How you are storaging the API Credentials.
* How you are reflecting the domain in the code.
* We love clean code.
* We love tests, 95% of coverage will be appreciated but not required.
* Logging support will be appreciated but not required.