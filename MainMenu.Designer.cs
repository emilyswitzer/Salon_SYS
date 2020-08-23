namespace SalonSYS
{
    partial class frmMainMenu
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
            this.mnuHome = new System.Windows.Forms.MenuStrip();
            this.mnuCurrentHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangeService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuappts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeAppt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelAppt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChkAvail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenSerAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHome.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuHome
            // 
            this.mnuHome.AutoSize = false;
            this.mnuHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(142)))));
            this.mnuHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCurrentHome,
            this.mnuServices,
            this.mnuappts,
            this.mnuEmployees,
            this.mnuAdmin});
            this.mnuHome.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.mnuHome.Location = new System.Drawing.Point(0, 31);
            this.mnuHome.MaximumSize = new System.Drawing.Size(169, 0);
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Padding = new System.Windows.Forms.Padding(7, 110, 0, 2);
            this.mnuHome.Size = new System.Drawing.Size(169, 505);
            this.mnuHome.TabIndex = 0;
            this.mnuHome.Text = "menuStrip1";
            this.mnuHome.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuHome_ItemClicked);
            // 
            // mnuCurrentHome
            // 
            this.mnuCurrentHome.AutoSize = false;
            this.mnuCurrentHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(142)))), ((int)(((byte)(166)))));
            this.mnuCurrentHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuCurrentHome.ForeColor = System.Drawing.Color.Snow;
            this.mnuCurrentHome.Image = global::SalonSYS.Properties.Resources.mainmenupic;
            this.mnuCurrentHome.Name = "mnuCurrentHome";
            this.mnuCurrentHome.Padding = new System.Windows.Forms.Padding(0, 2, 4, 0);
            this.mnuCurrentHome.Size = new System.Drawing.Size(175, 60);
            this.mnuCurrentHome.Text = "Home            ";
            this.mnuCurrentHome.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // mnuServices
            // 
            this.mnuServices.AutoSize = false;
            this.mnuServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(181)))));
            this.mnuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddService,
            this.mnuChangeService,
            this.mnuDeleteService});
            this.mnuServices.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuServices.ForeColor = System.Drawing.Color.DimGray;
            this.mnuServices.Image = global::SalonSYS.Properties.Resources.servicemenupic;
            this.mnuServices.Name = "mnuServices";
            this.mnuServices.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuServices.Size = new System.Drawing.Size(175, 60);
            this.mnuServices.Text = "Services          ";
            this.mnuServices.MouseHover += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // mnuAddService
            // 
            this.mnuAddService.BackColor = System.Drawing.Color.Linen;
            this.mnuAddService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mnuAddService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuAddService.Name = "mnuAddService";
            this.mnuAddService.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mnuAddService.Size = new System.Drawing.Size(203, 30);
            this.mnuAddService.Text = "Add Service";
            this.mnuAddService.Click += new System.EventHandler(this.mnuAddService_Click);
            // 
            // mnuChangeService
            // 
            this.mnuChangeService.BackColor = System.Drawing.Color.Linen;
            this.mnuChangeService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuChangeService.Name = "mnuChangeService";
            this.mnuChangeService.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.mnuChangeService.Size = new System.Drawing.Size(203, 34);
            this.mnuChangeService.Text = "Change Service";
            this.mnuChangeService.Click += new System.EventHandler(this.mnuChangeService_Click);
            // 
            // mnuDeleteService
            // 
            this.mnuDeleteService.BackColor = System.Drawing.Color.Linen;
            this.mnuDeleteService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mnuDeleteService.Name = "mnuDeleteService";
            this.mnuDeleteService.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.mnuDeleteService.Size = new System.Drawing.Size(203, 34);
            this.mnuDeleteService.Text = "Delete Service";
            this.mnuDeleteService.Click += new System.EventHandler(this.mnuDeleteService_Click);
            // 
            // mnuappts
            // 
            this.mnuappts.AutoSize = false;
            this.mnuappts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.mnuappts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeAppt,
            this.mnuCancelAppt});
            this.mnuappts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuappts.ForeColor = System.Drawing.Color.DimGray;
            this.mnuappts.Image = global::SalonSYS.Properties.Resources.apptmenupic;
            this.mnuappts.Name = "mnuappts";
            this.mnuappts.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuappts.Size = new System.Drawing.Size(175, 60);
            this.mnuappts.Text = "Appointments";
            // 
            // mnuMakeAppt
            // 
            this.mnuMakeAppt.BackColor = System.Drawing.Color.Linen;
            this.mnuMakeAppt.Name = "mnuMakeAppt";
            this.mnuMakeAppt.Size = new System.Drawing.Size(243, 28);
            this.mnuMakeAppt.Text = "Make Appointment";
            this.mnuMakeAppt.Click += new System.EventHandler(this.mnuMakeAppt_Click);
            // 
            // mnuCancelAppt
            // 
            this.mnuCancelAppt.BackColor = System.Drawing.Color.Linen;
            this.mnuCancelAppt.Name = "mnuCancelAppt";
            this.mnuCancelAppt.Size = new System.Drawing.Size(243, 28);
            this.mnuCancelAppt.Text = "Cancel Appointment";
            this.mnuCancelAppt.Click += new System.EventHandler(this.mnuCancelAppt_Click);
            // 
            // mnuEmployees
            // 
            this.mnuEmployees.AutoSize = false;
            this.mnuEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(209)))), ((int)(((byte)(181)))));
            this.mnuEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddEmployee,
            this.mnuDeleteEmployee});
            this.mnuEmployees.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuEmployees.ForeColor = System.Drawing.Color.DimGray;
            this.mnuEmployees.Image = global::SalonSYS.Properties.Resources.employeesmenupic;
            this.mnuEmployees.Name = "mnuEmployees";
            this.mnuEmployees.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.mnuEmployees.Size = new System.Drawing.Size(175, 60);
            this.mnuEmployees.Text = "Employees     ";
            this.mnuEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuAddEmployee
            // 
            this.mnuAddEmployee.BackColor = System.Drawing.Color.Linen;
            this.mnuAddEmployee.Name = "mnuAddEmployee";
            this.mnuAddEmployee.Size = new System.Drawing.Size(235, 28);
            this.mnuAddEmployee.Text = "Add New Employee";
            this.mnuAddEmployee.Click += new System.EventHandler(this.mnuAddEmployee_Click);
            // 
            // mnuDeleteEmployee
            // 
            this.mnuDeleteEmployee.BackColor = System.Drawing.Color.Linen;
            this.mnuDeleteEmployee.Name = "mnuDeleteEmployee";
            this.mnuDeleteEmployee.Size = new System.Drawing.Size(235, 28);
            this.mnuDeleteEmployee.Text = "Delete Employee";
            this.mnuDeleteEmployee.Click += new System.EventHandler(this.mnuDeleteEmployee_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.AutoSize = false;
            this.mnuAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChkAvail,
            this.mnuRevAnalysis,
            this.mnuGenSerAnalysis});
            this.mnuAdmin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.mnuAdmin.Image = global::SalonSYS.Properties.Resources.adminmenupic;
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(175, 60);
            this.mnuAdmin.Text = "Admin          ";
            // 
            // mnuChkAvail
            // 
            this.mnuChkAvail.BackColor = System.Drawing.Color.Linen;
            this.mnuChkAvail.Name = "mnuChkAvail";
            this.mnuChkAvail.Size = new System.Drawing.Size(291, 28);
            this.mnuChkAvail.Text = "Check Availability";
            this.mnuChkAvail.Click += new System.EventHandler(this.mnuChkAvail_Click);
            // 
            // mnuRevAnalysis
            // 
            this.mnuRevAnalysis.BackColor = System.Drawing.Color.Linen;
            this.mnuRevAnalysis.Name = "mnuRevAnalysis";
            this.mnuRevAnalysis.Size = new System.Drawing.Size(291, 28);
            this.mnuRevAnalysis.Text = "Generate Revenue Analysis";
            this.mnuRevAnalysis.Click += new System.EventHandler(this.mnuRevAnalysis_Click);
            // 
            // mnuGenSerAnalysis
            // 
            this.mnuGenSerAnalysis.BackColor = System.Drawing.Color.Linen;
            this.mnuGenSerAnalysis.Name = "mnuGenSerAnalysis";
            this.mnuGenSerAnalysis.Size = new System.Drawing.Size(291, 28);
            this.mnuGenSerAnalysis.Text = "Generate Service Analysis";
            this.mnuGenSerAnalysis.Click += new System.EventHandler(this.mnuGenSerAnalysis_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(140)))), ((int)(((byte)(142)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(169, 144);
            this.pnlLogo.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImage = global::SalonSYS.Properties.Resources.Untitled;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(-40, 17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(226, 128);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
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
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::SalonSYS.Properties.Resources.bg_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 536);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.mnuHome);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.mnuHome;
            this.Name = "frmMainMenu";
            this.Text = "SalonSYS - Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuHome.ResumeLayout(false);
            this.mnuHome.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuCurrentHome;
        private System.Windows.Forms.ToolStripMenuItem mnuServices;
        private System.Windows.Forms.ToolStripMenuItem mnuappts;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployees;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ToolStripMenuItem mnuAddService;
        private System.Windows.Forms.ToolStripMenuItem mnuChangeService;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteService;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeAppt;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelAppt;
        private System.Windows.Forms.ToolStripMenuItem mnuAddEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteEmployee;
        private System.Windows.Forms.ToolStripMenuItem mnuChkAvail;
        private System.Windows.Forms.ToolStripMenuItem mnuRevAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuGenSerAnalysis;
    }
}

