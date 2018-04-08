using System;
using System.Windows.Forms;
using System.Data.SQLite;
using GeziRehberi.sinif.db;



namespace GeziRehberi
{
    public partial class Anasayfa : MetroFramework.Forms.MetroForm
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
             toplamyer.Text = db.ToplamYer();
             toplamkategori.Text = db.ToplamKategori();

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Yerler frm = new Yerler();
            frm.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Favorilerim frm = new Favorilerim();
            frm.Show();
        }

        private void sansli_Click(object sender, EventArgs e)
        {
            Detay frm = new Detay();
            Random rnd = new Random();
            int sayi = rnd.Next(1,1068);
            frm.id = sayi.ToString();
            frm.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            GezdigimYerler frm = new GezdigimYerler();
            frm.Show();
        }
    }
}
