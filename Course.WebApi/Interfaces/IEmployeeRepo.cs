using System.Collections.Generic;
using Course.WebApi.Models;

namespace Course.WebApi.Interfaces
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> Read();
        IEnumerable<Employee> Create(Employee employee);

        IEnumerable<Employee> Update(Employee employee, int id);
        
        IEnumerable<Employee> Delete(int id);

        IEnumerable<Employee> Edit(int id);
    }
}