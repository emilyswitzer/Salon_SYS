namespace SalonSYS
{
    partial class frmChangeService
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
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.pnlChangeService = new System.Windows.Forms.Panel();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtServCost = new System.Windows.Forms.TextBox();
            this.lblServDuration = new System.Windows.Forms.Label();
            this.cmbServDuration = new System.Windows.Forms.ComboBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblChangeService = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.pnlChangeService.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuMain.Size = new System.Drawing.Size(551, 31);
            this.mnuMain.TabIndex = 3;
            // 
            // pnlChangeService
            // 
            this.pnlChangeService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlChangeService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangeService.Controls.Add(this.btnUpdateService);
            this.pnlChangeService.Controls.Add(this.btnCancel);
            this.pnlChangeService.Controls.Add(this.lblCost);
            this.pnlChangeService.Controls.Add(this.txtServCost);
            this.pnlChangeService.Controls.Add(this.lblServDuration);
            this.pnlChangeService.Controls.Add(this.cmbServDuration);
            this.pnlChangeService.Controls.Add(this.lblDesc);
            this.pnlChangeService.Controls.Add(this.txtDesc);
            this.pnlChangeService.Location = new System.Drawing.Point(11, 104);
            this.pnlChangeService.Name = "pnlChangeService";
            this.pnlChangeService.Size = new System.Drawing.Size(527, 342);
            this.pnlChangeService.TabIndex = 4;
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateService.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnUpdateService.Location = new System.Drawing.Point(285, 260);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(90, 32);
            this.btnUpdateService.TabIndex = 9;
            this.btnUpdateService.Text = "Update";
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(126, 199);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 19);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "Cost:";
            // 
            // txtServCost
            // 
            this.txtServCost.Location = new System.Drawing.Point(188, 196);
            this.txtServCost.MaxLength = 3;
            this.txtServCost.Name = "txtServCost";
            this.txtServCost.Size = new System.Drawing.Size(114, 24);
            this.txtServCost.TabIndex = 6;
            // 
            // lblServDuration
            // 
            this.lblServDuration.AutoSize = true;
            this.lblServDuration.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServDuration.Location = new System.Drawing.Point(95, 141);
            this.lblServDuration.Name = "lblServDuration";
            this.lblServDuration.Size = new System.Drawing.Size(77, 19);
            this.lblServDuration.TabIndex = 5;
            this.lblServDuration.Text = "Duration:";
            // 
            // cmbServDuration
            // 
            this.cmbServDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServDuration.FormattingEnabled = true;
            this.cmbServDuration.Location = new System.Drawing.Point(188, 141);
            this.cmbServDuration.Name = "cmbServDuration";
            this.cmbServDuration.Size = new System.Drawing.Size(114, 26);
            this.cmbServDuration.TabIndex = 4;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(77, 56);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(98, 19);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(188, 53);
            this.txtDesc.MaxLength = 100;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(147, 58);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.WordWrap = false;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(200, 55);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(147, 26);
            this.cmbServiceID.TabIndex = 1;
            this.cmbServiceID.SelectedIndexChanged += new System.EventHandler(this.cmbServiceName_SelectedIndexChanged);
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(107, 58);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(87, 19);
            this.lblServiceID.TabIndex = 0;
            this.lblServiceID.Text = "Service ID:";
            // 
            // lblChangeService
            // 
            this.lblChangeService.AutoSize = true;
            this.lblChangeService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblChangeService.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeService.Location = new System.Drawing.Point(54, 95);
            this.lblChangeService.Name = "lblChangeService";
            this.lblChangeService.Size = new System.Drawing.Size(117, 19);
            this.lblChangeService.TabIndex = 0;
            this.lblChangeService.Text = "Change Service";
            this.lblChangeService.Click += new System.EventHandler(this.lblChangeService_Click);
            // 
            // frmChangeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(551, 482);
            this.Controls.Add(this.lblChangeService);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlChangeService);
            this.Controls.Add(this.cmbServiceID);
            this.Controls.Add(this.lblServiceID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmChangeService";
            this.Text = "Change Service";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlChangeService.ResumeLayout(false);
            this.pnlChangeService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.Panel pnlChangeService;
        private System.Windows.Forms.Label lblChangeService;
        private System.Windows.Forms.ComboBox cmbServiceID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtServCost;
        private System.Windows.Forms.Label lblServDuration;
        private System.Windows.Forms.ComboBox cmbServDuration;
        private System.Windows.Forms.TextBox txtDesc;
    }
}

