namespace GeziRehberi
{
    partial class Yerler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yerler));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kategoriler = new MetroFramework.Controls.MetroComboBox();
            this.kategorigetir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kategoriler
            // 
            this.kategoriler.FormattingEnabled = true;
            this.kategoriler.ItemHeight = 23;
            this.kategoriler.Location = new System.Drawing.Point(23, 63);
            this.kategoriler.Name = "kategoriler";
            this.kategoriler.Size = new System.Drawing.Size(121, 29);
            this.kategoriler.TabIndex = 1;
            // 
            // kategorigetir
            // 
            this.kategorigetir.Location = new System.Drawing.Point(150, 63);
            this.kategorigetir.Name = "kategorigetir";
            this.kategorigetir.Size = new System.Drawing.Size(94, 29);
            this.kategorigetir.TabIndex = 2;
            this.kategorigetir.Text = "Getir";
            this.kategorigetir.Click += new System.EventHandler(this.kategorigetir_Click);
            // 
            // Yerler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 375);
            this.Controls.Add(this.kategorigetir);
            this.Controls.Add(this.kategoriler);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 375);
            this.MinimumSize = new System.Drawing.Size(540, 375);
            this.Name = "Yerler";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Yerler";
            this.Load += new System.EventHandler(this.Yerler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox kategoriler;
        private MetroFramework.Controls.MetroButton kategorigetir;
    }
}