using HrManamentApp.Models;
using HrManamentApp.Services;

namespace HrManamentApp;

public partial class LeaveEditForm : Form
{
    private readonly LeaveRequest? _existing;

    public LeaveEditForm(LeaveRequest? existing = null)
    {
        _existing = existing;
        InitializeComponent();
        BindEmployees();
        CmbLeaveType.Items.AddRange(new object[] { "Yıllık İzin", "Hastalık İzni", "Mazeret İzni", "Ücretsiz İzin" });
        CmbStatus.Items.AddRange(new object[] { "Beklemede", "Onaylandı", "Reddedildi" });

        if (existing is null)
        {
            Text = "İzin Talebi Ekle";
            LblTitle.Text = Text;
            DtpStartDate.Value = DateTime.Today;
            DtpEndDate.Value = DateTime.Today;
            CmbLeaveType.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
        }
        else
        {
            Text = "İzin Talebi Düzenle";
            LblTitle.Text = Text;
            CmbEmployee.SelectedValue = existing.EmployeeId;
            DtpStartDate.Value = existing.StartDate;
            DtpEndDate.Value = existing.EndDate;
            CmbLeaveType.SelectedItem = existing.LeaveType;
            CmbStatus.SelectedItem = existing.Status;
        }
    }

    private void BindEmployees()
    {
        var employees = EmployeeService.GetAll();
        CmbEmployee.DisplayMember = nameof(Employee.FullName);
        CmbEmployee.ValueMember = nameof(Employee.EmployeeId);
        CmbEmployee.DataSource = employees;

        if (employees.Count == 0)
        {
            BtnSave.Enabled = false;
            MessageBox.Show(
                "İzin talebi oluşturabilmek için önce en az bir personel eklemelisiniz.",
                "Personel bulunamadı",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }

    private void BtnSave_Click(object sender, EventArgs e)
    {
        if (CmbEmployee.SelectedValue is null || CmbEmployee.SelectedValue is DBNull ||
            CmbLeaveType.SelectedItem is null || CmbStatus.SelectedItem is null)
        {
            MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (DtpEndDate.Value.Date < DtpStartDate.Value.Date)
        {
            MessageBox.Show("Bitiş tarihi başlangıç tarihinden önce olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var request = new LeaveRequest
        {
            LeaveRequestId = _existing?.LeaveRequestId ?? 0,
            EmployeeId = Convert.ToInt32(CmbEmployee.SelectedValue),
            StartDate = DtpStartDate.Value.Date,
            EndDate = DtpEndDate.Value.Date,
            LeaveType = CmbLeaveType.SelectedItem.ToString()!,
            Status = CmbStatus.SelectedItem.ToString()!
        };
        try
        {
            if (_existing is null) LeaveRequestService.Insert(request);
            else LeaveRequestService.Update(request);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BtnCancel_Click(object sender, EventArgs e) => Close();
}
