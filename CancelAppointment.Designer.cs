namespace SalonSYS
{
    partial class frmCancelAppointment
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
            this.pnlCancelAppt = new System.Windows.Forms.Panel();
            this.txtService = new System.Windows.Forms.TextBox();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.cmbAppID = new System.Windows.Forms.ComboBox();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblCancelAppt = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblTimeID = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.pnlCancelAppt.SuspendLayout();
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
            this.mnuMain.Size = new System.Drawing.Size(754, 31);
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
            // pnlCancelAppt
            // 
            this.pnlCancelAppt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlCancelAppt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCancelAppt.Controls.Add(this.lblCost);
            this.pnlCancelAppt.Controls.Add(this.lblTimeID);
            this.pnlCancelAppt.Controls.Add(this.lblCPhone);
            this.pnlCancelAppt.Controls.Add(this.lblCust);
            this.pnlCancelAppt.Controls.Add(this.lblEmpID);
            this.pnlCancelAppt.Controls.Add(this.lblService);
            this.pnlCancelAppt.Controls.Add(this.lblDate);
            this.pnlCancelAppt.Controls.Add(this.txtService);
            this.pnlCancelAppt.Controls.Add(this.txtEmp);
            this.pnlCancelAppt.Controls.Add(this.txtClient);
            this.pnlCancelAppt.Controls.Add(this.txtClientPhone);
            this.pnlCancelAppt.Controls.Add(this.txtTime);
            this.pnlCancelAppt.Controls.Add(this.txtCost);
            this.pnlCancelAppt.Controls.Add(this.txtDate);
            this.pnlCancelAppt.Controls.Add(this.btnCancelAppointment);
            this.pnlCancelAppt.Location = new System.Drawing.Point(44, 103);
            this.pnlCancelAppt.Name = "pnlCancelAppt";
            this.pnlCancelAppt.Size = new System.Drawing.Size(667, 269);
            this.pnlCancelAppt.TabIndex = 4;
            this.pnlCancelAppt.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCancelAppt_Paint);
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(111, 87);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(132, 24);
            this.txtService.TabIndex = 11;
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(111, 134);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.ReadOnly = true;
            this.txtEmp.Size = new System.Drawing.Size(132, 24);
            this.txtEmp.TabIndex = 10;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(111, 187);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(132, 24);
            this.txtClient.TabIndex = 9;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(345, 40);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.ReadOnly = true;
            this.txtClientPhone.Size = new System.Drawing.Size(100, 24);
            this.txtClientPhone.TabIndex = 8;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(345, 88);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(100, 24);
            this.txtTime.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(345, 137);
            this.txtCost.MaxLength = 1222333;
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(100, 24);
            this.txtCost.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(111, 40);
            this.txtDate.MaxLength = 8;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(132, 24);
            this.txtDate.TabIndex = 3;
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAppointment.Location = new System.Drawing.Point(501, 205);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(102, 31);
            this.btnCancelAppointment.TabIndex = 2;
            this.btnCancelAppointment.Text = "Confirm";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnCancelAppointment_Click);
            // 
            // cmbAppID
            // 
            this.cmbAppID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppID.FormattingEnabled = true;
            this.cmbAppID.Location = new System.Drawing.Point(265, 55);
            this.cmbAppID.Name = "cmbAppID";
            this.cmbAppID.Size = new System.Drawing.Size(136, 26);
            this.cmbAppID.TabIndex = 1;
            this.cmbAppID.SelectedIndexChanged += new System.EventHandler(this.cmbAppID_SelectedIndexChanged);
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.Location = new System.Drawing.Point(113, 58);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(132, 19);
            this.lblAppointmentID.TabIndex = 0;
            this.lblAppointmentID.Text = "Appointment ID:";
            // 
            // lblCancelAppt
            // 
            this.lblCancelAppt.AutoSize = true;
            this.lblCancelAppt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelAppt.Location = new System.Drawing.Point(68, 93);
            this.lblCancelAppt.Name = "lblCancelAppt";
            this.lblCancelAppt.Size = new System.Drawing.Size(150, 19);
            this.lblCancelAppt.TabIndex = 0;
            this.lblCancelAppt.Text = "Cancel Appointment";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(26, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(72, 18);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "App Date:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(23, 90);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(75, 18);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "ServiceID:";
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(41, 134);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(57, 18);
            this.lblEmpID.TabIndex = 14;
            this.lblEmpID.Text = "EmpID:";
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.Location = new System.Drawing.Point(49, 187);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(49, 18);
            this.lblCust.TabIndex = 15;
            this.lblCust.Text = "Client:";
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(280, 40);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(59, 18);
            this.lblCPhone.TabIndex = 16;
            this.lblCPhone.Text = "Phone: ";
            // 
            // lblTimeID
            // 
            this.lblTimeID.AutoSize = true;
            this.lblTimeID.Location = new System.Drawing.Point(276, 90);
            this.lblTimeID.Name = "lblTimeID";
            this.lblTimeID.Size = new System.Drawing.Size(63, 18);
            this.lblTimeID.TabIndex = 17;
            this.lblTimeID.Text = "TimeID: ";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(290, 137);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(44, 18);
            this.lblCost.TabIndex = 18;
            this.lblCost.Text = "Cost:";
            // 
            // frmCancelAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(754, 399);
            this.Controls.Add(this.lblCancelAppt);
            this.Controls.Add(this.lblAppointmentID);
            this.Controls.Add(this.cmbAppID);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlCancelAppt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCancelAppointment";
            this.Text = "Cancel Appointment";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlCancelAppt.ResumeLayout(false);
            this.pnlCancelAppt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Panel pnlCancelAppt;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.ComboBox cmbAppID;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblCancelAppt;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblTimeID;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDate;
    }
}

