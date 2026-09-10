using HrManamentApp.Models;
using Microsoft.Data.Sqlite;

namespace HrManamentApp.Services;

public static class LeaveRequestService
{
    public static List<LeaveRequest> GetAll(string? status = null)
    {
        var requests = new List<LeaveRequest>();
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT lr.LeaveRequestId, lr.EmployeeId, lr.StartDate, lr.EndDate, lr.LeaveType, lr.Status,
                   e.FirstName || ' ' || e.LastName AS EmployeeName
            FROM LeaveRequest lr
            JOIN Employee e ON e.EmployeeId = lr.EmployeeId
            WHERE ($status = '' OR lr.Status = $status)
            ORDER BY lr.StartDate DESC, lr.LeaveRequestId DESC;
            """;
        command.Parameters.AddWithValue("$status", status ?? string.Empty);

        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            requests.Add(new LeaveRequest
            {
                LeaveRequestId = reader.GetInt32(0),
                EmployeeId = reader.GetInt32(1),
                StartDate = DateTime.Parse(reader.GetString(2)),
                EndDate = DateTime.Parse(reader.GetString(3)),
                LeaveType = reader.GetString(4),
                Status = reader.GetString(5),
                EmployeeName = reader.GetString(6)
            });
        }
        return requests;
    }

    public static List<LeaveRequest> GetByEmployee(int employeeId)
    {
        var requests = new List<LeaveRequest>();
        using var connection = Database.OpenConnection();
        using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT lr.LeaveRequestId, lr.EmployeeId, lr.StartDate, lr.EndDate, lr.LeaveType, lr.Status,
                   e.FirstName || ' ' || e.LastName AS EmployeeName
            FROM LeaveRequest lr
            JOIN Employee e ON e.EmployeeId = lr.EmployeeId
            WHERE lr.EmployeeId = $employeeId
            ORDER BY lr.StartDate DESC, lr.LeaveRequestId DESC;
            """;
        command.Parameters.AddWithValue("$employeeId", employeeId);
        using var reader = command.ExecuteReader();
        while (reader.Read())
        {
            requests.Add(new LeaveRequest
            {
                LeaveRequestId = reader.GetInt32(0),
                EmployeeId = reader.GetInt32(1),
                StartDate = DateTime.Parse(reader.GetString(2)),
                EndDate = DateTime.Parse(reader.GetString(3)),
                LeaveType = reader.GetString(4),
                Status = reader.GetString(5),
                EmployeeName = reader.GetString(6)
            });
        }
        return requests;
    }

    public static void Insert(LeaveRequest request) =>
        Database.Execute("""
            INSERT INTO LeaveRequest (EmployeeId, StartDate, EndDate, LeaveType, Status)
            VALUES ($employeeId, $startDate, $endDate, $leaveType, $status);
            """, command => Bind(command, request));

    public static void Update(LeaveRequest request) =>
        Database.Execute("""
            UPDATE LeaveRequest
            SET EmployeeId = $employeeId, StartDate = $startDate, EndDate = $endDate,
                LeaveType = $leaveType, Status = $status
            WHERE LeaveRequestId = $leaveRequestId;
            """, command => Bind(command, request));

    public static void Delete(int leaveRequestId) =>
        Database.Execute("DELETE FROM LeaveRequest WHERE LeaveRequestId = $leaveRequestId;",
            command => command.Parameters.AddWithValue("$leaveRequestId", leaveRequestId));

    private static void Bind(SqliteCommand command, LeaveRequest request)
    {
        if (request.LeaveRequestId > 0)
            command.Parameters.AddWithValue("$leaveRequestId", request.LeaveRequestId);
        command.Parameters.AddWithValue("$employeeId", request.EmployeeId);
        command.Parameters.AddWithValue("$startDate", request.StartDate.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("$endDate", request.EndDate.ToString("yyyy-MM-dd"));
        command.Parameters.AddWithValue("$leaveType", request.LeaveType);
        command.Parameters.AddWithValue("$status", request.Status);
    }
}
