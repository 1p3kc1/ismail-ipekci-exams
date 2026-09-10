using HrManamentApp.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace HrManamentApp.Services
{
    public static class DepartmentService
    {
        // Veritabanındaki Department tablosundan departmanları çekecek metot
        public static List<Department> GetAll()
        {
            var list = new List<Department>();
            using var connection = Database.OpenConnection();

            using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT
                    d.DepartmentId,
                    d.Code,
                    d.Name,
                    COUNT(e.EmployeeId) AS EmployeeCount
                FROM Department d
                    LEFT JOIN Employee e ON d.DepartmentId=e.DepartmentId
                GROUP BY d.DepartmentId, d.Code, d.Name
                ORDER BY d.Code
                """;
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Department
                {
                    DepartmentId = reader.GetInt32(0),
                    Code = reader.GetString(1),
                    Name = reader.GetString(2),
                    EmployeeCount = reader.GetInt32(3)
                });
            }
            return list;
        }

        public static void Insert(Department department)
        {
            var commandText = $"""
                INSERT INTO Department (Name, Code) VALUES
                ($name, $code)
                """;
            Database.Execute(commandText, command => BindDeparment(command, department));
        }

        public static void Update(Department department)
        {
            var commandText = """
                UPDATE Department
                SET Name = $name, Code = $code
                WHERE DepartmentId = $departmentId
                """;
            Database.Execute(commandText, command =>BindDeparment(command, department));
        }

        public static void Delete(int departmentId)
        {
            var commandText = "DELETE FROM Department WHERE DepartmentId=$departmentId";
            Database.Execute(commandText, command => command.Parameters.AddWithValue("$departmentId", departmentId));
        }

        private static void BindDeparment(SqliteCommand command, Department department)
        {
            command.Parameters.AddWithValue("$name", department.Name);
            command.Parameters.AddWithValue("$code", department.Code);
            if (department.DepartmentId > 0) command.Parameters.AddWithValue("$departmentId", department.DepartmentId);

        }
    }
}
