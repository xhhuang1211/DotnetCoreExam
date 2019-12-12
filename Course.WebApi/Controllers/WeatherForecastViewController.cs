using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebApi.Controllers
{

    [Route("[controller]/[Action]")]
    public class WeatherForecastViewController : Controller
    {
        private readonly IWeatherForecastRepo _weatherForecastRepo;
        public WeatherForecastViewController(IWeatherForecastRepo weatherForecastRepo)
        {
            _weatherForecastRepo = weatherForecastRepo;
        }
        public IActionResult List()
        {
            return View(_weatherForecastRepo.Read());
        }

        public IActionResult Edit(int id)
        {
            var result = _weatherForecastRepo.Read().FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return RedirectToAction("List", "WeatherForecastView");
            }
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit([FromForm]WeatherForecast weatherForecast, [FromQuery]int id)
        {
            _weatherForecastRepo.Update(weatherForecast, id);
            return RedirectToAction("List", "WeatherForecastView");
        }
    }
}
