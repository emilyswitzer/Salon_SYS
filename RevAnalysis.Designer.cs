namespace SalonSYS
{
    partial class frmRevAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbRevenueYear = new System.Windows.Forms.ComboBox();
            this.lblRevYear = new System.Windows.Forms.Label();
            this.pnlRevAnalysis = new System.Windows.Forms.Panel();
            this.lblRevAnalysis = new System.Windows.Forms.Label();
            this.cht18 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht16 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht17 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cht19 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mnuMain.SuspendLayout();
            this.pnlRevAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cht18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht19)).BeginInit();
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
            this.mnuMain.Size = new System.Drawing.Size(505, 31);
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
            // cmbRevenueYear
            // 
            this.cmbRevenueYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevenueYear.FormattingEnabled = true;
            this.cmbRevenueYear.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019"});
            this.cmbRevenueYear.Location = new System.Drawing.Point(211, 61);
            this.cmbRevenueYear.Name = "cmbRevenueYear";
            this.cmbRevenueYear.Size = new System.Drawing.Size(157, 26);
            this.cmbRevenueYear.TabIndex = 4;
            this.cmbRevenueYear.SelectedIndexChanged += new System.EventHandler(this.cmbRevYear_SelectedIndexChanged);
            // 
            // lblRevYear
            // 
            this.lblRevYear.AutoSize = true;
            this.lblRevYear.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevYear.Location = new System.Drawing.Point(96, 64);
            this.lblRevYear.Name = "lblRevYear";
            this.lblRevYear.Size = new System.Drawing.Size(109, 19);
            this.lblRevYear.TabIndex = 5;
            this.lblRevYear.Text = "Select a year: ";
            // 
            // pnlRevAnalysis
            // 
            this.pnlRevAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.pnlRevAnalysis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRevAnalysis.Controls.Add(this.cht19);
            this.pnlRevAnalysis.Controls.Add(this.cht17);
            this.pnlRevAnalysis.Controls.Add(this.cht16);
            this.pnlRevAnalysis.Controls.Add(this.cht18);
            this.pnlRevAnalysis.Location = new System.Drawing.Point(13, 115);
            this.pnlRevAnalysis.Name = "pnlRevAnalysis";
            this.pnlRevAnalysis.Size = new System.Drawing.Size(482, 342);
            this.pnlRevAnalysis.TabIndex = 11;
            this.pnlRevAnalysis.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRevenueAnalysis_Paint);
            // 
            // lblRevAnalysis
            // 
            this.lblRevAnalysis.AutoSize = true;
            this.lblRevAnalysis.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevAnalysis.Location = new System.Drawing.Point(49, 103);
            this.lblRevAnalysis.Name = "lblRevAnalysis";
            this.lblRevAnalysis.Size = new System.Drawing.Size(134, 20);
            this.lblRevAnalysis.TabIndex = 11;
            this.lblRevAnalysis.Text = "Revenue Analysis";
            // 
            // cht18
            // 
            this.cht18.BackColor = System.Drawing.Color.Transparent;
            chartArea4.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.cht18.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.cht18.Legends.Add(legend4);
            this.cht18.Location = new System.Drawing.Point(3, 3);
            this.cht18.Name = "cht18";
            this.cht18.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.cht18.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(114)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(149))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(87)))))};
            this.cht18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.cht18.Series.Add(series4);
            this.cht18.Size = new System.Drawing.Size(474, 341);
            this.cht18.TabIndex = 0;
            title4.Name = "CHTITLE";
            title4.Text = "Total Revenue 2018 (€)";
            this.cht18.Titles.Add(title4);
            // 
            // cht16
            // 
            this.cht16.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.cht16.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.cht16.Legends.Add(legend3);
            this.cht16.Location = new System.Drawing.Point(3, 3);
            this.cht16.Name = "cht16";
            this.cht16.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.cht16.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(114)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(149))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(87)))))};
            this.cht16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series3.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.cht16.Series.Add(series3);
            this.cht16.Size = new System.Drawing.Size(474, 341);
            this.cht16.TabIndex = 1;
            title3.Name = "CHTITLE";
            title3.Text = "Total Revenue 2016 (€)";
            this.cht16.Titles.Add(title3);
            // 
            // cht17
            // 
            this.cht17.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.cht17.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.cht17.Legends.Add(legend2);
            this.cht17.Location = new System.Drawing.Point(3, 3);
            this.cht17.Name = "cht17";
            this.cht17.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.cht17.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(114)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(149))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(87)))))};
            this.cht17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.cht17.Series.Add(series2);
            this.cht17.Size = new System.Drawing.Size(474, 341);
            this.cht17.TabIndex = 2;
            title2.Name = "CHTITLE";
            title2.Text = "Total Revenue 2017 (€)";
            this.cht17.Titles.Add(title2);
            // 
            // cht19
            // 
            this.cht19.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.cht19.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.cht19.Legends.Add(legend1);
            this.cht19.Location = new System.Drawing.Point(-14, 3);
            this.cht19.Name = "cht19";
            this.cht19.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            this.cht19.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(184)))), ((int)(((byte)(152))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(114)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(149))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(108)))), ((int)(((byte)(132))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(74)))), ((int)(((byte)(95))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(87)))))};
            this.cht19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            this.cht19.Series.Add(series1);
            this.cht19.Size = new System.Drawing.Size(505, 341);
            this.cht19.TabIndex = 3;
            title1.Name = "CHTITLE";
            title1.Text = "Total Revenue 2019 (€)";
            this.cht19.Titles.Add(title1);
            // 
            // frmRevAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(505, 472);
            this.Controls.Add(this.lblRevAnalysis);
            this.Controls.Add(this.lblRevYear);
            this.Controls.Add(this.cmbRevenueYear);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.pnlRevAnalysis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmRevAnalysis";
            this.Text = "Revenue Analysis";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.pnlRevAnalysis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cht18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cht19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cmbRevenueYear;
        private System.Windows.Forms.Label lblRevYear;
        private System.Windows.Forms.Panel pnlRevAnalysis;
        private System.Windows.Forms.Label lblRevAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht18;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht19;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht17;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht16;
    }
}

