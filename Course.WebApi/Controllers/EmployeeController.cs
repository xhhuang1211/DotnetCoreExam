using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Course.WebApi.Repositories;

namespace Course.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeController(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employeeRepo.Read();
        }

        [HttpPost]
        public IEnumerable<Employee> Post([FromBody]Employee employee)
        {
            return _employeeRepo.Create(employee);
        }

        [HttpPut("{id}")]
        public IEnumerable<Employee> Put([FromBody]Employee employee, [FromRoute]int id)
        {
            return _employeeRepo.Update(employee, id);
        }

        [HttpDelete("{id}")]
        public IEnumerable<Employee> Delete(int id)
        {
            return _employeeRepo.Delete(id);
        }
    }
}
