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
    public partial class FrmKullanıcıDetay : Form
    {
        
        public FrmKullanıcıDetay()
        {
            InitializeComponent();
        }
        private void FrmKullanıcıDetay_Load(object sender, EventArgs e)
        {
            DataAccessLayer.Kullanici kullanici =  ClientHelper.GetEntity<DataAccessLayer.Kullanici>("Kullanıcı/" + IDText.Text);
            KullanıcıAdıText.Text = kullanici.KullaniciAdi;
            ParolaText.Text = kullanici.Parola;
            KayıtYapanText.Text = kullanici.KayıtYapan;
            KayıtTarihiText.Text = Convert.ToString(kullanici.KayıtTarihi);
            DegisiklikYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Guncelle()
        {
            DataAccessLayer.Kullanici kullanici = new DataAccessLayer.Kullanici();
            kullanici.ID = Convert.ToInt16(IDText.Text);
            kullanici.KullaniciAdi = KullanıcıAdıText.Text;
            kullanici.Parola = ParolaText.Text;
            kullanici.DegisiklikYapan = LoginForm.LoginForm.kullanici.KullaniciAdi;
            ClientHelper.EntityUpdate("Kullanıcı", IDText.Text, kullanici);
            var mfrm = (Formlar.Kullanıcı.Kullanıcı)Application.OpenForms["Kullanıcı"];
            if (mfrm != null)
                mfrm.Listele();

            this.Close();
        }


    }
}
