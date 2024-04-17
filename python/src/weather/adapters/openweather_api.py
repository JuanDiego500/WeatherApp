from datetime import datetime
from typing import Optional, Iterable

import requests

from src.weather.Domain.model import WeatherInfo, Location, Units, Temperature
from src.weather.Domain.repository import AbstractWeatherRepository


class OpenWeatherApiRepository(AbstractWeatherRepository):
    def __init__(self, api_url: str, api_key: str):
        self.api_url = api_url
        self.api_key = api_key

    def get_current(self, location: Location, units: Units = Units.METRIC) -> Optional[WeatherInfo]:
        full_url = self.api_url + '/data/2.5/weather?' + 'appid=' + self.api_key + '&q=' + location.city
        response = requests.get(full_url)

        content = response.json()

        return WeatherInfo(
            location=location,
            date=datetime.fromtimestamp(content['dt']),
            description=content['weather'][0]['main'],
            temperature=Temperature(
                kelvin=content['main']['temp'],
                units=Units.METRIC
            ),
        )

    def get_forecast(self, location: Location, units: Units = Units.METRIC, days: int = 1) -> Iterable[WeatherInfo]:
        response = requests.get(f'{self.api_url}/data/2.5/forecast/daily', params={
            'appid': self.api_key,
            'q': location,
            'units': 'metric',
            'cnt': days,
        })

        content = response.json()

        weather = []
        for data in content.get('list', []):
            weather.append(WeatherInfo(
                location=location,
                date=datetime.fromtimestamp(data['dt']),
                description=data['weather'][0]['main'],
                temperature=Temperature(
                    kelvin=data['temp']['day'],
                    units=Units.METRIC
                ),
            ))

        return weather
