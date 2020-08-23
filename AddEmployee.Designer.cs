namespace SalonSYS
{
    partial class frmAddEmployee
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
            this.pnlAddEmployee = new System.Windows.Forms.Panel();
            this.btnClearEmpDetails = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.cmbEmpServices = new System.Windows.Forms.ComboBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            this.pnlAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
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
            this.mnuMain.Size = new System.Drawing.Size(935, 31);
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
            // pnlAddEmployee
            // 
            this.pnlAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlAddEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEmployee.Controls.Add(this.grdEmployees);
            this.pnlAddEmployee.Controls.Add(this.btnClearEmpDetails);
            this.pnlAddEmployee.Controls.Add(this.btnAddEmployee);
            this.pnlAddEmployee.Controls.Add(this.cmbEmpServices);
            this.pnlAddEmployee.Controls.Add(this.txtEmpEmail);
            this.pnlAddEmployee.Controls.Add(this.txtEmpSurname);
            this.pnlAddEmployee.Controls.Add(this.txtEmpName);
            this.pnlAddEmployee.Controls.Add(this.txtEmpID);
            this.pnlAddEmployee.Controls.Add(this.lblServices);
            this.pnlAddEmployee.Controls.Add(this.lblEmail);
            this.pnlAddEmployee.Controls.Add(this.lblSurname);
            this.pnlAddEmployee.Controls.Add(this.lblEmployeeName);
            this.pnlAddEmployee.Controls.Add(this.lblEmpID);
            this.pnlAddEmployee.Location = new System.Drawing.Point(45, 69);
            this.pnlAddEmployee.Name = "pnlAddEmployee";
            this.pnlAddEmployee.Size = new System.Drawing.Size(849, 412);
            this.pnlAddEmployee.TabIndex = 4;
            // 
            // btnClearEmpDetails
            // 
            this.btnClearEmpDetails.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEmpDetails.Location = new System.Drawing.Point(221, 339);
            this.btnClearEmpDetails.Name = "btnClearEmpDetails";
            this.btnClearEmpDetails.Size = new System.Drawing.Size(85, 32);
            this.btnClearEmpDetails.TabIndex = 11;
            this.btnClearEmpDetails.Text = "Clear";
            this.btnClearEmpDetails.UseVisualStyleBackColor = true;
            this.btnClearEmpDetails.Click += new System.EventHandler(this.btnClearEmpDetails_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(333, 339);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(85, 32);
            this.btnAddEmployee.TabIndex = 10;
            this.btnAddEmployee.Text = "Confirm";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // cmbEmpServices
            // 
            this.cmbEmpServices.FormattingEnabled = true;
            this.cmbEmpServices.Location = new System.Drawing.Point(221, 270);
            this.cmbEmpServices.Name = "cmbEmpServices";
            this.cmbEmpServices.Size = new System.Drawing.Size(138, 26);
            this.cmbEmpServices.TabIndex = 9;
            this.cmbEmpServices.SelectedIndexChanged += new System.EventHandler(this.cmbEmpServices_SelectedIndexChanged);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(221, 222);
            this.txtEmpEmail.MaxLength = 30;
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(174, 24);
            this.txtEmpEmail.TabIndex = 8;
            this.txtEmpEmail.TextChanged += new System.EventHandler(this.txtEmpEmail_TextChanged);
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Location = new System.Drawing.Point(221, 168);
            this.txtEmpSurname.MaxLength = 20;
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(131, 24);
            this.txtEmpSurname.TabIndex = 7;
            this.txtEmpSurname.TextChanged += new System.EventHandler(this.txtEmpSurname_TextChanged);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(221, 116);
            this.txtEmpName.MaxLength = 15;
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(131, 24);
            this.txtEmpName.TabIndex = 6;
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            // 
            // txtEmpID
            // 
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Location = new System.Drawing.Point(221, 64);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(71, 24);
            this.txtEmpID.TabIndex = 5;
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(133, 273);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(73, 19);
            this.lblServices.TabIndex = 4;
            this.lblServices.Text = "Services:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(155, 225);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(129, 171);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(77, 19);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(145, 119);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(56, 19);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Name:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.Location = new System.Drawing.Point(100, 67);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(106, 19);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Employee ID:";
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployee.Location = new System.Drawing.Point(80, 60);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(111, 19);
            this.lblAddEmployee.TabIndex = 0;
            this.lblAddEmployee.Text = "Add Employee";
            // 
            // grdEmployees
            // 
            this.grdEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Location = new System.Drawing.Point(457, 79);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.RowTemplate.Height = 24;
            this.grdEmployees.Size = new System.Drawing.Size(359, 233);
            this.grdEmployees.TabIndex = 12;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(935, 521);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlAddEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddEmployee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlAddEmployee.ResumeLayout(false);
            this.pnlAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Panel pnlAddEmployee;
        private System.Windows.Forms.Button btnClearEmpDetails;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbEmpServices;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblAddEmployee;
        private System.Windows.Forms.DataGridView grdEmployees;
    }
}

