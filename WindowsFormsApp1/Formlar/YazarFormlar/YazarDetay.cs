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
    public partial class YazarDetay : Form
    {
        
        public YazarDetay()
        {
            InitializeComponent();
        }

        private void YazarDetay_Load(object sender, EventArgs e)
        {
            Yazar yazar = ClientHelper.GetEntity<Yazar>("Yazar/" + IDText.Text);
            AdıSoyadıText.Text = yazar.AdSoyad;
            KayıtYapanText.Text = yazar.KayıtYapan;
            KayıtTarihiText.Text = Convert.ToString(yazar.KayıtTarihi);
            DegisiklikYapanText.Text = yazar.DegisiklikYapan;

        }
        private void YazarGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();

        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Guncelle()
        {
            Yazar yazar = new Yazar();
            yazar.ID = Convert.ToInt16(IDText.Text);
            yazar.AdSoyad = AdıSoyadıText.Text;
            yazar.DegisiklikYapan = LoginForm.LoginForm.kullanici.KullaniciAdi;
            ClientHelper.EntityUpdate("Yazar", IDText.Text, yazar);
            var mfrm = (FrmYazar)Application.OpenForms["FrmYazar"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }

    }
}
