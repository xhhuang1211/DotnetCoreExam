using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Course.WebApi.Repositories;

namespace Course.WebApi.Services
{
    public class WeatherForecastRepo :IWeatherForecastRepo
    {
        private readonly WeatherDbContext _context;
        public WeatherForecastRepo(WeatherDbContext context)
        {
            _context = context;
        }

        public IEnumerable<WeatherForecast> Read()
        {
            return _context.WeatherForecasts.ToArray();
        }

        public IEnumerable<WeatherForecast> Update(WeatherForecast weatherForecast, int id)
        {
            var item = _context.WeatherForecasts.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Summary = weatherForecast.Summary;
                item.TemperatureC = weatherForecast.TemperatureC;
                item.Date = weatherForecast.Date;
                _context.SaveChanges();
            }
            return _context.WeatherForecasts.ToArray();
        }

        public IEnumerable<WeatherForecast> Delete(int id)
        {
            var item = _context.WeatherForecasts.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.WeatherForecasts.Remove(item);
                _context.SaveChanges();
            }
            return _context.WeatherForecasts.ToArray();
        }
    }
}
