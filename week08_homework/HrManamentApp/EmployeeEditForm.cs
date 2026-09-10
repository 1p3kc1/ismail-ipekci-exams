using HrManamentApp.Models;
using HrManamentApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrManamentApp
{
    public partial class EmployeeEditForm : Form
    {
        private readonly Employee? _existing;
        public EmployeeEditForm(Employee? existing = null)
        {
            _existing = existing;
            InitializeComponent();
            LoadDepartments();
            if (_existing is null)
            {
                Text = "Personel Ekle";
                LblTitle.Text = "Personel Ekle";
                ChkIsActive.Checked = true;
                DtpHireDate.Value = DateTime.Today;
            }
            else
            {
                Text = "Personel Güncelle";
                LblTitle.Text = "Personel Güncelle";
                TxtFirstName.Text = _existing.FirstName;
                TxtLastName.Text = _existing.LastName;
                TxtEmail.Text = _existing.Email;
                CmbDepartment.SelectedValue = _existing.DepartmentId;
                DtpHireDate.Value = _existing.HireDate;
                NudSalary.Value = _existing.Salary;
                ChkIsActive.Checked = _existing.IsActive;
            }
        }

        private void LoadDepartments()
        {
            CmbDepartment.DisplayMember = nameof(Department.Name);// "Name"
            CmbDepartment.ValueMember = nameof(Department.DepartmentId);
            CmbDepartment.DataSource = DepartmentService.GetAll();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtFirstName.Text) || string.IsNullOrWhiteSpace(TxtLastName.Text))
            {
                MessageBox.Show("Ad ve Soyad zorunludur.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var employee = new Employee
            {
                EmployeeId = _existing?.EmployeeId ?? 0,
                FirstName = TxtFirstName.Text.Trim(),
                LastName = TxtLastName.Text.Trim(),
                Email = TxtEmail.Text.Trim(),
                DepartmentId = Convert.ToInt32(CmbDepartment.SelectedValue),
                HireDate = DtpHireDate.Value,
                Salary = NudSalary.Value,
                IsActive = ChkIsActive.Checked,
                UpdatedAt = _existing is null ? default : DateTime.Today
            };

            try
            {
                if (_existing is null)
                {
                    EmployeeService.Insert(employee);
                }
                else
                {
                    EmployeeService.Update(employee);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
