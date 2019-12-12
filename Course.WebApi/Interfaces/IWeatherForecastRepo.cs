using System.Collections.Generic;
using Course.WebApi.Models;

namespace Course.WebApi.Interfaces
{
    public interface IWeatherForecastRepo
    {
        IEnumerable<WeatherForecast> Read();
        IEnumerable<WeatherForecast> Update(WeatherForecast weatherForecast, int id);
    }
}
