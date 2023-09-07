using DataAccessLayer;
using DataAccessLayer.Concrete;
using Entity;
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

namespace WindowsFormsApp1.Formlar.OgrenciFormlar
{

    public partial class OgrenciEkle : Form
    {
       
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            KayıtYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OgrenciEklee();
            this.Close();
        }
        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void OgrenciEklee()
        {
            Ogrenci ogrenci = new Ogrenci()
            {

                AdSoyad = AdıSoyadıText.Text,
                Bolum = BolumText.Text,
                Sınıf = SınıfText.Text,
                KayıtYapan = KayıtYapanText.Text,
                OkulNo = OkulNoText.Text,
                KayıtTarihi = DateTime.Now,
            };

            ClientHelper.PostEntity("Ogrenci", ogrenci);
            var mfrm = (FrmOgrenci)Application.OpenForms["FrmOgrenci"];
            if (mfrm != null)
                mfrm.Listele();
        }
       
    }
}
