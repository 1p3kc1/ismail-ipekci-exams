namespace HrManamentApp
{
    partial class DepartmentEditForm
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
            TxtDepartmentCode = new TextBox();
            TxtDepartmentName = new TextBox();
            BtnSaveDepartment = new Button();
            BtnCancelDepartment = new Button();
            LblTitle = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 114);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Kod:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 155);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // TxtDepartmentCode
            // 
            TxtDepartmentCode.Location = new Point(118, 111);
            TxtDepartmentCode.Name = "TxtDepartmentCode";
            TxtDepartmentCode.Size = new Size(125, 27);
            TxtDepartmentCode.TabIndex = 2;
            // 
            // TxtDepartmentName
            // 
            TxtDepartmentName.Location = new Point(118, 155);
            TxtDepartmentName.Name = "TxtDepartmentName";
            TxtDepartmentName.Size = new Size(125, 27);
            TxtDepartmentName.TabIndex = 3;
            // 
            // BtnSaveDepartment
            // 
            BtnSaveDepartment.Location = new Point(55, 204);
            BtnSaveDepartment.Name = "BtnSaveDepartment";
            BtnSaveDepartment.Size = new Size(94, 29);
            BtnSaveDepartment.TabIndex = 4;
            BtnSaveDepartment.Text = "Kaydet";
            BtnSaveDepartment.UseVisualStyleBackColor = true;
            BtnSaveDepartment.Click += BtnSaveDepartment_Click;
            // 
            // BtnCancelDepartment
            // 
            BtnCancelDepartment.Location = new Point(155, 204);
            BtnCancelDepartment.Name = "BtnCancelDepartment";
            BtnCancelDepartment.Size = new Size(94, 29);
            BtnCancelDepartment.TabIndex = 5;
            BtnCancelDepartment.Text = "Vazgeç";
            BtnCancelDepartment.UseVisualStyleBackColor = true;
            BtnCancelDepartment.Click += BtnCancelDepartment_Click;
            // 
            // LblTitle
            // 
            LblTitle.BackColor = Color.Moccasin;
            LblTitle.Dock = DockStyle.Top;
            LblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            LblTitle.ForeColor = Color.DarkBlue;
            LblTitle.Location = new Point(0, 0);
            LblTitle.Name = "LblTitle";
            LblTitle.Size = new Size(322, 76);
            LblTitle.TabIndex = 6;
            LblTitle.Text = "İK Yönetimi";
            LblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DepartmentEditForm
            // 
            AcceptButton = BtnSaveDepartment;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = BtnCancelDepartment;
            ClientSize = new Size(322, 263);
            Controls.Add(LblTitle);
            Controls.Add(BtnCancelDepartment);
            Controls.Add(BtnSaveDepartment);
            Controls.Add(TxtDepartmentName);
            Controls.Add(TxtDepartmentCode);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DepartmentEditForm";
            Text = "DepartmentEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtDepartmentCode;
        private TextBox TxtDepartmentName;
        private Button BtnSaveDepartment;
        private Button BtnCancelDepartment;
        private Label LblTitle;
    }
}