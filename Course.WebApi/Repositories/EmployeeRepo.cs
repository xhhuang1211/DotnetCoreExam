using System.Collections.Generic;
using System.Linq;
using Course.WebApi.Interfaces;
using Course.WebApi.Models;
using Course.WebApi.Repositories;

namespace Course.WebApi.Services
{
    public class EmployeeRepo :IEmployeeRepo
    {
        private readonly EmployeeDbContext _context;
        public EmployeeRepo(EmployeeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee> Read()
        {
            return _context.Employee.ToArray();
        }

        public IEnumerable<Employee> Update(Employee employee, int id)
        {
            var item = _context.Employee.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.Name = employee.Name;
                item.Salary = employee.Salary;
                _context.SaveChanges();
            }
            return _context.Employee.ToArray();
        }

        public IEnumerable<Employee> Delete(int id)
        {
            var item = _context.Employee.SingleOrDefault(x => x.Id == id);
            if (item != null)
            {
                _context.Employee.Remove(item);
                _context.SaveChanges();
            }
            return _context.Employee.ToArray();
        }
    }
}
