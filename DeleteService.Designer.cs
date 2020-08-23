namespace SalonSYS
{
    partial class frmDeleteService
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
            this.pnlDeleteServ = new System.Windows.Forms.Panel();
            this.txtServDuration = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtServCost = new System.Windows.Forms.TextBox();
            this.lblServDuration = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblServices = new System.Windows.Forms.Label();
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.lblDeleteServlbl = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            this.pnlDeleteServ.SuspendLayout();
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
            this.mnuMain.Size = new System.Drawing.Size(476, 31);
            this.mnuMain.TabIndex = 3;
            this.mnuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuMain_ItemClicked);
            // 
            // pnlDeleteServ
            // 
            this.pnlDeleteServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlDeleteServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDeleteServ.Controls.Add(this.txtServDuration);
            this.pnlDeleteServ.Controls.Add(this.lblCost);
            this.pnlDeleteServ.Controls.Add(this.txtServCost);
            this.pnlDeleteServ.Controls.Add(this.lblServDuration);
            this.pnlDeleteServ.Controls.Add(this.lblDesc);
            this.pnlDeleteServ.Controls.Add(this.txtDesc);
            this.pnlDeleteServ.Controls.Add(this.btnDelete);
            this.pnlDeleteServ.Location = new System.Drawing.Point(38, 127);
            this.pnlDeleteServ.Name = "pnlDeleteServ";
            this.pnlDeleteServ.Size = new System.Drawing.Size(388, 302);
            this.pnlDeleteServ.TabIndex = 4;
            this.pnlDeleteServ.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDeleteServ_Paint);
            // 
            // txtServDuration
            // 
            this.txtServDuration.Location = new System.Drawing.Point(139, 129);
            this.txtServDuration.Name = "txtServDuration";
            this.txtServDuration.ReadOnly = true;
            this.txtServDuration.Size = new System.Drawing.Size(98, 24);
            this.txtServDuration.TabIndex = 14;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(76, 190);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(46, 19);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "Cost:";
            // 
            // txtServCost
            // 
            this.txtServCost.Location = new System.Drawing.Point(139, 187);
            this.txtServCost.Name = "txtServCost";
            this.txtServCost.ReadOnly = true;
            this.txtServCost.Size = new System.Drawing.Size(98, 24);
            this.txtServCost.TabIndex = 12;
            // 
            // lblServDuration
            // 
            this.lblServDuration.AutoSize = true;
            this.lblServDuration.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServDuration.Location = new System.Drawing.Point(45, 132);
            this.lblServDuration.Name = "lblServDuration";
            this.lblServDuration.Size = new System.Drawing.Size(77, 19);
            this.lblServDuration.TabIndex = 11;
            this.lblServDuration.Text = "Duration:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(27, 45);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(98, 19);
            this.lblDesc.TabIndex = 9;
            this.lblDesc.Text = "Description:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(139, 42);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(147, 58);
            this.txtDesc.TabIndex = 8;
            this.txtDesc.WordWrap = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(257, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(74, 71);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(87, 19);
            this.lblServices.TabIndex = 1;
            this.lblServices.Text = "Service ID:";
            // 
            // cmbServices
            // 
            this.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(178, 68);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(139, 26);
            this.cmbServices.TabIndex = 0;
            this.cmbServices.SelectedIndexChanged += new System.EventHandler(this.cmbServices_SelectedIndexChanged);
            // 
            // lblDeleteServlbl
            // 
            this.lblDeleteServlbl.AutoSize = true;
            this.lblDeleteServlbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteServlbl.Location = new System.Drawing.Point(74, 116);
            this.lblDeleteServlbl.Name = "lblDeleteServlbl";
            this.lblDeleteServlbl.Size = new System.Drawing.Size(107, 19);
            this.lblDeleteServlbl.TabIndex = 0;
            this.lblDeleteServlbl.Text = "Delete Service";
            // 
            // frmDeleteService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(476, 453);
            this.Controls.Add(this.lblDeleteServlbl);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.cmbServices);
            this.Controls.Add(this.pnlDeleteServ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDeleteService";
            this.Text = "Delete Service";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlDeleteServ.ResumeLayout(false);
            this.pnlDeleteServ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.Panel pnlDeleteServ;
        private System.Windows.Forms.Label lblDeleteServlbl;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtServCost;
        private System.Windows.Forms.Label lblServDuration;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtServDuration;
    }
}

