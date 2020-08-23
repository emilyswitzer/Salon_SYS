namespace SalonSYS
{
    partial class frmAddService
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
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.txtServiceDesc = new System.Windows.Forms.TextBox();
            this.lblServiceDesc = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnClearService = new System.Windows.Forms.Button();
            this.lblServiceDuration = new System.Windows.Forms.Label();
            this.cmbServDuration = new System.Windows.Forms.ComboBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddServicelbl = new System.Windows.Forms.Label();
            this.grdServices = new System.Windows.Forms.DataGridView();
            this.mnuMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).BeginInit();
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
            this.mnuMain.Size = new System.Drawing.Size(1084, 31);
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
            // txtServiceID
            // 
            this.txtServiceID.Enabled = false;
            this.txtServiceID.Location = new System.Drawing.Point(175, 40);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(51, 24);
            this.txtServiceID.TabIndex = 3;
            this.txtServiceID.Text = "   ";
            this.txtServiceID.TextChanged += new System.EventHandler(this.txtServiceID_TextChanged);
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Enabled = false;
            this.lblServiceID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceID.Location = new System.Drawing.Point(70, 43);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(91, 19);
            this.lblServiceID.TabIndex = 7;
            this.lblServiceID.Text = "Service ID: ";
            // 
            // txtServiceDesc
            // 
            this.txtServiceDesc.Location = new System.Drawing.Point(175, 84);
            this.txtServiceDesc.MaxLength = 3276755;
            this.txtServiceDesc.Multiline = true;
            this.txtServiceDesc.Name = "txtServiceDesc";
            this.txtServiceDesc.Size = new System.Drawing.Size(190, 52);
            this.txtServiceDesc.TabIndex = 2;
            this.txtServiceDesc.WordWrap = false;
            this.txtServiceDesc.TextChanged += new System.EventHandler(this.txtServiceDesc_TextChanged);
            // 
            // lblServiceDesc
            // 
            this.lblServiceDesc.AutoSize = true;
            this.lblServiceDesc.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDesc.Location = new System.Drawing.Point(59, 87);
            this.lblServiceDesc.Name = "lblServiceDesc";
            this.lblServiceDesc.Size = new System.Drawing.Size(102, 19);
            this.lblServiceDesc.TabIndex = 9;
            this.lblServiceDesc.Text = "Description: ";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(279, 256);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(86, 34);
            this.btnAddService.TabIndex = 7;
            this.btnAddService.Text = "Submit";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnClearService
            // 
            this.btnClearService.Location = new System.Drawing.Point(175, 256);
            this.btnClearService.Name = "btnClearService";
            this.btnClearService.Size = new System.Drawing.Size(87, 34);
            this.btnClearService.TabIndex = 6;
            this.btnClearService.Text = "Clear";
            this.btnClearService.UseVisualStyleBackColor = true;
            this.btnClearService.Click += new System.EventHandler(this.btnClearService_Click);
            // 
            // lblServiceDuration
            // 
            this.lblServiceDuration.AutoSize = true;
            this.lblServiceDuration.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDuration.Location = new System.Drawing.Point(73, 155);
            this.lblServiceDuration.Name = "lblServiceDuration";
            this.lblServiceDuration.Size = new System.Drawing.Size(81, 19);
            this.lblServiceDuration.TabIndex = 13;
            this.lblServiceDuration.Text = "Duration: ";
            // 
            // cmbServDuration
            // 
            this.cmbServDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServDuration.FormattingEnabled = true;
            this.cmbServDuration.Location = new System.Drawing.Point(175, 154);
            this.cmbServDuration.Name = "cmbServDuration";
            this.cmbServDuration.Size = new System.Drawing.Size(111, 26);
            this.cmbServDuration.TabIndex = 4;
            this.cmbServDuration.SelectedIndexChanged += new System.EventHandler(this.cmbServDuration_SelectedIndexChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(175, 203);
            this.txtCost.MaxLength = 3;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(111, 24);
            this.txtCost.TabIndex = 5;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            this.txtCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost_KeyPress);
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceCost.Location = new System.Drawing.Point(101, 203);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(50, 19);
            this.lblServiceCost.TabIndex = 16;
            this.lblServiceCost.Text = "Cost: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblServiceCost);
            this.panel1.Controls.Add(this.btnClearService);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.cmbServDuration);
            this.panel1.Controls.Add(this.lblServiceDuration);
            this.panel1.Controls.Add(this.lblServiceDesc);
            this.panel1.Controls.Add(this.txtServiceDesc);
            this.panel1.Controls.Add(this.lblServiceID);
            this.panel1.Controls.Add(this.txtServiceID);
            this.panel1.Location = new System.Drawing.Point(50, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 338);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAddServicelbl
            // 
            this.lblAddServicelbl.AutoSize = true;
            this.lblAddServicelbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddServicelbl.Location = new System.Drawing.Point(79, 52);
            this.lblAddServicelbl.Name = "lblAddServicelbl";
            this.lblAddServicelbl.Size = new System.Drawing.Size(93, 19);
            this.lblAddServicelbl.TabIndex = 17;
            this.lblAddServicelbl.Text = "Add Service";
            // 
            // grdServices
            // 
            this.grdServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServices.Location = new System.Drawing.Point(594, 88);
            this.grdServices.Name = "grdServices";
            this.grdServices.RowTemplate.Height = 24;
            this.grdServices.Size = new System.Drawing.Size(402, 239);
            this.grdServices.TabIndex = 18;
            this.grdServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1084, 428);
            this.Controls.Add(this.grdServices);
            this.Controls.Add(this.lblAddServicelbl);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddService";
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.TextBox txtServiceDesc;
        private System.Windows.Forms.Label lblServiceDesc;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnClearService;
        private System.Windows.Forms.Label lblServiceDuration;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblServiceCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddServicelbl;
        public System.Windows.Forms.ComboBox cmbServDuration;
        private System.Windows.Forms.DataGridView grdServices;
    }
}

