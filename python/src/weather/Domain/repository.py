from abc import ABC, abstractmethod
from typing import Optional, Iterable


from src.weather.Domain.model import Location, Units, WeatherInfo


class AbstractWeatherRepository(ABC):
    @abstractmethod
    def get_current(self, location: Location, units: Units = Units.METRIC) -> Optional[WeatherInfo]:
        raise NotImplementedError

    @abstractmethod
    def get_forecast(self, location: Location, units: Units = Units.METRIC, days: int = 1) -> Iterable[WeatherInfo]:
        raise NotImplementedError
