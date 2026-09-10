using HrManamentApp.Models;
using HrManamentApp.Services;

namespace HrManamentApp
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDetailsEmployee_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedEmployee(out var selected))
            {
                return;
            }
            EmployeeDetailsForm employeeDetailsForm = new();
            employeeDetailsForm.DisplayEmployee(selected);
            employeeDetailsForm.Show();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            BindDepartmentFilter();
            RefreshEmployees();
            RefreshDepartments();
            BindLeaveStatusFilter();
            RefreshLeaves();

        }

        private void BindDepartmentFilter()
        {
            CmbDepartment.DataSource = EmployeeService.GetDepartmens();
            CmbDepartment.DisplayMember = nameof(Department.Name);
            CmbDepartment.ValueMember = nameof(Department.DepartmentId);
            CmbDepartment.SelectedValue = string.Empty;
        }

        private void RefreshEmployees()
        {
            int departmentId = CmbDepartment.SelectedValue is null or DBNull ? 0 : Convert.ToInt32(CmbDepartment.SelectedValue);
            DgvEmployees.DataSource = null;
            DgvEmployees.DataSource = EmployeeService.GetAllByDepartment(departmentId);
            LblEmployeeCount.Text = $"Kayıt: {DgvEmployees.Rows.Count}";
        }

        private void RefreshDepartments()
        {
            DgvDepartments.DataSource = null;
            DgvDepartments.DataSource = DepartmentService.GetAll();
            LblDepartmentCount.Text = $"Kayıt: {DgvDepartments.Rows.Count}";
        }

        private void BindLeaveStatusFilter()
        {
            CmbLeaveStatus.Items.Clear();
            CmbLeaveStatus.Items.AddRange(new object[] { "Tümü", "Beklemede", "Onaylandı", "Reddedildi" });
            CmbLeaveStatus.SelectedIndex = 0;
        }

        private void RefreshLeaves()
        {
            var status = CmbLeaveStatus.SelectedItem?.ToString();
            DgvLeaves.DataSource = null;
            DgvLeaves.DataSource = LeaveRequestService.GetAll(status == "Tümü" ? null : status);
            SetColumnHeader(nameof(LeaveRequest.LeaveRequestId), "Talep No");
            SetColumnHeader(nameof(LeaveRequest.EmployeeName), "Personel");
            SetColumnHeader(nameof(LeaveRequest.StartDate), "Başlangıç");
            SetColumnHeader(nameof(LeaveRequest.EndDate), "Bitiş");
            SetColumnHeader(nameof(LeaveRequest.LeaveType), "İzin Türü");
            SetColumnHeader(nameof(LeaveRequest.Status), "Durum");
            SetColumnHeader(nameof(LeaveRequest.DayCount), "Gün");
            var employeeIdColumn = DgvLeaves.Columns[nameof(LeaveRequest.EmployeeId)];
            if (employeeIdColumn is not null) employeeIdColumn.Visible = false;
            LblLeaveCount.Text = $"Kayıt: {DgvLeaves.Rows.Count}";
        }

        private void SetColumnHeader(string columnName, string headerText)
        {
            var column = DgvLeaves.Columns[columnName];
            if (column is not null) column.HeaderText = headerText;
        }

        private void BtnFilterLeaves_Click(object sender, EventArgs e) => RefreshLeaves();

        private void BtnAddLeave_Click(object sender, EventArgs e)
        {
            using var form = new LeaveEditForm();
            if (form.ShowDialog(this) == DialogResult.OK) RefreshLeaves();
        }

        private void BtnEditLeave_Click(object sender, EventArgs e)
        {
            if (!TryGetSelected(DgvLeaves, "Lütfen listeden bir izin talebi seçin.", out LeaveRequest selected)) return;
            using var form = new LeaveEditForm(selected);
            if (form.ShowDialog(this) == DialogResult.OK) RefreshLeaves();
        }

        private void BtnDeleteLeave_Click(object sender, EventArgs e)
        {
            if (!TryGetSelected(DgvLeaves, "Lütfen listeden bir izin talebi seçin.", out LeaveRequest selected)) return;
            if (!ConfirmDelete($"{selected.EmployeeName} - {selected.LeaveType} izin talebi")) return;
            try
            {
                LeaveRequestService.Delete(selected.LeaveRequestId);
                RefreshLeaves();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnFilterEmployees_Click(object sender, EventArgs e)
        {
            RefreshEmployees();
        }



        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            using var form = new EmployeeEditForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshEmployees();
            }
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedEmployee(out var selected))
            {
                return;
            }
            using var form = new EmployeeEditForm(selected);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshEmployees();
            }

        }

        private void BtnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedEmployee(out var selected))
            {
                return;
            }
            if (!ConfirmDelete(selected.FullName))
            {
                return;
            }
            try
            {
                EmployeeService.Delete(selected.EmployeeId);
                RefreshEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmDelete(string caption)
        {
            var answer = MessageBox.Show($"{caption} silinsin mi?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return answer == DialogResult.Yes;
        }

        private void BtnAddDepartment_Click(object sender, EventArgs e)
        {
            using var form = new DepartmentEditForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDepartments();
            }
        }

        private void BtnEditDepartment_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedDepartment(out var selected))
            {
                return;
            }
            using var form = new DepartmentEditForm(selected);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                RefreshDepartments();
            }
        }


        private bool TryGetSelectedEmployee(out Employee selected)
        {
            return TryGetSelected(DgvEmployees, "Lütfen listeden bir personel seçin.", out selected);
        }

        private bool TryGetSelectedDepartment(out Department selected)
        {
            return TryGetSelected(DgvDepartments, "Lütfen listeden bir departman seçin.", out selected);
        }

        private void BtnDeleteDepartment_Click(object sender, EventArgs e)
        {
            if(!TryGetSelectedDepartment(out var selected))
            {
                return;
            }
            if(!ConfirmDelete($"{selected.Name} silinsin mi?"))
            {
                return;
            }
            try
            {
                DepartmentService.Delete(selected.DepartmentId);
                RefreshDepartments();
            }
            catch (Exception)
            {
                MessageBox.Show("Bu departmanda çalışanlar var. Öncelikle çalışanları başka bir departmana transfer edin ya da silin.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool TryGetSelected<T>(DataGridView grid, string warning, out T selected) where T : class
        {
            if (grid.CurrentRow?.DataBoundItem is T item)
            {
                selected = item;
                return true;
            }
            MessageBox.Show(warning, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            selected = null!;
            return false;
        }
    }
}
