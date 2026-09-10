using System;
using System.Collections.Generic;
using System.Text;

namespace HrManamentApp.Models
{
    public class Department
    {
        // Bu classın amacı, veritabanımızdaki Department tablosunu temsil etmektir. Bu nedenle, bu classın özellikleri, veritabanındaki Department tablosunun sütunlarıyla eşleşmelidir.
        public int DepartmentId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; }= string.Empty;
        public int EmployeeCount { get; set; }
    }
}
