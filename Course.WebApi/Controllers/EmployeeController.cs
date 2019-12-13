using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Course.WebApi.Repositories;

namespace Course.WebApi.Controllers
{
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(
				ILogger<EmployeeController> logger, EmployeeDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _context.Employees.ToArray();
        }

        [HttpPost]
        public IEnumerable<Employee> Post([FromBody]Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.Employees.ToArray();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Employee> Delete(int id)
        {
            var item = _context.Employees.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.Employees.Remove(item);
                _context.SaveChanges();
            }
            return _context.Employees.ToArray();
        }
    }
}