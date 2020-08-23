namespace SalonSYS
{
    partial class frmAvailability
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
            this.dtAvailability = new System.Windows.Forms.DateTimePicker();
            this.lblAvailableDate = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.pnlAvailability = new System.Windows.Forms.Panel();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.dgAvailability = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.mnuMain.SuspendLayout();
            this.pnlAvailability.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailability)).BeginInit();
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
            this.mnuMain.Size = new System.Drawing.Size(615, 31);
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
            // dtAvailability
            // 
            this.dtAvailability.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAvailability.Location = new System.Drawing.Point(256, 151);
            this.dtAvailability.Name = "dtAvailability";
            this.dtAvailability.Size = new System.Drawing.Size(156, 24);
            this.dtAvailability.TabIndex = 4;
            this.dtAvailability.Value = new System.DateTime(2019, 10, 25, 0, 0, 0, 0);
            this.dtAvailability.ValueChanged += new System.EventHandler(this.dtAvailability_ValueChanged);
            // 
            // lblAvailableDate
            // 
            this.lblAvailableDate.AutoSize = true;
            this.lblAvailableDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableDate.Location = new System.Drawing.Point(112, 156);
            this.lblAvailableDate.Name = "lblAvailableDate";
            this.lblAvailableDate.Size = new System.Drawing.Size(107, 19);
            this.lblAvailableDate.TabIndex = 5;
            this.lblAvailableDate.Text = "Select a date:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(256, 87);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(156, 26);
            this.cmbEmployee.TabIndex = 8;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(63, 90);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(156, 19);
            this.lblEmployee.TabIndex = 9;
            this.lblEmployee.Text = "Select an employee:";
            // 
            // pnlAvailability
            // 
            this.pnlAvailability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailability.Controls.Add(this.btnBack);
            this.pnlAvailability.Controls.Add(this.dgAvailability);
            this.pnlAvailability.Controls.Add(this.btnCheckAvailability);
            this.pnlAvailability.Controls.Add(this.lblEmployee);
            this.pnlAvailability.Controls.Add(this.cmbEmployee);
            this.pnlAvailability.Controls.Add(this.lblAvailableDate);
            this.pnlAvailability.Controls.Add(this.dtAvailability);
            this.pnlAvailability.Location = new System.Drawing.Point(50, 73);
            this.pnlAvailability.Name = "pnlAvailability";
            this.pnlAvailability.Size = new System.Drawing.Size(503, 291);
            this.pnlAvailability.TabIndex = 10;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckAvailability.Location = new System.Drawing.Point(333, 221);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(96, 33);
            this.btnCheckAvailability.TabIndex = 10;
            this.btnCheckAvailability.Text = "Confirm";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(67, 63);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(136, 20);
            this.lblAvailability.TabIndex = 10;
            this.lblAvailability.Text = "Check Availability";
            // 
            // dgAvailability
            // 
            this.dgAvailability.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgAvailability.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAvailability.Location = new System.Drawing.Point(22, 37);
            this.dgAvailability.Name = "dgAvailability";
            this.dgAvailability.RowTemplate.Height = 24;
            this.dgAvailability.Size = new System.Drawing.Size(456, 160);
            this.dgAvailability.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBack.Location = new System.Drawing.Point(333, 221);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 33);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(615, 407);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlAvailability);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAvailability";
            this.Text = "Availability";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlAvailability.ResumeLayout(false);
            this.pnlAvailability.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvailability)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DateTimePicker dtAvailability;
        private System.Windows.Forms.Label lblAvailableDate;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Panel pnlAvailability;
        private System.Windows.Forms.Button btnCheckAvailability;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.DataGridView dgAvailability;
        private System.Windows.Forms.Button btnBack;
    }
}

