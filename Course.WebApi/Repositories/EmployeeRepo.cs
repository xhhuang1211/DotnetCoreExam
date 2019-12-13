using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Course.WebApi.Repositories;

namespace Course.WebApi.Services
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly CompanyDbContext _context;
        public EmployeeRepo(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Read()
        {
            return _context.EmployeeDbSet.ToArray();
        }

        public IEnumerable<Employee> Update(Employee employee, int id)
        {
            var item = _context.EmployeeDbSet.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                // item.Summary = weatherForecast.Summary;
                // item.TemperatureC = weatherForecast.TemperatureC;
                // item.Date = weatherForecast.Date;
                // _context.SaveChanges();
            }
            return _context.EmployeeDbSet.ToArray();
        }

        public IEnumerable<Employee> Add(Employee employee)
        {
            _context.EmployeeDbSet.Add(employee);
            _context.SaveChanges();
            return _context.EmployeeDbSet.ToArray();
        }

        public IEnumerable<Employee> Delete(int id)
        {
            var item = _context.EmployeeDbSet.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                 _context.EmployeeDbSet.Remove(item);
                 _context.SaveChanges();
            }
            return _context.EmployeeDbSet.ToArray();
        }
    }
}
