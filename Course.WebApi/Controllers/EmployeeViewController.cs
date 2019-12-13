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
        public EmployeeViewController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }
        public IActionResult List()
        {
            return View(_employeeRepo.Read());
        }

        // public IActionResult Edit(int id)
        // {
        //     var result = _employeeRepo.Read().FirstOrDefault(x => x.Id == id);
        //     if (result == null)
        //     {
        //         return RedirectToAction("List", "EmployeeView");
        //     }
        //     return View(result);
        // }
        
        [HttpPost]
        public IActionResult Create([FromForm]Employee employee)
        {
            var result = _employeeRepo.Create(employee);
            if (result == null)
            {
                return RedirectToAction("Create", "EmployeeView");
            }

            return View(result);
        }

        [HttpPost]
        public IActionResult Edit([FromForm]Employee employee, [FromQuery]int id)
        {
            _employeeRepo.Update(employee, id);
            return RedirectToAction("List", "EmployeeView");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromQuery]int id)
        {
            _employeeRepo.Delete(id);
            return RedirectToAction("List", "EmployeeView");
        }
        
    }
}