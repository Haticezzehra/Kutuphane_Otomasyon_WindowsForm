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

namespace WindowsFormsApp1.Formlar.KitapTuru
{
    public partial class KitapTuruGuncelle : Form
    {
        
        public KitapTuruGuncelle()
        {
            InitializeComponent();
        }

        private void KitapTuruGuncelle_Load(object sender, EventArgs e)
        {
            DataAccessLayer.KitapTuru kitapturu = ClientHelper.GetEntity<DataAccessLayer.KitapTuru>("Kitap/" + IDText.Text);
            AdıText.Text = kitapturu.Adi;
            KayıtYapanText.Text = kitapturu.KayitYapan;
            kayıttarihitext.Text = Convert.ToString(kitapturu.KayitTarihi);
            DegisiklikYapanText.Text = kitapturu.DegisiklikYapan;
        }
        private void KitapTuruGuncellle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            DataAccessLayer.KitapTuru kitapTuru = new DataAccessLayer.KitapTuru();
            kitapTuru.ID = Convert.ToInt16(IDText.Text);
            kitapTuru.Adi = AdıText.Text;
            kitapTuru.DegisiklikYapan = LoginForm.LoginForm.kullanici.KullaniciAdi;
            ClientHelper.EntityUpdate("KitapTuru", IDText.Text, kitapTuru);
            this.Close();
            var mfrm = (FrmKitapTuru)Application.OpenForms["FrmKitapTuru"];
            if (mfrm != null)
                mfrm.Listele();
        }
    }
}
