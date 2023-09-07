using DataAccessLayer;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.YazarFormlar
{
    public partial class YazarEkle : Form
    {

        public YazarEkle()
        {
            InitializeComponent();
        }
        private void YazarEkle_Load(object sender, EventArgs e)
        {
            KayıtYapannText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            YazarEklee();
            this.Close();
        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void YazarEklee()
        {
            Yazar yazar = new Yazar()
            {
                AdSoyad = AdıSoyadıText.Text,
                KayıtYapan = KayıtYapannText.Text,
                KayıtTarihi = DateTime.Now,
            };
            ClientHelper.PostEntity("Yazar", yazar);
            var mfrm = (FrmYazar)Application.OpenForms["FrmYazar"];
            if (mfrm != null)
                mfrm.Listele();
        }


    }
}
