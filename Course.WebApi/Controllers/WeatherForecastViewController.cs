using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebApi.Controllers
{

    [Route("[controller]/[Action]")]
    public class WeatherForecastViewController : Controller
    {
        private readonly IEmployeeRepo _weatherForecastRepo;
        public WeatherForecastViewController(IEmployeeRepo weatherForecastRepo)
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
        public IActionResult Edit([FromForm]Employee employee, [FromQuery]int id)
        {
            _weatherForecastRepo.Update(employee, id);
            return RedirectToAction("List", "WeatherForecastView");
        }
    }
}
