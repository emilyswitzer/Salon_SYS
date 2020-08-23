namespace SalonSYS
{
    partial class frmMakeAppointment
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
            this.txtApptID = new System.Windows.Forms.TextBox();
            this.DateAppBox = new System.Windows.Forms.DateTimePicker();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblApptID = new System.Windows.Forms.Label();
            this.lblApptDate = new System.Windows.Forms.Label();
            this.lblApptTime = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnClearAppt = new System.Windows.Forms.Button();
            this.btnConfirmAppt = new System.Windows.Forms.Button();
            this.pnlMakeAppt = new System.Windows.Forms.Panel();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblMakeApptlbl = new System.Windows.Forms.Label();
            this.grdApps = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            this.pnlMakeAppt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApps)).BeginInit();
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
            this.mnuMain.Size = new System.Drawing.Size(975, 31);
            this.mnuMain.TabIndex = 3;
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
            // txtApptID
            // 
            this.txtApptID.Enabled = false;
            this.txtApptID.Location = new System.Drawing.Point(206, 40);
            this.txtApptID.Name = "txtApptID";
            this.txtApptID.Size = new System.Drawing.Size(71, 24);
            this.txtApptID.TabIndex = 1;
            this.txtApptID.TextChanged += new System.EventHandler(this.txtApptID_TextChanged);
            // 
            // DateAppBox
            // 
            this.DateAppBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateAppBox.CustomFormat = "yyyy-MM-dd";
            this.DateAppBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAppBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateAppBox.Location = new System.Drawing.Point(206, 165);
            this.DateAppBox.Name = "DateAppBox";
            this.DateAppBox.Size = new System.Drawing.Size(135, 24);
            this.DateAppBox.TabIndex = 2;
            this.DateAppBox.Value = new System.DateTime(2020, 4, 6, 0, 0, 0, 0);
            this.DateAppBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(206, 82);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(135, 26);
            this.cmbServiceID.TabIndex = 4;
            this.cmbServiceID.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(206, 123);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(135, 26);
            this.cmbEmployeeID.TabIndex = 6;
            this.cmbEmployeeID.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeID_SelectedIndexChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(206, 253);
            this.txtCustomerName.MaxLength = 15;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(135, 24);
            this.txtCustomerName.TabIndex = 5;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblApptID
            // 
            this.lblApptID.AutoSize = true;
            this.lblApptID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptID.Location = new System.Drawing.Point(36, 40);
            this.lblApptID.Name = "lblApptID";
            this.lblApptID.Size = new System.Drawing.Size(132, 19);
            this.lblApptID.TabIndex = 10;
            this.lblApptID.Text = "Appointment ID:";
            // 
            // lblApptDate
            // 
            this.lblApptDate.AutoSize = true;
            this.lblApptDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptDate.Location = new System.Drawing.Point(120, 165);
            this.lblApptDate.Name = "lblApptDate";
            this.lblApptDate.Size = new System.Drawing.Size(48, 19);
            this.lblApptDate.TabIndex = 11;
            this.lblApptDate.Text = "Date:";
            // 
            // lblApptTime
            // 
            this.lblApptTime.AutoSize = true;
            this.lblApptTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApptTime.Location = new System.Drawing.Point(120, 208);
            this.lblApptTime.Name = "lblApptTime";
            this.lblApptTime.Size = new System.Drawing.Size(49, 19);
            this.lblApptTime.TabIndex = 12;
            this.lblApptTime.Text = "Time:";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(102, 85);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(66, 19);
            this.lblServiceID.TabIndex = 13;
            this.lblServiceID.Text = "Service:";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(83, 121);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(85, 19);
            this.lblEmployee.TabIndex = 14;
            this.lblEmployee.Text = "Employee:";
            // 
            // btnClearAppt
            // 
            this.btnClearAppt.Location = new System.Drawing.Point(165, 352);
            this.btnClearAppt.Name = "btnClearAppt";
            this.btnClearAppt.Size = new System.Drawing.Size(90, 33);
            this.btnClearAppt.TabIndex = 7;
            this.btnClearAppt.Text = "Clear";
            this.btnClearAppt.UseVisualStyleBackColor = true;
            this.btnClearAppt.Click += new System.EventHandler(this.btnClearAppt_Click);
            // 
            // btnConfirmAppt
            // 
            this.btnConfirmAppt.Location = new System.Drawing.Point(279, 352);
            this.btnConfirmAppt.Name = "btnConfirmAppt";
            this.btnConfirmAppt.Size = new System.Drawing.Size(90, 33);
            this.btnConfirmAppt.TabIndex = 8;
            this.btnConfirmAppt.Text = "Confirm";
            this.btnConfirmAppt.UseVisualStyleBackColor = true;
            this.btnConfirmAppt.Click += new System.EventHandler(this.btnConfirmAppt_Click);
            // 
            // pnlMakeAppt
            // 
            this.pnlMakeAppt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlMakeAppt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMakeAppt.Controls.Add(this.grdApps);
            this.pnlMakeAppt.Controls.Add(this.txtCost);
            this.pnlMakeAppt.Controls.Add(this.lblCost);
            this.pnlMakeAppt.Controls.Add(this.lblPhone);
            this.pnlMakeAppt.Controls.Add(this.txtCPhone);
            this.pnlMakeAppt.Controls.Add(this.cmbTime);
            this.pnlMakeAppt.Controls.Add(this.lblCustomer);
            this.pnlMakeAppt.Controls.Add(this.btnConfirmAppt);
            this.pnlMakeAppt.Controls.Add(this.btnClearAppt);
            this.pnlMakeAppt.Controls.Add(this.lblEmployee);
            this.pnlMakeAppt.Controls.Add(this.lblServiceID);
            this.pnlMakeAppt.Controls.Add(this.lblApptTime);
            this.pnlMakeAppt.Controls.Add(this.lblApptDate);
            this.pnlMakeAppt.Controls.Add(this.lblApptID);
            this.pnlMakeAppt.Controls.Add(this.txtCustomerName);
            this.pnlMakeAppt.Controls.Add(this.cmbEmployeeID);
            this.pnlMakeAppt.Controls.Add(this.cmbServiceID);
            this.pnlMakeAppt.Controls.Add(this.DateAppBox);
            this.pnlMakeAppt.Controls.Add(this.txtApptID);
            this.pnlMakeAppt.Location = new System.Drawing.Point(42, 60);
            this.pnlMakeAppt.Name = "pnlMakeAppt";
            this.pnlMakeAppt.Size = new System.Drawing.Size(878, 410);
            this.pnlMakeAppt.TabIndex = 17;
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(411, 37);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 24);
            this.txtCost.TabIndex = 20;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(333, 40);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 19);
            this.lblCost.TabIndex = 19;
            this.lblCost.Text = "Cost:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(46, 300);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(123, 19);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Phone Number:";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(206, 297);
            this.txtCPhone.MaxLength = 10;
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(135, 24);
            this.txtCPhone.TabIndex = 16;
            this.txtCPhone.TextChanged += new System.EventHandler(this.txtCPhone_TextChanged);
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(206, 205);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(135, 26);
            this.cmbTime.TabIndex = 3;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(67, 256);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(102, 19);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.Text = "Client Name:";
            // 
            // lblMakeApptlbl
            // 
            this.lblMakeApptlbl.AutoSize = true;
            this.lblMakeApptlbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakeApptlbl.Location = new System.Drawing.Point(61, 51);
            this.lblMakeApptlbl.Name = "lblMakeApptlbl";
            this.lblMakeApptlbl.Size = new System.Drawing.Size(151, 19);
            this.lblMakeApptlbl.TabIndex = 17;
            this.lblMakeApptlbl.Text = "Make Appointment";
            // 
            // grdApps
            // 
            this.grdApps.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grdApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdApps.Location = new System.Drawing.Point(411, 85);
            this.grdApps.Name = "grdApps";
            this.grdApps.RowTemplate.Height = 24;
            this.grdApps.Size = new System.Drawing.Size(430, 236);
            this.grdApps.TabIndex = 21;
            // 
            // frmMakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(975, 513);
            this.Controls.Add(this.lblMakeApptlbl);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlMakeAppt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMakeAppointment";
            this.Text = "Make Appointment";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlMakeAppt.ResumeLayout(false);
            this.pnlMakeAppt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdApps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtApptID;
        private System.Windows.Forms.DateTimePicker DateAppBox;
        private System.Windows.Forms.ComboBox cmbServiceID;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblApptID;
        private System.Windows.Forms.Label lblApptDate;
        private System.Windows.Forms.Label lblApptTime;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnClearAppt;
        private System.Windows.Forms.Button btnConfirmAppt;
        private System.Windows.Forms.Panel pnlMakeAppt;
        private System.Windows.Forms.Label lblMakeApptlbl;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DataGridView grdApps;
    }
}

