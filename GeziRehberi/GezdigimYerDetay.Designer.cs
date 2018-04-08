namespace GeziRehberi
{
    partial class GezdigimYerDetay
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
            this.not = new System.Windows.Forms.TextBox();
            this.detay = new MetroFramework.Controls.MetroTile();
            this.notkaydet = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // not
            // 
            this.not.Location = new System.Drawing.Point(23, 63);
            this.not.Multiline = true;
            this.not.Name = "not";
            this.not.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.not.Size = new System.Drawing.Size(500, 169);
            this.not.TabIndex = 0;
            // 
            // detay
            // 
            this.detay.Location = new System.Drawing.Point(23, 238);
            this.detay.Name = "detay";
            this.detay.Size = new System.Drawing.Size(75, 23);
            this.detay.Style = MetroFramework.MetroColorStyle.Orange;
            this.detay.TabIndex = 2;
            this.detay.Text = "Detay";
            this.detay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.detay.Click += new System.EventHandler(this.detay_Click);
            // 
            // notkaydet
            // 
            this.notkaydet.Location = new System.Drawing.Point(448, 238);
            this.notkaydet.Name = "notkaydet";
            this.notkaydet.Size = new System.Drawing.Size(75, 23);
            this.notkaydet.Style = MetroFramework.MetroColorStyle.Orange;
            this.notkaydet.TabIndex = 1;
            this.notkaydet.Text = "Kaydet";
            this.notkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.notkaydet.Click += new System.EventHandler(this.notkaydet_Click);
            // 
            // GezdigimYerDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 280);
            this.Controls.Add(this.detay);
            this.Controls.Add(this.notkaydet);
            this.Controls.Add(this.not);
            this.Name = "GezdigimYerDetay";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Gezdiğim Yer Detay";
            this.Load += new System.EventHandler(this.GezdigimYerDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox not;
        private MetroFramework.Controls.MetroTile detay;
        private MetroFramework.Controls.MetroTile notkaydet;
    }
}