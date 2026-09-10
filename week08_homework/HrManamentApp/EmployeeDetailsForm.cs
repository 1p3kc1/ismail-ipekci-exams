using HrManamentApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrManamentApp
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        public void DisplayEmployee(Employee employee)
        {
            LblIdValue.Text = employee.EmployeeId.ToString();
            LblNameValue.Text = employee.FullName;
            LblEmailValue.Text = employee.Email;
            LblDepartmentValue.Text = $"{employee.DepartmentCode}(Departman Id: {employee.DepartmentId}";
            LblHireDateValue.Text = employee.HireDate.ToShortDateString();
            LblSalaryValue.Text = employee.Salary.ToString();
            LblIsActiveValue.Text = employee.IsActive ? "Evet" : "Hayır";

            DgvEmployeeLeaves.DataSource = null;
            DgvEmployeeLeaves.DataSource = Services.LeaveRequestService.GetByEmployee(employee.EmployeeId);
            ConfigureLeaveGrid();
        }

        private void ConfigureLeaveGrid()
        {
            SetLeaveColumnHeader(nameof(LeaveRequest.LeaveRequestId), "Talep No");
            SetLeaveColumnHeader(nameof(LeaveRequest.StartDate), "Başlangıç");
            SetLeaveColumnHeader(nameof(LeaveRequest.EndDate), "Bitiş");
            SetLeaveColumnHeader(nameof(LeaveRequest.LeaveType), "İzin Türü");
            SetLeaveColumnHeader(nameof(LeaveRequest.Status), "Durum");
            SetLeaveColumnHeader(nameof(LeaveRequest.DayCount), "Gün");

            var employeeIdColumn = DgvEmployeeLeaves.Columns[nameof(LeaveRequest.EmployeeId)];
            if (employeeIdColumn is not null) employeeIdColumn.Visible = false;
            var employeeNameColumn = DgvEmployeeLeaves.Columns[nameof(LeaveRequest.EmployeeName)];
            if (employeeNameColumn is not null) employeeNameColumn.Visible = false;
        }

        private void SetLeaveColumnHeader(string columnName, string headerText)
        {
            var column = DgvEmployeeLeaves.Columns[columnName];
            if (column is not null) column.HeaderText = headerText;
        }
    }
}
