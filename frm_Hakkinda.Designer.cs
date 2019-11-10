namespace SQL_Yardimcisi
{
    partial class frm_Hakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Hakkinda));
            this.lbl_hakkinda = new System.Windows.Forms.Label();
            this.pnl_baslik = new System.Windows.Forms.Panel();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.pnl_baslik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_hakkinda
            // 
            this.lbl_hakkinda.AutoSize = true;
            this.lbl_hakkinda.Location = new System.Drawing.Point(98, 107);
            this.lbl_hakkinda.Name = "lbl_hakkinda";
            this.lbl_hakkinda.Size = new System.Drawing.Size(132, 13);
            this.lbl_hakkinda.TabIndex = 3;
            this.lbl_hakkinda.Text = "Copyright 2015 by nullovy";
            // 
            // pnl_baslik
            // 
            this.pnl_baslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(66)))), ((int)(((byte)(214)))));
            this.pnl_baslik.Controls.Add(this.lbl_baslik);
            this.pnl_baslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_baslik.Location = new System.Drawing.Point(0, 0);
            this.pnl_baslik.Name = "pnl_baslik";
            this.pnl_baslik.Size = new System.Drawing.Size(336, 62);
            this.pnl_baslik.TabIndex = 4;
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_baslik.Location = new System.Drawing.Point(123, 9);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(76, 42);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "nullovy";
            // 
            // frm_Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 129);
            this.Controls.Add(this.pnl_baslik);
            this.Controls.Add(this.lbl_hakkinda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Hakkinda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Yardımcısı - Hakkında";
            this.pnl_baslik.ResumeLayout(false);
            this.pnl_baslik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_hakkinda;
        private System.Windows.Forms.Panel pnl_baslik;
        private System.Windows.Forms.Label lbl_baslik;
    }
}