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
    public partial class YayinEviDetay : Form
    {
        
        public YayinEviDetay()
        {
            InitializeComponent();
        }
        private void YayinEviDetay_Load(object sender, EventArgs e)
        {
           DataAccessLayer.YayinEvi yayinEvi = ClientHelper.GetEntity<DataAccessLayer.YayinEvi>("Kitap/" + IDText.Text);
            AdıText.Text = yayinEvi.Adi;
            KayıtYapanText.Text = yayinEvi.KayitYapan;
            DegisiklikYapanText.Text = yayinEvi.DegisiklikYapan;


        }
        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void YayinEviGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            DataAccessLayer.YayinEvi yayinEvi = new DataAccessLayer.YayinEvi();
            yayinEvi.ID = Convert.ToInt16(IDText.Text);
            yayinEvi.Adi = AdıText.Text;
            yayinEvi.DegisiklikYapan = LoginForm.LoginForm.kullanici.KullaniciAdi;
            yayinEvi.DegisiklikTarihi = DateTime.Now;
            ClientHelper.EntityUpdate("YayinEvi", IDText.Text, yayinEvi);
            var mfrm = (FrmYayinEvi)Application.OpenForms["FrmYayinEvi"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }




    }
}
