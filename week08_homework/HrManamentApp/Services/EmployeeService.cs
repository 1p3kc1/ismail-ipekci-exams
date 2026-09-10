using HrManamentApp.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManamentApp.Services
{
    public class EmployeeService
    {
        private static Employee ReadEmployee(SqliteDataReader reader)
        {
            return new Employee
            {
                EmployeeId = reader.GetInt32(0),
                FirstName = reader.GetString(1),
                LastName = reader.GetString(2),
                Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                DepartmentId = reader.GetInt32(4),
                DepartmentCode = reader.GetString(5),
                HireDate = Convert.ToDateTime(reader.GetString(6)),
                Salary = reader.GetDecimal(7),
                IsActive = Convert.ToBoolean(reader.GetInt32(8)),
                UpdatedAt = reader.IsDBNull(9) ? default : Convert.ToDateTime(reader.GetString(9))
            };
        }

        private const string EmployeeSelect =
            """
            SELECT 
            	e.EmployeeId,
            	e.FirstName,
            	e.LastName,
            	e.Email,
            	e.DepartmentId,
            	d.Code AS DepartmentCode,
            	e.HireDate,
            	e.Salary,
            	e.IsActive,
            	e.UpdatedAt
            FROM Employee e
            	JOIN Department d ON e.DepartmentId=d.DepartmentId
            """;
    
        public static List<Employee> GetAll()
        {
            var list = new List<Employee>();
            using var connection = Database.OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = EmployeeSelect+" ORDER BY e.EmployeeId;";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(ReadEmployee(reader));
            }
            return list;
        }

        public static List<Employee> GetAllByDepartment(int departmentId)
        {
            if (departmentId <= 0)
            {
                return GetAll();
            }
            var list = new List<Employee>();
            using var connection = Database.OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = EmployeeSelect + " " + """
                WHERE e.DepartmentId=$departmentId 
                ORDER BY e.EmployeeId;
                """;
            command.Parameters.AddWithValue("$departmentId", departmentId);
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(ReadEmployee(reader));
            }
            return list;
        }

        public static List<Department> GetDepartmens()
        {
            var list = new List<Department>();
            using var connection = Database.OpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT
                    d.DepartmentId,
                    d.Code,
                    d.Name
                FROM Department d
                ORDER BY d.Code
                """;
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Department
                {
                    DepartmentId = reader.GetInt32(0),
                    Code = reader.GetString(1),
                    Name = reader.GetString(2)
                });
            }
            return list;
        }

        public static void Insert(Employee employee)
        {
            var commandText = """
                INSERT INTO Employee (FirstName,LastName,Email,DepartmentId,HireDate,Salary,IsActive) VALUES
                ($firstName,$lastName,$email,$departmentId,$hireDate,$salary,$isActive)
                """;
            Database.Execute(commandText, command => BindEmployee(command, employee));
        }

        public static void Update(Employee employee)
        {
            var commandText = """
                UPDATE Employee
                SET
                    FirstName=$firstName,
                    LastName=$lastName,
                    Email=$email,
                    DepartmentId=$departmentId,
                    HireDate=$hireDate,
                    Salary=$salary,
                    IsActive=$isActive,
                    UpdatedAt=$updatedAt
                WHERE EmployeeId=$employeeId
                """;
            Database.Execute(commandText, command => BindEmployee(command, employee));
        }

        public static void Delete(int employeeId)
        {
            var commandText = "DELETE FROM Employee WHERE employeeId=$employeeId";
            Database.Execute(commandText, command => command.Parameters.AddWithValue("$employeeId", employeeId));
        }

        private static void BindEmployee(SqliteCommand command, Employee employee)
        {
            if (employee.EmployeeId > 0) command.Parameters.AddWithValue("$employeeId", employee.EmployeeId);
            command.Parameters.AddWithValue("$firstName", employee.FirstName);
            command.Parameters.AddWithValue("$lastName", employee.LastName);
            command.Parameters.AddWithValue("$email", employee.Email);
            command.Parameters.AddWithValue("$departmentId", employee.DepartmentId);
            command.Parameters.AddWithValue("$hireDate", employee.HireDate.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$salary", employee.Salary);
            command.Parameters.AddWithValue("$isActive", employee.IsActive ? 1 : 0);
            command.Parameters.AddWithValue("$updatedAt", employee.UpdatedAt.ToString("yyyy-MM-dd"));
        }
    }
}
