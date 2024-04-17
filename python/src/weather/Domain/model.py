from dataclasses import dataclass
from datetime import datetime
from enum import StrEnum


@dataclass(frozen=True)
class Location:
    city: str
    country_code: str

    def __str__(self) -> str:
        return f"{self.city}, ({self.country_code})"


class Units(StrEnum):
    IMPERIAL = 'imperial'
    METRIC = 'metric'


class Temperature:
    def __init__(self, kelvin: float, units: Units):
        self.kelvin = kelvin
        self.units = units

    def _to_celsius(self) -> float:
        return self.kelvin - 273.15

    def _to_fahrenheit(self) -> float:
        return (self.kelvin - 273.15) * 9 / 5 + 32

    def __str__(self) -> str:
        if self.units == Units.METRIC:
            return f"{self._to_celsius()} °C"
        elif self.units == Units.IMPERIAL:
            return f"{self._to_fahrenheit()} °F"
        else:
            raise ValueError("Invalid unit system")


@dataclass(frozen=True)
class WeatherInfo:
    location: Location
    date: datetime
    description: str
    temperature: Temperature
