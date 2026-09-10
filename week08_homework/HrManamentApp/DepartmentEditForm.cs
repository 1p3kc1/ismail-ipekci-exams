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
    public partial class DepartmentEditForm : Form
    {
        private readonly Department? _existing;
        public DepartmentEditForm(Department? existing = null)
        {
            _existing = existing;
            InitializeComponent();
            if (_existing is null)
            {
                Text = "Departman Ekle";
                LblTitle.Text = "Departman Ekle";
            }
            else
            {
                Text = "Departman Güncelle";
                LblTitle.Text = "Departman Güncelle";
                TxtDepartmentCode.Text = _existing.Code;
                TxtDepartmentName.Text = _existing.Name;
            }
        }

        private void BtnSaveDepartment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtDepartmentCode.Text) || string.IsNullOrWhiteSpace(TxtDepartmentName.Text))
            {
                MessageBox.Show("Ad ve kod zorunludur!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var department = new Department
            {
                DepartmentId = _existing is null ? 0 : _existing.DepartmentId,
                Code = TxtDepartmentCode.Text,
                Name = TxtDepartmentName.Text
            };

            try
            {
                if (_existing is null)
                {
                    DepartmentService.Insert(department);
                }
                else
                {
                    DepartmentService.Update(department);
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnCancelDepartment_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
