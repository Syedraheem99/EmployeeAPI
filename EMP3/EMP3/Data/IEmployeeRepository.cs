using System.Collections.Generic;
using EmployeeAPI.Models;

namespace EmployeeAPI.Data
{

    public interface IEmployeeRepository
    {
        List<Employee> GetAll();
    }

}