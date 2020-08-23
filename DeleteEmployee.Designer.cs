namespace SalonSYS
{
    partial class frmDeleteEmployee
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDeleteEmployee = new System.Windows.Forms.Panel();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnConfirmDeleteEmp = new System.Windows.Forms.Button();
            this.cmbEmpID = new System.Windows.Forms.ComboBox();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblDeleteEmp = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.pnlDeleteEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(142)))));
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(485, 31);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.BackColor = System.Drawing.Color.Transparent;
            this.mnuExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(49, 27);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(57, 27);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // pnlDeleteEmployee
            // 
            this.pnlDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlDeleteEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteEmployee.Controls.Add(this.txtEmpEmail);
            this.pnlDeleteEmployee.Controls.Add(this.txtEmpSurname);
            this.pnlDeleteEmployee.Controls.Add(this.txtEmpName);
            this.pnlDeleteEmployee.Controls.Add(this.lblEmail);
            this.pnlDeleteEmployee.Controls.Add(this.lblSurname);
            this.pnlDeleteEmployee.Controls.Add(this.lblEmployeeName);
            this.pnlDeleteEmployee.Controls.Add(this.btnConfirmDeleteEmp);
            this.pnlDeleteEmployee.Location = new System.Drawing.Point(39, 111);
            this.pnlDeleteEmployee.Name = "pnlDeleteEmployee";
            this.pnlDeleteEmployee.Size = new System.Drawing.Size(403, 286);
            this.pnlDeleteEmployee.TabIndex = 4;
            this.pnlDeleteEmployee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeleteEmployee_Paint);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(152, 162);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.ReadOnly = true;
            this.txtEmpEmail.Size = new System.Drawing.Size(174, 24);
            this.txtEmpEmail.TabIndex = 16;
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Location = new System.Drawing.Point(152, 108);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.ReadOnly = true;
            this.txtEmpSurname.Size = new System.Drawing.Size(131, 24);
            this.txtEmpSurname.TabIndex = 15;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(152, 56);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(131, 24);
            this.txtEmpName.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(88, 165);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(62, 111);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(77, 19);
            this.lblSurname.TabIndex = 11;
            this.lblSurname.Text = "Surname:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(82, 59);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(56, 19);
            this.lblEmployeeName.TabIndex = 10;
            this.lblEmployeeName.Text = "Name:";
            // 
            // btnConfirmDeleteEmp
            // 
            this.btnConfirmDeleteEmp.Location = new System.Drawing.Point(233, 222);
            this.btnConfirmDeleteEmp.Name = "btnConfirmDeleteEmp";
            this.btnConfirmDeleteEmp.Size = new System.Drawing.Size(93, 30);
            this.btnConfirmDeleteEmp.TabIndex = 2;
            this.btnConfirmDeleteEmp.Text = "Delete";
            this.btnConfirmDeleteEmp.UseVisualStyleBackColor = true;
            this.btnConfirmDeleteEmp.Click += new System.EventHandler(this.btnConfirmDeleteEmp_Click);
            // 
            // cmbEmpID
            // 
            this.cmbEmpID.AutoCompleteCustomSource.AddRange(new string[] {
            "001",
            "002",
            "003",
            "004",
            "005"});
            this.cmbEmpID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpID.FormattingEnabled = true;
            this.cmbEmpID.Location = new System.Drawing.Point(198, 54);
            this.cmbEmpID.Name = "cmbEmpID";
            this.cmbEmpID.Size = new System.Drawing.Size(142, 26);
            this.cmbEmpID.TabIndex = 1;
            this.cmbEmpID.SelectedIndexChanged += new System.EventHandler(this.cmbEmpID_SelectedIndexChanged);
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(86, 57);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(110, 19);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employee ID: ";
            // 
            // lblDeleteEmp
            // 
            this.lblDeleteEmp.AutoSize = true;
            this.lblDeleteEmp.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteEmp.Location = new System.Drawing.Point(67, 102);
            this.lblDeleteEmp.Name = "lblDeleteEmp";
            this.lblDeleteEmp.Size = new System.Drawing.Size(125, 19);
            this.lblDeleteEmp.TabIndex = 5;
            this.lblDeleteEmp.Text = "Delete Employee";
            // 
            // frmDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(485, 433);
            this.Controls.Add(this.lblDeleteEmp);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.cmbEmpID);
            this.Controls.Add(this.pnlDeleteEmployee);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDeleteEmployee";
            this.Text = "Delete Employee";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlDeleteEmployee.ResumeLayout(false);
            this.pnlDeleteEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Panel pnlDeleteEmployee;
        private System.Windows.Forms.Label lblDeleteEmp;
        private System.Windows.Forms.ComboBox cmbEmpID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnConfirmDeleteEmp;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}

