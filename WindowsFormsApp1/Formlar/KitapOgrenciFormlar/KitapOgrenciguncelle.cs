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
    public partial class KitapOgrenciguncelle : Form
    {
       
        
        public KitapOgrenciguncelle()
        {
            InitializeComponent();
        }
        private void KitapOgrenciguncelle_Load(object sender, EventArgs e)
        {
            KitapOgrenci kitapOgrenci = ClientHelper.GetEntity<KitapOgrenci>("KitapOgrenci/" + IDText.Text);
            OgrenciAdıText.EditValue = Convert.ToString(kitapOgrenci.OgrenciID);
            KullanıcıAdıText.EditValue = Convert.ToString(kitapOgrenci.KullaniciID);
            KitapAdıText.EditValue = Convert.ToString(kitapOgrenci.KitapID);
            AlıstTarihiText.Text = Convert.ToString(kitapOgrenci.AlisTarihi);
            TeslimTarihiText.Text = Convert.ToString(kitapOgrenci.TeslimTarihi);
            DegisiklikYapanText.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
            KayıtYapanText.Text = kitapOgrenci.KayitYapan;
            KayıtTarihiText.Text = Convert.ToString(kitapOgrenci.KayıtTarihi);
            /////Load Lookup Edit///////

            List<GetModelYayinEvi> kitap = ClientHelper.GetAllEntity<GetModelYayinEvi>("YayinEvi");
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
        }
        private void Guncelle_Click(object sender, EventArgs e)
        {
            Guncellee();
        }
        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Guncellee()
        {
            KitapOgrenci kitapOgrenci = new KitapOgrenci();
            kitapOgrenci.ID = Convert.ToInt16(IDText.Text);
            kitapOgrenci.OgrenciID = Convert.ToInt16(OgrenciAdıText.EditValue);
            kitapOgrenci.KullaniciID = Convert.ToInt16(KullanıcıAdıText.EditValue);
            kitapOgrenci.KitapID = Convert.ToInt16(KitapAdıText.EditValue);
            kitapOgrenci.AlisTarihi = Convert.ToDateTime(AlıstTarihiText.Text);
            if (TeslimTarihiText.Text != "")
            {
                kitapOgrenci.TeslimTarihi = Convert.ToDateTime(TeslimTarihiText.Text);
            }
            kitapOgrenci.DegisiklikYapan = DegisiklikYapanText.Text;
            ClientHelper.EntityUpdate("KitapOgrenci", IDText.Text, kitapOgrenci);
            var mfrm = (FrmKitapOgrenci)Application.OpenForms["FrmKitapOgrenci"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }
    }
}
