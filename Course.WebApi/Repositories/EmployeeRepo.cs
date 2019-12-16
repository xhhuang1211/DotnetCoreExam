using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Course.WebApi.Repositories;

namespace Course.WebApi.Services
{
    public class EmployeeRepo :IEmployeeRepo
    {
        private readonly CompanyDbContext _context;
        public EmployeeRepo(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Read()
        {
            return _context.Employees.ToArray();
        }

        public IEnumerable<Employee> Create(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.Employees.ToArray();
        }

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
