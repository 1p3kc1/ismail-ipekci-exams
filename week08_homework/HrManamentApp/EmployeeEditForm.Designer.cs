namespace HrManamentApp
{
    partial class EmployeeEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtFirstName = new TextBox();
            TxtLastName = new TextBox();
            TxtEmail = new TextBox();
            CmbDepartment = new ComboBox();
            DtpHireDate = new DateTimePicker();
            ChkIsActive = new CheckBox();
            NudSalary = new NumericUpDown();
            LblTitle = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)NudSalary).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 109);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 165);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 224);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 109);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 0;
            label4.Text = "Departman:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 165);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 0;
            label5.Text = "İşe Alım Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 224);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 0;
            label6.Text = "Maaş:";
            // 
            // TxtFirstName
            // 
            TxtFirstName.Location = new Point(127, 102);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.Size = new Size(214, 27);
            TxtFirstName.TabIndex = 1;
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(127, 158);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(214, 27);
            TxtLastName.TabIndex = 2;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(127, 217);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(214, 27);
            TxtEmail.TabIndex = 3;
            // 
            // CmbDepartment
            // 
            CmbDepartment.FormattingEnabled = true;
            CmbDepartment.Location = new Point(509, 101);
            CmbDepartment.Name = "CmbDepartment";
            CmbDepartment.Size = new Size(151, 28);
            CmbDepartment.TabIndex = 4;
            // 
            // DtpHireDate
            // 
            DtpHireDate.Format = DateTimePickerFormat.Short;
            DtpHireDate.Location = new Point(509, 158);
            DtpHireDate.Name = "DtpHireDate";
            DtpHireDate.Size = new Size(151, 27);
            DtpHireDate.TabIndex = 5;
            // 
            // ChkIsActive
            // 
            ChkIsActive.AutoSize = true;
            ChkIsActive.Checked = true;
            ChkIsActive.CheckState = CheckState.Checked;
            ChkIsActive.Location = new Point(695, 220);
            ChkIsActive.Name = "ChkIsActive";
            ChkIsActive.Size = new Size(62, 24);
            ChkIsActive.TabIndex = 7;
            ChkIsActive.Text = "Aktif";
            ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // NudSalary
            // 
            NudSalary.DecimalPlaces = 2;
            NudSalary.Location = new Point(509, 217);
            NudSalary.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            NudSalary.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NudSalary.Name = "NudSalary";
            NudSalary.Size = new Size(150, 27);
            NudSalary.TabIndex = 6;
            NudSalary.ThousandsSeparator = true;
            NudSalary.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // LblTitle
            // 
            LblTitle.BackColor = Color.Moccasin;
            LblTitle.Dock = DockStyle.Top;
            LblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblTitle.ForeColor = Color.DarkBlue;
            LblTitle.Location = new Point(0, 0);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(800, 76);
            LblTitle.TabIndex = 6;
            LblTitle.Text = "Personel Ekle";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(552, 281);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(94, 29);
            BtnSave.TabIndex = 8;
            BtnSave.Text = "Kaydet";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(665, 281);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(94, 29);
            BtnCancel.TabIndex = 9;
            BtnCancel.Text = "İptal";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // EmployeeEditForm
            // 
            AcceptButton = BtnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancel;
            ClientSize = new Size(800, 322);
            Controls.Add(BtnCancel);
            Controls.Add(BtnSave);
            Controls.Add(LblTitle);
            Controls.Add(NudSalary);
            Controls.Add(ChkIsActive);
            Controls.Add(DtpHireDate);
            Controls.Add(CmbDepartment);
            Controls.Add(TxtEmail);
            Controls.Add(TxtLastName);
            Controls.Add(TxtFirstName);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel";
            ((System.ComponentModel.ISupportInitialize)NudSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtFirstName;
        private TextBox TxtLastName;
        private TextBox TxtEmail;
        private ComboBox CmbDepartment;
        private DateTimePicker DtpHireDate;
        private CheckBox ChkIsActive;
        private NumericUpDown NudSalary;
        private Label LblTitle;
        private Button BtnSave;
        private Button BtnCancel;
    }
}