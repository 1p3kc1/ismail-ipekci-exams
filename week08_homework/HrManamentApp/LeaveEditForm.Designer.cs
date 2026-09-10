namespace HrManamentApp;

partial class LeaveEditForm
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components is not null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        LblTitle = new Label();
        LblEmployee = new Label(); CmbEmployee = new ComboBox();
        LblStartDate = new Label(); DtpStartDate = new DateTimePicker();
        LblEndDate = new Label(); DtpEndDate = new DateTimePicker();
        LblLeaveType = new Label(); CmbLeaveType = new ComboBox();
        LblStatus = new Label(); CmbStatus = new ComboBox();
        BtnSave = new Button(); BtnCancel = new Button();
        SuspendLayout();
        LblTitle.Dock = DockStyle.Top; LblTitle.Height = 70; LblTitle.BackColor = Color.Moccasin; LblTitle.ForeColor = Color.DarkBlue;
        LblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold); LblTitle.TextAlign = ContentAlignment.MiddleCenter;
        LblEmployee.Text = "Personel:"; LblEmployee.Location = new Point(35, 100); LblEmployee.AutoSize = true;
        CmbEmployee.Location = new Point(155, 96); CmbEmployee.Size = new Size(230, 28); CmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        LblStartDate.Text = "Başlangıç:"; LblStartDate.Location = new Point(35, 145); LblStartDate.AutoSize = true;
        DtpStartDate.Location = new Point(155, 141); DtpStartDate.Size = new Size(230, 27); DtpStartDate.Format = DateTimePickerFormat.Short;
        LblEndDate.Text = "Bitiş:"; LblEndDate.Location = new Point(35, 190); LblEndDate.AutoSize = true;
        DtpEndDate.Location = new Point(155, 186); DtpEndDate.Size = new Size(230, 27); DtpEndDate.Format = DateTimePickerFormat.Short;
        LblLeaveType.Text = "İzin türü:"; LblLeaveType.Location = new Point(35, 235); LblLeaveType.AutoSize = true;
        CmbLeaveType.Location = new Point(155, 231); CmbLeaveType.Size = new Size(230, 28); CmbLeaveType.DropDownStyle = ComboBoxStyle.DropDownList;
        LblStatus.Text = "Durum:"; LblStatus.Location = new Point(35, 280); LblStatus.AutoSize = true;
        CmbStatus.Location = new Point(155, 276); CmbStatus.Size = new Size(230, 28); CmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        BtnSave.Text = "Kaydet"; BtnSave.Location = new Point(190, 330); BtnSave.Size = new Size(90, 30); BtnSave.Click += BtnSave_Click;
        BtnCancel.Text = "İptal"; BtnCancel.Location = new Point(295, 330); BtnCancel.Size = new Size(90, 30); BtnCancel.Click += BtnCancel_Click;
        AcceptButton = BtnSave; CancelButton = BtnCancel; ClientSize = new Size(430, 385); Controls.AddRange(new Control[] { LblTitle, LblEmployee, CmbEmployee, LblStartDate, DtpStartDate, LblEndDate, DtpEndDate, LblLeaveType, CmbLeaveType, LblStatus, CmbStatus, BtnSave, BtnCancel });
        FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false; StartPosition = FormStartPosition.CenterParent; Text = "İzin Talebi";
        ResumeLayout(false); PerformLayout();
    }
    private Label LblTitle, LblEmployee, LblStartDate, LblEndDate, LblLeaveType, LblStatus;
    private ComboBox CmbEmployee, CmbLeaveType, CmbStatus;
    private DateTimePicker DtpStartDate, DtpEndDate;
    private Button BtnSave, BtnCancel;
}
