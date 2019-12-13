using System.Collections.Generic;
using Course.WebApi.Models;

namespace Course.WebApi.Interfaces
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> Read();
        IEnumerable<Employee> Update(Employee employee, int id);

        IEnumerable<Employee> Add(Employee employee);

        IEnumerable<Employee> Delete(int id);
    }
}
