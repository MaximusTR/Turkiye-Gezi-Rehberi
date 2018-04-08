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
using GeziRehberi.sinif.islem;
using System.IO;


namespace GeziRehberi
{
    public partial class Detay : MetroFramework.Forms.MetroForm
    {
        public Detay()
        {
            InitializeComponent();
        }

        public string id { get; set; }

        private void Detay_Load(object sender, EventArgs e)
        {
            DataTable dt = db.DetayGetir(Convert.ToInt32(id));
            aciklama.DocumentText = dt.Rows[0].Field<String>("description").ToString();
            this.Text = dt.Rows[0].Field<String>("name").ToString();            
            adres.Text = dt.Rows[0].Field<String>("address").ToString();
            tur.Text = dt.Rows[0].Field<String>("intro").ToString();
            telefon.Text = dt.Rows[0].Field<String>("phone").ToString();
            mail.Text = dt.Rows[0].Field<String>("email").ToString();
            Double latitude = dt.Rows[0].Field<Double>("latitude");
            Double longitude = dt.Rows[0].Field<Double>("longitude");
            Int64 kategori_id = dt.Rows[0].Field<Int64>("category_id");
            String kategori_ad = db.KategoriGetir(kategori_id);
            kategori_ad = Stringislemler.TurkceKarakterCevir(kategori_ad).ToString().ToLower();
            if (Network.AgKontrol())
            {           
            hotel.Navigate("https://www.tatilbudur.com/yurtici-oteller/"+kategori_ad+"-otelleri");
            harita.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?center="+latitude+","+longitude+"&zoom=17&scale=false&size=297x183&maptype=terrain&format=png&visual_refresh=true&markers=size:mid%7Ccolor:0xff0000%7Clabel:%7C"+latitude+","+longitude+"";
            }
            else
            {
                harita.ImageLocation = "Resources/internetyok.jpg";
                string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                string myFile = Path.Combine(applicationDirectory, "html/internetyok.html");
                hotel.Url = new Uri("file:///" + myFile);
            }

            String favoriid = dt.Rows[0].Field<Int16>("favorite").ToString();
            if (favoriid == "0")
            {
                favori.Text = "Favorilerime Ekle";
            }
            else
            {
                favori.Text = "Favorilerimden Çıkar";
            }




            String gezdimid = dt.Rows[0].Field<Int64>("gezdim").ToString();
            if (gezdimid == "0")
            {
                gezdigimyer.Text = "Gezdiğim Yerlere Ekle";
            }
            else
            {
                gezdigimyer.Text = "Gezdiğim Yerlerden Çıkar";
            }



        }

        private void link_Click(object sender, EventArgs e)
        {
            DataTable dt = db.DetayGetir(Convert.ToInt32(id));
            if(dt.Rows[0].Field<String>("link").ToString() != null)            
            System.Diagnostics.Process.Start(dt.Rows[0].Field<String>("link").ToString());
        }

        private void favori_Click(object sender, EventArgs e)
        {
            db.favori(Convert.ToInt32(id));
            DataTable dt = db.DetayGetir(Convert.ToInt32(id));
            String favoriid = dt.Rows[0].Field<Int16>("favorite").ToString();
            if (favoriid == "0")
            {
                favori.Text = "Favorilerime Ekle";
            }
            else
            {
                favori.Text = "Favorilerimden Çıkar";
            }
        }

        private void gezdigimyer_Click(object sender, EventArgs e)
        {


            db.gezdim(Convert.ToInt32(id));
            DataTable dt = db.DetayGetir(Convert.ToInt32(id));
            String gezdimid = dt.Rows[0].Field<Int64>("gezdim").ToString();
            if (gezdimid == "0")
            {
                gezdigimyer.Text = "Gezdiğim Yerlere Ekle";
            }
            else
            {
                gezdigimyer.Text = "Gezdiğim Yerlerden Çıkar";
            }


        }
    }
}
