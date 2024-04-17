from typing import Optional, Iterable

from src.weather.Domain.model import Location, Units, WeatherInfo
from src.weather.Domain.repository import AbstractWeatherRepository


class GetCurrentWeather:
    def __init__(self, weather_api: AbstractWeatherRepository):
        self.weather_api = weather_api

    def get_current(self, location: Location, units: Units = Units.METRIC) -> Optional[WeatherInfo]:
        weather_info = self.weather_api.get_current(location, units)
        if weather_info is None:
            return None
        return weather_info


class GetForecastWeather:
    def __init__(self, weather_api: AbstractWeatherRepository):
        self.weather_api = weather_api

    def get_forecast(self, location: Location, units: Units = Units.METRIC, days: int = 1) -> Iterable[WeatherInfo]:
        return self.weather_api.get_forecast(location, units, days)
