namespace HrManamentApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            HelpToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            tabMain = new TabControl();
            tabEmployees = new TabPage();
            LblEmployeeCount = new Label();
            DgvEmployees = new DataGridView();
            BtnDeleteEmployee = new Button();
            BtnEditEmployee = new Button();
            BtnAddEmployee = new Button();
            BtnDetailsEmployee = new Button();
            BtnFilterEmployees = new Button();
            CmbDepartment = new ComboBox();
            label2 = new Label();
            tabLeaves = new TabPage();
            LblLeaveCount = new Label();
            BtnDeleteLeave = new Button();
            BtnEditLeave = new Button();
            BtnAddLeave = new Button();
            BtnFilterLeaves = new Button();
            CmbLeaveStatus = new ComboBox();
            LblLeaveStatusCaption = new Label();
            DgvLeaves = new DataGridView();
            tabDepartmens = new TabPage();
            LblDepartmentCount = new Label();
            BtnDeleteDepartment = new Button();
            BtnEditDepartment = new Button();
            BtnAddDepartment = new Button();
            DgvDepartments = new DataGridView();
            menuStrip1.SuspendLayout();
            tabMain.SuspendLayout();
            tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEmployees).BeginInit();
            tabLeaves.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLeaves).BeginInit();
            tabDepartmens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDepartments).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, HelpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1098, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(64, 24);
            FileToolStripMenuItem.Text = "Dosya";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(122, 26);
            ExitToolStripMenuItem.Text = "Çıkış";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new Size(69, 24);
            HelpToolStripMenuItem.Text = "Yardım";
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new Size(154, 26);
            AboutToolStripMenuItem.Text = "Hakkında";
            // 
            // label1
            // 
            label1.BackColor = Color.Moccasin;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(0, 30);
            label1.Name = "label1";
            label1.Size = new Size(1098, 76);
            label1.TabIndex = 1;
            label1.Text = "İK Yönetimi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabEmployees);
            tabMain.Controls.Add(tabLeaves);
            tabMain.Controls.Add(tabDepartmens);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 106);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1098, 627);
            tabMain.TabIndex = 2;
            // 
            // tabEmployees
            // 
            tabEmployees.Controls.Add(LblEmployeeCount);
            tabEmployees.Controls.Add(DgvEmployees);
            tabEmployees.Controls.Add(BtnDeleteEmployee);
            tabEmployees.Controls.Add(BtnEditEmployee);
            tabEmployees.Controls.Add(BtnAddEmployee);
            tabEmployees.Controls.Add(BtnDetailsEmployee);
            tabEmployees.Controls.Add(BtnFilterEmployees);
            tabEmployees.Controls.Add(CmbDepartment);
            tabEmployees.Controls.Add(label2);
            tabEmployees.Location = new Point(4, 29);
            tabEmployees.Name = "tabEmployees";
            tabEmployees.Padding = new Padding(3, 3, 3, 3);
            tabEmployees.Size = new Size(1090, 594);
            tabEmployees.TabIndex = 0;
            tabEmployees.Text = "Personel";
            tabEmployees.UseVisualStyleBackColor = true;
            // 
            // LblEmployeeCount
            // 
            LblEmployeeCount.AutoSize = true;
            LblEmployeeCount.Location = new Point(382, 12);
            LblEmployeeCount.Name = "LblEmployeeCount";
            LblEmployeeCount.Size = new Size(57, 20);
            LblEmployeeCount.TabIndex = 5;
            LblEmployeeCount.Text = "Kayıt: 0";
            // 
            // DgvEmployees
            // 
            DgvEmployees.AllowUserToAddRows = false;
            DgvEmployees.AllowUserToDeleteRows = false;
            DgvEmployees.AllowUserToResizeColumns = false;
            DgvEmployees.AllowUserToResizeRows = false;
            DgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEmployees.Dock = DockStyle.Bottom;
            DgvEmployees.Location = new Point(3, 191);
            DgvEmployees.Name = "DgvEmployees";
            DgvEmployees.RowHeadersWidth = 51;
            DgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvEmployees.Size = new Size(1084, 400);
            DgvEmployees.TabIndex = 4;
            DgvEmployees.DoubleClick += BtnDetailsEmployee_Click;
            // 
            // BtnDeleteEmployee
            // 
            BtnDeleteEmployee.Location = new Point(917, 9);
            BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            BtnDeleteEmployee.Size = new Size(94, 29);
            BtnDeleteEmployee.TabIndex = 3;
            BtnDeleteEmployee.Text = "Sil";
            BtnDeleteEmployee.UseVisualStyleBackColor = true;
            BtnDeleteEmployee.Click += BtnDeleteEmployee_Click;
            // 
            // BtnEditEmployee
            // 
            BtnEditEmployee.Location = new Point(813, 9);
            BtnEditEmployee.Name = "BtnEditEmployee";
            BtnEditEmployee.Size = new Size(94, 29);
            BtnEditEmployee.TabIndex = 3;
            BtnEditEmployee.Text = "Düzenle";
            BtnEditEmployee.UseVisualStyleBackColor = true;
            BtnEditEmployee.Click += BtnEditEmployee_Click;
            // 
            // BtnAddEmployee
            // 
            BtnAddEmployee.Location = new Point(710, 9);
            BtnAddEmployee.Name = "BtnAddEmployee";
            BtnAddEmployee.Size = new Size(94, 29);
            BtnAddEmployee.TabIndex = 3;
            BtnAddEmployee.Text = "Ekle";
            BtnAddEmployee.UseVisualStyleBackColor = true;
            BtnAddEmployee.Click += BtnAddEmployee_Click;
            // 
            // BtnDetailsEmployee
            // 
            BtnDetailsEmployee.Location = new Point(607, 9);
            BtnDetailsEmployee.Name = "BtnDetailsEmployee";
            BtnDetailsEmployee.Size = new Size(94, 29);
            BtnDetailsEmployee.TabIndex = 3;
            BtnDetailsEmployee.Text = "Detay Göster";
            BtnDetailsEmployee.UseVisualStyleBackColor = true;
            BtnDetailsEmployee.Click += BtnDetailsEmployee_Click;
            // 
            // BtnFilterEmployees
            // 
            BtnFilterEmployees.Location = new Point(258, 9);
            BtnFilterEmployees.Name = "BtnFilterEmployees";
            BtnFilterEmployees.Size = new Size(94, 29);
            BtnFilterEmployees.TabIndex = 2;
            BtnFilterEmployees.Text = "Filtrele";
            BtnFilterEmployees.UseVisualStyleBackColor = true;
            BtnFilterEmployees.Click += BtnFilterEmployees_Click;
            // 
            // CmbDepartment
            // 
            CmbDepartment.FormattingEnabled = true;
            CmbDepartment.Location = new Point(101, 9);
            CmbDepartment.Name = "CmbDepartment";
            CmbDepartment.Size = new Size(151, 28);
            CmbDepartment.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 0;
            label2.Text = "Departman:";
            // 
            // tabLeaves
            // 
            tabLeaves.Controls.Add(LblLeaveCount);
            tabLeaves.Controls.Add(BtnDeleteLeave);
            tabLeaves.Controls.Add(BtnEditLeave);
            tabLeaves.Controls.Add(BtnAddLeave);
            tabLeaves.Controls.Add(BtnFilterLeaves);
            tabLeaves.Controls.Add(CmbLeaveStatus);
            tabLeaves.Controls.Add(LblLeaveStatusCaption);
            tabLeaves.Controls.Add(DgvLeaves);
            tabLeaves.Location = new Point(4, 29);
            tabLeaves.Name = "tabLeaves";
            tabLeaves.Padding = new Padding(3, 3, 3, 3);
            tabLeaves.Size = new Size(1090, 594);
            tabLeaves.TabIndex = 1;
            tabLeaves.Text = "İzin Talepleri";
            tabLeaves.UseVisualStyleBackColor = true;
            // 
            // LblLeaveCount
            // 
            LblLeaveCount.AutoSize = true;
            LblLeaveCount.Location = new Point(337, 13);
            LblLeaveCount.Name = "LblLeaveCount";
            LblLeaveCount.Size = new Size(57, 20);
            LblLeaveCount.TabIndex = 7;
            LblLeaveCount.Text = "Kayıt: 0";
            // 
            // BtnDeleteLeave
            // 
            BtnDeleteLeave.Location = new Point(918, 11);
            BtnDeleteLeave.Name = "BtnDeleteLeave";
            BtnDeleteLeave.Size = new Size(94, 29);
            BtnDeleteLeave.TabIndex = 4;
            BtnDeleteLeave.Text = "Sil";
            BtnDeleteLeave.UseVisualStyleBackColor = true;
            BtnDeleteLeave.Click += BtnDeleteLeave_Click;
            // 
            // BtnEditLeave
            // 
            BtnEditLeave.Location = new Point(815, 11);
            BtnEditLeave.Name = "BtnEditLeave";
            BtnEditLeave.Size = new Size(94, 29);
            BtnEditLeave.TabIndex = 5;
            BtnEditLeave.Text = "Düzenle";
            BtnEditLeave.UseVisualStyleBackColor = true;
            BtnEditLeave.Click += BtnEditLeave_Click;
            // 
            // BtnAddLeave
            // 
            BtnAddLeave.Location = new Point(712, 11);
            BtnAddLeave.Name = "BtnAddLeave";
            BtnAddLeave.Size = new Size(94, 29);
            BtnAddLeave.TabIndex = 6;
            BtnAddLeave.Text = "Ekle";
            BtnAddLeave.UseVisualStyleBackColor = true;
            BtnAddLeave.Click += BtnAddLeave_Click;
            // 
            // BtnFilterLeaves
            // 
            BtnFilterLeaves.Location = new Point(229, 9);
            BtnFilterLeaves.Name = "BtnFilterLeaves";
            BtnFilterLeaves.Size = new Size(94, 29);
            BtnFilterLeaves.TabIndex = 3;
            BtnFilterLeaves.Text = "Filtrele";
            BtnFilterLeaves.UseVisualStyleBackColor = true;
            BtnFilterLeaves.Click += BtnFilterLeaves_Click;
            // 
            // CmbLeaveStatus
            // 
            CmbLeaveStatus.FormattingEnabled = true;
            CmbLeaveStatus.Location = new Point(71, 11);
            CmbLeaveStatus.Name = "CmbLeaveStatus";
            CmbLeaveStatus.Size = new Size(151, 28);
            CmbLeaveStatus.TabIndex = 2;
            // 
            // LblLeaveStatusCaption
            // 
            LblLeaveStatusCaption.AutoSize = true;
            LblLeaveStatusCaption.Location = new Point(8, 13);
            LblLeaveStatusCaption.Name = "LblLeaveStatusCaption";
            LblLeaveStatusCaption.Size = new Size(57, 20);
            LblLeaveStatusCaption.TabIndex = 1;
            LblLeaveStatusCaption.Text = "Durum:";
            // 
            // DgvLeaves
            // 
            DgvLeaves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvLeaves.Dock = DockStyle.Bottom;
            DgvLeaves.Location = new Point(3, 204);
            DgvLeaves.Name = "DgvLeaves";
            DgvLeaves.RowHeadersWidth = 51;
            DgvLeaves.Size = new Size(1084, 387);
            DgvLeaves.TabIndex = 0;
            // 
            // tabDepartmens
            // 
            tabDepartmens.Controls.Add(LblDepartmentCount);
            tabDepartmens.Controls.Add(BtnDeleteDepartment);
            tabDepartmens.Controls.Add(BtnEditDepartment);
            tabDepartmens.Controls.Add(BtnAddDepartment);
            tabDepartmens.Controls.Add(DgvDepartments);
            tabDepartmens.Location = new Point(4, 29);
            tabDepartmens.Name = "tabDepartmens";
            tabDepartmens.Padding = new Padding(3, 3, 3, 3);
            tabDepartmens.Size = new Size(1090, 594);
            tabDepartmens.TabIndex = 2;
            tabDepartmens.Text = "Departmanlar";
            tabDepartmens.UseVisualStyleBackColor = true;
            // 
            // LblDepartmentCount
            // 
            LblDepartmentCount.AutoSize = true;
            LblDepartmentCount.Location = new Point(8, 11);
            LblDepartmentCount.Name = "LblDepartmentCount";
            LblDepartmentCount.Size = new Size(57, 20);
            LblDepartmentCount.TabIndex = 12;
            LblDepartmentCount.Text = "Kayıt: 0";
            // 
            // BtnDeleteDepartment
            // 
            BtnDeleteDepartment.Location = new Point(918, 7);
            BtnDeleteDepartment.Name = "BtnDeleteDepartment";
            BtnDeleteDepartment.Size = new Size(94, 29);
            BtnDeleteDepartment.TabIndex = 9;
            BtnDeleteDepartment.Text = "Sil";
            BtnDeleteDepartment.UseVisualStyleBackColor = true;
            BtnDeleteDepartment.Click += BtnDeleteDepartment_Click;
            // 
            // BtnEditDepartment
            // 
            BtnEditDepartment.Location = new Point(815, 7);
            BtnEditDepartment.Name = "BtnEditDepartment";
            BtnEditDepartment.Size = new Size(94, 29);
            BtnEditDepartment.TabIndex = 10;
            BtnEditDepartment.Text = "Düzenle";
            BtnEditDepartment.UseVisualStyleBackColor = true;
            BtnEditDepartment.Click += BtnEditDepartment_Click;
            // 
            // BtnAddDepartment
            // 
            BtnAddDepartment.Location = new Point(712, 7);
            BtnAddDepartment.Name = "BtnAddDepartment";
            BtnAddDepartment.Size = new Size(94, 29);
            BtnAddDepartment.TabIndex = 11;
            BtnAddDepartment.Text = "Ekle";
            BtnAddDepartment.UseVisualStyleBackColor = true;
            BtnAddDepartment.Click += BtnAddDepartment_Click;
            // 
            // DgvDepartments
            // 
            DgvDepartments.AllowUserToAddRows = false;
            DgvDepartments.AllowUserToDeleteRows = false;
            DgvDepartments.AllowUserToResizeColumns = false;
            DgvDepartments.AllowUserToResizeRows = false;
            DgvDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDepartments.Dock = DockStyle.Bottom;
            DgvDepartments.Location = new Point(3, 204);
            DgvDepartments.Name = "DgvDepartments";
            DgvDepartments.RowHeadersWidth = 51;
            DgvDepartments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDepartments.Size = new Size(1084, 387);
            DgvDepartments.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 733);
            Controls.Add(tabMain);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(800, 398);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HR Managament App";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabMain.ResumeLayout(false);
            tabEmployees.ResumeLayout(false);
            tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvEmployees).EndInit();
            tabLeaves.ResumeLayout(false);
            tabLeaves.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLeaves).EndInit();
            tabDepartmens.ResumeLayout(false);
            tabDepartmens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem HelpToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private Label label1;
        private TabControl tabMain;
        private TabPage tabEmployees;
        private TabPage tabLeaves;
        private TabPage tabDepartmens;
        private Button BtnDetailsEmployee;
        private Button BtnFilterEmployees;
        private ComboBox CmbDepartment;
        private Label label2;
        private Button BtnDeleteEmployee;
        private Button BtnEditEmployee;
        private Button BtnAddEmployee;
        private Label LblEmployeeCount;
        private DataGridView DgvEmployees;
        private Label LblLeaveStatusCaption;
        private DataGridView DgvLeaves;
        private Button BtnDeleteLeave;
        private Button BtnEditLeave;
        private Button BtnAddLeave;
        private Button BtnFilterLeaves;
        private ComboBox CmbLeaveStatus;
        private Label LblLeaveCount;
        private Label LblDepartmentCount;
        private Button BtnDeleteDepartment;
        private Button BtnEditDepartment;
        private Button BtnAddDepartment;
        private DataGridView DgvDepartments;
    }
}
