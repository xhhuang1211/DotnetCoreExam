using Microsoft.AspNetCore.Mvc;
using Course.WebApi.Repositories;
using Course.WebApi.Interfaces;
using System.Linq;
using Course.WebApi.Models;

namespace Course.WebApi.Controllers
{

    [Route("[controller]/[Action]")]
    public class EmployeeViewController : Controller
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeViewController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public IActionResult List()
        {
            return View(_employeeRepo.Read());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm]Employee employee)
        {
            _employeeRepo.Create(employee);
            return RedirectToAction("List", "EmployeeView");
        }

        public IActionResult Edit(int id)
        {
            var result = _employeeRepo.Read().FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return RedirectToAction("List", "EmployeeView");
            }
            return View(result);
        }

        [HttpPost]
        public IActionResult Edit([FromForm]Employee employee, [FromQuery]int id)
        {
            _employeeRepo.Update(employee, id);
            return RedirectToAction("List", "EmployeeView");
        }

        public IActionResult Delete([FromQuery]int id)
        {
            _employeeRepo.Delete(id);
            return RedirectToAction("List", "EmployeeView");
        }
    }
}
