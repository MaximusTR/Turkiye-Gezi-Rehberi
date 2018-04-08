using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeziRehberi.sinif.db;
using System.Data.SQLite;

namespace GeziRehberi
{
    public partial class Yerler : MetroFramework.Forms.MetroForm
    {
        public Yerler()
        {
            InitializeComponent();
        }

        private void Yerler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.YerlerGetir(0);          
            DataTable dt = db.KategoriGetir();
            kategoriler.Items.Insert(0,"Tümünü Seç");            
            kategoriler.SelectedIndex = 0;
            foreach (DataRow rows in dt.Rows)
            {
                kategoriler.Items.Insert(Convert.ToInt32(rows["id"].ToString()),rows["name"].ToString());                
            }
          

        }

        private void kategorigetir_Click(object sender, EventArgs e)
        {            
            dataGridView1.DataSource = db.YerlerGetir(kategoriler.SelectedIndex);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string deger = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            Detay frm = new Detay();
            frm.id = deger;
            frm.Show();
            
        }
    }
}
