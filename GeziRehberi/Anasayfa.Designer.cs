namespace GeziRehberi
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.toplamyer = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.toplamkategori = new MetroFramework.Controls.MetroTile();
            this.sansli = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroTile3);
            this.metroPanel1.Controls.Add(this.metroTile2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 138);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(3, 49);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(194, 40);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile2.TabIndex = 2;
            this.metroTile2.Text = "Favorilerim";
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // toplamyer
            // 
            this.toplamyer.Location = new System.Drawing.Point(249, 63);
            this.toplamyer.Name = "toplamyer";
            this.toplamyer.Size = new System.Drawing.Size(75, 48);
            this.toplamyer.Style = MetroFramework.MetroColorStyle.Orange;
            this.toplamyer.TabIndex = 2;
            this.toplamyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toplamyer.UseMnemonic = false;
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(26, 66);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(194, 40);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Yerler";
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // toplamkategori
            // 
            this.toplamkategori.Location = new System.Drawing.Point(363, 63);
            this.toplamkategori.Name = "toplamkategori";
            this.toplamkategori.Size = new System.Drawing.Size(75, 48);
            this.toplamkategori.Style = MetroFramework.MetroColorStyle.Orange;
            this.toplamkategori.TabIndex = 3;
            this.toplamkategori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sansli
            // 
            this.sansli.Location = new System.Drawing.Point(249, 134);
            this.sansli.Name = "sansli";
            this.sansli.Size = new System.Drawing.Size(189, 67);
            this.sansli.Style = MetroFramework.MetroColorStyle.Orange;
            this.sansli.TabIndex = 4;
            this.sansli.Text = "Kendimi Şanslı Hissediyorum";
            this.sansli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sansli.Click += new System.EventHandler(this.sansli_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(3, 95);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(194, 40);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile3.TabIndex = 3;
            this.metroTile3.Text = "Gezdiğim Yerler";
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 222);
            this.Controls.Add(this.sansli);
            this.Controls.Add(this.toplamkategori);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.toplamyer);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 222);
            this.MinimumSize = new System.Drawing.Size(465, 222);
            this.Name = "Anasayfa";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Gezi Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile toplamyer;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile toplamkategori;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile sansli;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}

