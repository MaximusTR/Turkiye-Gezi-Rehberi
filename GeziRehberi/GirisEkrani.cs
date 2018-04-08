using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeziRehberi
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        Thread thread1;

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            thread1 = new Thread(new ThreadStart(bar));
            System.Windows.Forms.Form.CheckForIllegalCrossThreadCalls = false;
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();           
        }

        public void bar()
            {
            while (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                Thread.Sleep(25);
            }           
            Anasayfa frm = new Anasayfa();
            this.Close();
            frm.ShowDialog();
            thread1.Abort();
        }
    }
}
