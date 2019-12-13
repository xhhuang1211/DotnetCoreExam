using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Course.WebApi.Controllers
{

  [Route("[controller]/[Action]")]
  public class CompanyViewController : Controller
  {
    private readonly IEmployeeRepo _employeeRepo;
    public CompanyViewController(IEmployeeRepo employeeRepo)
    {
      _employeeRepo = employeeRepo;
    }
    public IActionResult List()
    {
      return View(_employeeRepo.Read());
    }

    public IActionResult Edit(int id)
    {
      var result = _employeeRepo.Read().FirstOrDefault(x => x.Id == id);
      if (result == null)
      {
        return RedirectToAction("List", "CompanyView");
      }
      return View(result);
    }

    [HttpPost]
    public IActionResult Edit([FromForm]Employee employee, [FromQuery]int id)
    {
      _employeeRepo.Update(employee, id);
      return RedirectToAction("List", "CompanyView");
    }

    public IActionResult Delete(int id)
    {
      _employeeRepo.Delete(id);
      return RedirectToAction("List", "CompanyView");
    }
  }
}
