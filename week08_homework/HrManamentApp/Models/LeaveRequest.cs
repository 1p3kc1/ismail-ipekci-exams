using System;
using System.Collections.Generic;
using System.Text;

namespace HrManamentApp.Models
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string LeaveType { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string EmployeeName { get; set; } = string.Empty;
        public int DayCount => (EndDate.Date - StartDate.Date).Days + 1;
    }
}
