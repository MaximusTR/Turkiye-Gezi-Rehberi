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

namespace GeziRehberi
{
    public partial class Favorilerim : MetroFramework.Forms.MetroForm
    {
        public Favorilerim()
        {
            InitializeComponent();
        }

        private void Favorilerim_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.FavoriGetir(); 
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
