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

namespace WindowsFormsApp1.Formlar.OgrenciFormlar
{
    public partial class OgrenciGuncelle : Form
    {
        
        public OgrenciGuncelle()
        {
            InitializeComponent();
        }
        private void OgrenciGuncelle_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci = ClientHelper.GetEntity<Ogrenci>("Ogrenci" + IDText.Text);
            AdıSoyadıText.Text = ogrenci.AdSoyad;
            SınıfText.Text = ogrenci.Sınıf;
            BolumText.Text = ogrenci.Bolum;
            OkulNoText.Text = ogrenci.OkulNo;
            DegisiklikYapanText.Text = ogrenci.DegisiklikYapan;
            KayıtYapanText.Text = ogrenci.KayıtYapan;
            DegisiklikYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ID = Convert.ToInt16(IDText.Text);
            ogrenci.AdSoyad = AdıSoyadıText.Text;
            ogrenci.Sınıf = SınıfText.Text;
            ogrenci.Bolum = BolumText.Text;
            ogrenci.DegisiklikTarihi = DateTime.Now;
            ogrenci.OkulNo = OkulNoText.Text;
            ogrenci.DegisiklikYapan = DegisiklikYapanText.Text;
            ClientHelper.EntityUpdate("Ogrenci", IDText.Text, ogrenci);
            var mfrm = (FrmOgrenci)Application.OpenForms["FrmOgrenci"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }


    }
}

