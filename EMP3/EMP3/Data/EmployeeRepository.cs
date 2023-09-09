using Dapper;
using EmployeeAPI.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace EmployeeAPI.Data
{

    public class EmployeeRepository : IEmployeeRepository
    {

        private string connectionString = $"Server=localhost; Database=EmployeeDB; User Id=SA; Password=6618lkp@;TrustServerCertificate=true";

        public List<Employee> GetAll()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Employee>("SELECT * FROM Employees").ToList();
            }
        }

    }

}