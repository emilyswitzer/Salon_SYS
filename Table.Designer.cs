namespace SalonSYS
{
    partial class frmTable
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
            this.pnlTables = new System.Windows.Forms.Panel();
            this.lblAvailabilityTables = new System.Windows.Forms.Label();
            this.picTables = new System.Windows.Forms.PictureBox();
            this.pnlTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTables)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTables
            // 
            this.pnlTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTables.Controls.Add(this.picTables);
            this.pnlTables.Location = new System.Drawing.Point(46, 45);
            this.pnlTables.Name = "pnlTables";
            this.pnlTables.Size = new System.Drawing.Size(295, 338);
            this.pnlTables.TabIndex = 1;
            // 
            // lblAvailabilityTables
            // 
            this.lblAvailabilityTables.AutoSize = true;
            this.lblAvailabilityTables.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityTables.Location = new System.Drawing.Point(76, 37);
            this.lblAvailabilityTables.Name = "lblAvailabilityTables";
            this.lblAvailabilityTables.Size = new System.Drawing.Size(126, 19);
            this.lblAvailabilityTables.TabIndex = 0;
            this.lblAvailabilityTables.Text = "Availability Table";
            // 
            // picTables
            // 
            this.picTables.BackgroundImage = global::SalonSYS.Properties.Resources.AVAILABILITYSLOTS;
            this.picTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTables.Location = new System.Drawing.Point(33, 22);
            this.picTables.Name = "picTables";
            this.picTables.Size = new System.Drawing.Size(226, 297);
            this.picTables.TabIndex = 0;
            this.picTables.TabStop = false;
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(241)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(384, 444);
            this.Controls.Add(this.lblAvailabilityTables);
            this.Controls.Add(this.pnlTables);
            this.Name = "frmTable";
            this.Text = "Table";
            this.pnlTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTables;
        private System.Windows.Forms.PictureBox picTables;
        private System.Windows.Forms.Label lblAvailabilityTables;
    }
}