namespace GeziRehberi
{
    partial class Detay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detay));
            this.aciklama = new System.Windows.Forms.WebBrowser();
            this.adres = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.harita = new System.Windows.Forms.PictureBox();
            this.favori = new MetroFramework.Controls.MetroTile();
            this.mail = new MetroFramework.Controls.MetroTextBox();
            this.mailyazi = new MetroFramework.Controls.MetroLabel();
            this.link = new MetroFramework.Controls.MetroLink();
            this.telefon = new MetroFramework.Controls.MetroTextBox();
            this.telefonyazi = new MetroFramework.Controls.MetroLabel();
            this.tur = new MetroFramework.Controls.MetroTextBox();
            this.turyazi = new MetroFramework.Controls.MetroLabel();
            this.adresyazi = new MetroFramework.Controls.MetroLabel();
            this.hotel = new System.Windows.Forms.WebBrowser();
            this.gezdigimyer = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.harita)).BeginInit();
            this.SuspendLayout();
            // 
            // aciklama
            // 
            this.aciklama.AllowWebBrowserDrop = false;
            this.aciklama.Location = new System.Drawing.Point(14, 63);
            this.aciklama.MinimumSize = new System.Drawing.Size(20, 20);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(518, 193);
            this.aciklama.TabIndex = 2;
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(312, 131);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            this.adres.Size = new System.Drawing.Size(200, 116);
            this.adres.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gezdigimyer);
            this.groupBox1.Controls.Add(this.harita);
            this.groupBox1.Controls.Add(this.favori);
            this.groupBox1.Controls.Add(this.mail);
            this.groupBox1.Controls.Add(this.mailyazi);
            this.groupBox1.Controls.Add(this.link);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.telefonyazi);
            this.groupBox1.Controls.Add(this.tur);
            this.groupBox1.Controls.Add(this.turyazi);
            this.groupBox1.Controls.Add(this.adresyazi);
            this.groupBox1.Controls.Add(this.adres);
            this.groupBox1.Location = new System.Drawing.Point(14, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 320);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yer Bilgileri";
            // 
            // harita
            // 
            this.harita.InitialImage = ((System.Drawing.Image)(resources.GetObject("harita.InitialImage")));
            this.harita.Location = new System.Drawing.Point(9, 131);
            this.harita.Name = "harita";
            this.harita.Size = new System.Drawing.Size(297, 183);
            this.harita.TabIndex = 13;
            this.harita.TabStop = false;
            // 
            // favori
            // 
            this.favori.Location = new System.Drawing.Point(312, 285);
            this.favori.Name = "favori";
            this.favori.Size = new System.Drawing.Size(200, 29);
            this.favori.Style = MetroFramework.MetroColorStyle.Red;
            this.favori.TabIndex = 12;
            this.favori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.favori.Click += new System.EventHandler(this.favori_Click);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(6, 97);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(200, 23);
            this.mail.TabIndex = 11;
            // 
            // mailyazi
            // 
            this.mailyazi.AutoSize = true;
            this.mailyazi.Location = new System.Drawing.Point(6, 75);
            this.mailyazi.Name = "mailyazi";
            this.mailyazi.Size = new System.Drawing.Size(75, 19);
            this.mailyazi.TabIndex = 10;
            this.mailyazi.Text = "Mail Adresi";
            // 
            // link
            // 
            this.link.Location = new System.Drawing.Point(437, 93);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(75, 23);
            this.link.TabIndex = 9;
            this.link.Text = "WebSite";
            this.link.Click += new System.EventHandler(this.link_Click);
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(312, 38);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(200, 23);
            this.telefon.TabIndex = 8;
            // 
            // telefonyazi
            // 
            this.telefonyazi.AutoSize = true;
            this.telefonyazi.Location = new System.Drawing.Point(312, 16);
            this.telefonyazi.Name = "telefonyazi";
            this.telefonyazi.Size = new System.Drawing.Size(55, 19);
            this.telefonyazi.TabIndex = 7;
            this.telefonyazi.Text = "Telefon:";
            // 
            // tur
            // 
            this.tur.Location = new System.Drawing.Point(6, 38);
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            this.tur.Size = new System.Drawing.Size(200, 23);
            this.tur.TabIndex = 6;
            // 
            // turyazi
            // 
            this.turyazi.AutoSize = true;
            this.turyazi.Location = new System.Drawing.Point(6, 16);
            this.turyazi.Name = "turyazi";
            this.turyazi.Size = new System.Drawing.Size(31, 19);
            this.turyazi.TabIndex = 5;
            this.turyazi.Text = "Tür:";
            // 
            // adresyazi
            // 
            this.adresyazi.AutoSize = true;
            this.adresyazi.Location = new System.Drawing.Point(312, 97);
            this.adresyazi.Name = "adresyazi";
            this.adresyazi.Size = new System.Drawing.Size(46, 19);
            this.adresyazi.TabIndex = 4;
            this.adresyazi.Text = "Adres:";
            // 
            // hotel
            // 
            this.hotel.AllowWebBrowserDrop = false;
            this.hotel.Location = new System.Drawing.Point(538, 36);
            this.hotel.MinimumSize = new System.Drawing.Size(20, 20);
            this.hotel.Name = "hotel";
            this.hotel.Size = new System.Drawing.Size(414, 540);
            this.hotel.TabIndex = 5;
            this.hotel.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // gezdigimyer
            // 
            this.gezdigimyer.Location = new System.Drawing.Point(312, 253);
            this.gezdigimyer.Name = "gezdigimyer";
            this.gezdigimyer.Size = new System.Drawing.Size(200, 29);
            this.gezdigimyer.Style = MetroFramework.MetroColorStyle.Red;
            this.gezdigimyer.TabIndex = 14;
            this.gezdigimyer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gezdigimyer.Click += new System.EventHandler(this.gezdigimyer_Click);
            // 
            // Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 599);
            this.Controls.Add(this.hotel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aciklama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(975, 599);
            this.MinimumSize = new System.Drawing.Size(975, 599);
            this.Name = "Detay";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Detay";
            this.Load += new System.EventHandler(this.Detay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.harita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser aciklama;
        private MetroFramework.Controls.MetroTextBox adres;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel adresyazi;
        private MetroFramework.Controls.MetroLabel turyazi;
        private MetroFramework.Controls.MetroTextBox tur;
        private MetroFramework.Controls.MetroTextBox telefon;
        private MetroFramework.Controls.MetroLabel telefonyazi;
        private MetroFramework.Controls.MetroLink link;
        private MetroFramework.Controls.MetroTextBox mail;
        private MetroFramework.Controls.MetroLabel mailyazi;
        private MetroFramework.Controls.MetroTile favori;
        private System.Windows.Forms.WebBrowser hotel;
        private System.Windows.Forms.PictureBox harita;
        private MetroFramework.Controls.MetroTile gezdigimyer;
    }
}