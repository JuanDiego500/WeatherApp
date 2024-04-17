import os
from os.path import join, dirname
from dotenv import load_dotenv


def get_openweather_api_url():
    dotenv_path = join(dirname(__file__), '.env')
    load_dotenv(dotenv_path)
    url = os.environ.get("OPENWEATHER_URL")
    return url

def get_opeanweather_api_key():
    dotenv_path = join(dirname(__file__), '.env')
    load_dotenv(dotenv_path)
    api_key = os.environ.get("OPENWEATHER_API_KEY")
    return api_key