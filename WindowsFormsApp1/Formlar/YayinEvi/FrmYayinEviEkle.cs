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

namespace WindowsFormsApp1.Formlar.YayinEvi
{
    public partial class FrmYayinEviEkle : Form
    {
       
        public FrmYayinEviEkle()
        {
            InitializeComponent();
        }
        private void FrmYayinEviEkle_Load(object sender, EventArgs e)
        {
            KayıtYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void YayinEviEkle_Click(object sender, EventArgs e)
        {
            Ekle();

        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Ekle()
        {
            DataAccessLayer.YayinEvi yayinEvi = new DataAccessLayer.YayinEvi()
            {
                Adi = AdıText.Text,
                KayitYapan = KayıtYapanText.Text,
                KayitTarihi = DateTime.Now,
            };

            ClientHelper.PostEntity("YayinEvi", yayinEvi);
            var mfrm = (FrmYayinEvi)Application.OpenForms["FrmYayinEvi"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }


    }
}
