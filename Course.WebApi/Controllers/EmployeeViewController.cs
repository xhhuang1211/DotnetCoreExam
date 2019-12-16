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

        public IActionResult Create(int id)
        {
            var result = _employeeRepo.Read().FirstOrDefault(x => x.Id == id);
            if (result == null)
            {
                return RedirectToAction("List", "EmployeeView");
            }
            return View(result);
        }

        [HttpPost]
        public IActionResult Create([FromForm]Employee employee, [FromQuery]int id)
        {
            _employeeRepo.Create(employee);
            return RedirectToAction("List", "EmployeeView");
        }
    }
}
