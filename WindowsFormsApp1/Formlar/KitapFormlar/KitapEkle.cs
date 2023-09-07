using DataAccessLayer;
using DataAccessLayer.Concrete;
using DataAccessLayer.Image_Processing;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.KitapFormlar
{
    public partial class KitapEkle : Form
    {
        
        

        public KitapEkle()
        {
            InitializeComponent();
        }
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            List<GetModelYayinEvi> yayinEvi = ClientHelper.GetAllEntity<GetModelYayinEvi>("YayinEvi");
            YayınEviAdıText.Properties.ValueMember = "ID";
            YayınEviAdıText.Properties.DataSource = "Adı";
            YayınEviAdıText.Properties.DataSource = yayinEvi;
            List<GetModelKitapTuru> kitapTuru = ClientHelper.GetAllEntity<GetModelKitapTuru>("KitapTuru");
            KitapTurText.Properties.ValueMember = "ID";
            KitapTurText.Properties.DataSource = "Adi";
            KitapTurText.Properties.DataSource = kitapTuru;
            List<GetModelYazar> yazar = ClientHelper.GetAllEntity<GetModelYazar>("Yazar");
            YazarAdıText.Properties.ValueMember = "ID";
            YazarAdıText.Properties.DataSource = "AdSoyad";
            YazarAdıText.Properties.DataSource = yazar;
            kayıtyapantext.Text = LoginForm.LoginForm.kullanici.KullaniciAdi;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KitapEklee();
            this.Close();
        }
        private void resimEkleButton_Click_1(object sender, EventArgs e)
        {
            ResimEkle();
        }
       
        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void KitapEklee()
        {
            Kitap kitap = new Kitap()
            {
                Adi = AdıText.Text,
                SayfaSayisi = Convert.ToInt16(SayfaSayısıText.Text),
                KitapTurID = (int)KitapTurText.EditValue,
                YayınEviID = (int)YayınEviAdıText.EditValue,
                YazarID = (int)YazarAdıText.EditValue,
                Barkod = BarkodText.Text,
                Resim = ImageProcesssing.ResminKalitesiniDusur(pictureBox1.Image),    
                KayitTarihi = DateTime.Now,
            };
            ClientHelper.PostEntity("Kitap",kitap);

            var mfrm = (FrmKitap)Application.OpenForms["FrmKitap"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }
        
        public void ResimEkle()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog openfileDiaolog = new OpenFileDialog();
            openfileDiaolog.ShowDialog();
            pictureBox1.ImageLocation = openfileDiaolog.FileName;
        }     
    }
}
