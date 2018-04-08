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
    public partial class GezdigimYerDetay : MetroFramework.Forms.MetroForm
    {
        public GezdigimYerDetay()
        {
            InitializeComponent();
        }
        public string id { get; set; }
        private void GezdigimYerDetay_Load(object sender, EventArgs e)
        {
            DataTable dt = db.DetayGetir(Convert.ToInt32(id));
            this.Text = dt.Rows[0].Field<String>("name").ToString();
            not.Text = dt.Rows[0].Field<String>("notlarim").ToString();
        }

        private void detay_Click(object sender, EventArgs e)
        {
            Detay frm = new Detay();
            frm.id = this.id;
            frm.Show();
        }

        private void notkaydet_Click(object sender, EventArgs e)
        {
            db.NotKaydet(int.Parse(this.id),not.Text);
        }
    }
}
