using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebApi.Controllers
{

    [Route("[controller]/[Action]")]
    public class EmployeeViewController : Controller
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeViewController(IEmployeeRepo repo)
        {
            _employeeRepo = repo;
        }
        public IActionResult List()
        {
            return View(_employeeRepo.Read());
        }

        public IActionResult Create()
        {
            Employee a = new Employee();
            a.name = "XDD";
            a.salary = 2000;
            _employeeRepo.Add(a);
            return RedirectToAction("List", "EmployeeView");
        }

        public IActionResult Delete(int id){
            _employeeRepo.Delete(id);
            return RedirectToAction("List", "EmployeeView");
        }

    //     public IActionResult Edit(int id)
    //     {
    //         var result = _employeeRepo.Read().FirstOrDefault(x => x.Id == id);
    //         if (result == null)
    //         {
    //             return RedirectToAction("List", "WeatherForecastView");
    //         }
    //         return View(result);
    //     }

    //     [HttpPost]
    //     public IActionResult Edit([FromForm]Employee employee, [FromQuery]int id)
    //     {
    //         _employeeRepo.Update(employee, id);
    //         return RedirectToAction("List", "WeatherForecastView");
    //     }
    }
}
