using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebApi.Controllers
{

    [Route("employ/[Action]")]
    public class EmployViewController : Controller
    {
        private readonly IEmployRepo _repo;
        public EmployViewController(IEmployRepo repo)
        {
            _repo = repo;
        }
        public IActionResult List()
        {
            return View(_repo.Read());
        }
        
        
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Insert([FromForm]Employ employ)
        {
            _repo.Insert(employ);
            return Ok();
        }

//        public IActionResult Edit(int id)
//        {
//            var result = _weatherForecastRepo.Read().FirstOrDefault(x => x.Id == id);
//            if (result == null)
//            {
//                return RedirectToAction("List", "WeatherForecastView");
//            }
//            return View(result);
//        }
//
//        [HttpPost]
//        public IActionResult Edit([FromForm]Employ employ, [FromQuery]int id)
//        {
//            _weatherForecastRepo.Update(employ, id);
//            return RedirectToAction("List", "WeatherForecastView");
//        }
    }
}
