using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataAccessLayer.Concrete;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.KitapTuru
{
    public partial class KitapTuruEkle : Form
    {
       
        public KitapTuruEkle()
        {
            InitializeComponent();
        }
        private void KitapTuruEkle_Load(object sender, EventArgs e)
        {
            KayıtYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ktpTuruEkle_Click(object sender, EventArgs e)
        {
            KitapTuruEklee();
        }
        public void KitapTuruEklee()
        {
            DataAccessLayer.KitapTuru kitapTuru = new DataAccessLayer.KitapTuru()
            {
                Adi = AdıText.Text,
                KayitYapan = KayıtYapanText.Text,
                KayitTarihi = DateTime.Now
            };
            ClientHelper.PostEntity("KitapTuru", kitapTuru);
            var mfrm = (FrmKitapTuru)Application.OpenForms["FrmKitapTuru"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }

      
    }
}
