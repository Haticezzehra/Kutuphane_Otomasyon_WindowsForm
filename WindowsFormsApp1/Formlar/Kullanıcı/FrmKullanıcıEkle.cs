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

namespace WindowsFormsApp1.Formlar.Kullanıcı
{
    public partial class FrmKullanıcıEkle : Form
    {
        public FrmKullanıcıEkle()
        {
            InitializeComponent();
        }
        private void FrmKullanıcıEkle_Load(object sender, EventArgs e)
        {
            KayıtYapanText.Text = KayıtYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void KullanıcıEkle_Click(object sender, EventArgs e)
        {
            KullanıcıEklee();

        }
        private void iptalEt_Click(object sender, EventArgs e)
        {
            KayıtYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
            this.Close();
        }
        public void KullanıcıEklee()
        {
            DataAccessLayer.Kullanici kullanıcı = new DataAccessLayer.Kullanici()
            {
                KullaniciAdi = KullanıcıAdıText.Text,
                Parola = ParolaText.Text,
                KayıtYapan = KayıtYapanText.Text,
                KayıtTarihi = DateTime.Now,
            };
            ClientHelper.PostEntity("Kitap", kullanıcı);
            var mfrm = (Formlar.Kullanıcı.Kullanıcı)Application.OpenForms["Kullanıcı"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }   


    }
}
