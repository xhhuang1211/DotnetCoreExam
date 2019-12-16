using System.Collections.Generic;
using Course.WebApi.Models;

namespace Course.WebApi.Interfaces
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> Read();
        IEnumerable<Employee> Create(Employee employee);
    }
}
