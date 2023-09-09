using System.Collections.Generic;
using EmployeeAPI.Models;

namespace EmployeeAPI.Services
{

    public interface IEmployeeService
    {
        List<Employee> GetAll();
    }

}