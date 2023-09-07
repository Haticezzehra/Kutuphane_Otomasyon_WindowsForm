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

namespace WindowsFormsApp1.Formlar.KitapOgrenciFormlar
{
    public partial class KitapOgrenciEkle : Form
    {
      
        public KitapOgrenciEkle()
        {
            InitializeComponent();
        }
        private void KitapOgrenciEkle_Load(object sender, EventArgs e)
        {
            List<GetModelYayinEvi> kitap = ClientHelper.GetAllEntity<GetModelYayinEvi>("Kitap");
            KitapAdıText.Properties.ValueMember = "ID";
            KitapAdıText.Properties.DataSource = "Adı";
            KitapAdıText.Properties.DataSource = kitap;
            List<GetModelKullanici> kullanici = ClientHelper.GetAllEntity<GetModelKullanici>("Kullanıcı");
            KullanıcıAdıText.Properties.ValueMember = "ID";
            KullanıcıAdıText.Properties.DataSource = "Adi";
            KullanıcıAdıText.Properties.DataSource = kullanici;
            List<GetModelOgrenci> ogrenci = ClientHelper.GetAllEntity<GetModelOgrenci>("Ogrenci");
            OgrenciAdıText.Properties.ValueMember = "ID";
            OgrenciAdıText.Properties.DataSource = "AdSoyad";
            OgrenciAdıText.Properties.DataSource = ogrenci;
            KayıtYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void Ekle_Click(object sender, EventArgs e)
        {
            Eklee();
        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Eklee()
        {
            KitapOgrenci kitapOgrenci = new KitapOgrenci();
            kitapOgrenci.OgrenciID = (int)OgrenciAdıText.EditValue;
            kitapOgrenci.KullaniciID = (int)KullanıcıAdıText.EditValue;
            kitapOgrenci.KitapID = (int)KitapAdıText.EditValue;
            kitapOgrenci.AlisTarihi = DateTime.Now;
            if (TexlimTarihiText.Text != "")
                kitapOgrenci.TeslimTarihi = Convert.ToDateTime(TexlimTarihiText.Text);
            kitapOgrenci.KayitYapan = LoginForm.LoginForm.kullanici.KullaniciAdi;
            kitapOgrenci.KayıtTarihi = DateTime.Now;
            ClientHelper.PostEntity("KitapOgrenci", kitapOgrenci);
           
            var mfrm = (FrmKitapOgrenci)Application.OpenForms["FrmKitapOgrenci"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }
      
    }
}
