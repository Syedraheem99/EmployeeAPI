using EmployeeAPI.Data;
using EmployeeAPI.Models;
using System.Collections.Generic;

namespace EmployeeAPI.Services
{

    public class EmployeeService : IEmployeeService
    {

        private IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public List<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

    }

}