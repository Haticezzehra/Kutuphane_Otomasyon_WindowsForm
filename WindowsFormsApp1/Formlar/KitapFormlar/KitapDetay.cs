using DataAccessLayer;
using DataAccessLayer.Concrete;
using DevExpress.Utils.Extensions;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.KitapFormlar
{
    public partial class KitapDetay : Form
    {
      
        public KitapDetay()
        {
            InitializeComponent();
        }
        private void KitapDetay_Load(object sender, EventArgs e)
        {
            List<GetModelYayinEvi> yayinEvi = ClientHelper.GetAllEntity<GetModelYayinEvi>("YayinEvi");
            yayıneviadıtext.Properties.ValueMember = "ID";
            yayıneviadıtext.Properties.DataSource = "Adı";
            yayıneviadıtext.Properties.DataSource = yayinEvi;
            List<GetModelKitapTuru> kitapTuru = ClientHelper.GetAllEntity<GetModelKitapTuru>("KitapTuru");
            kitapTuruText.Properties.ValueMember = "ID";
            kitapTuruText.Properties.DataSource = "Adi";
            kitapTuruText.Properties.DataSource = kitapTuru;
            List<GetModelYazar> yazar = ClientHelper.GetAllEntity<GetModelYazar>("Yazar");
            yazaradı.Properties.ValueMember = "ID";
            yazaradı.Properties.DataSource = "AdSoyad";
            yazaradı.Properties.DataSource = yazar;
            ////
            Kitap kitap = ClientHelper.GetEntity<Kitap>("Kitap/"+IDText.Text);
            AdıText.Text = kitap.Adi;
            SayfaSayısı.Text = Convert.ToString(kitap.SayfaSayisi);
            kitapTuruText.EditValue = Convert.ToString(kitap.KitapTurID);
            yayıneviadıtext.Text = Convert.ToString(kitap.YayınEviID);
            yazaradı.Text = Convert.ToString(kitap.YazarID);
            BarkodText.Text = kitap.Barkod;
            KayıtYapanText.Text = kitap.KayitYapan;
            KayıtTarihiText.Text = Convert.ToString(kitap.KayitTarihi);
            DegisiklikYapanText.Text = kitap.DegisiklikYapan;
            pictureBox1.Image = BinaryToImage(kitap.Resim);
        }
        private System.Drawing.Image BinaryToImage(byte[] b)
        {
            if (b == null)
                return null;
            using (MemoryStream ms = new MemoryStream(b, 0, b.Length))
            {
                ms.Write(b, 0, b.Length);
                System.Drawing.Image newImage = System.Drawing.Image.FromStream(ms);
                return newImage;
            }
        }
            private void KitapGuncelle_Click(object sender, EventArgs e)
        {
            KitapGuncellee();
        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resimEkleButton_Click(object sender, EventArgs e)
        {
            ResimEkle();
        }
        public void KitapGuncellee()
        {
            Kitap kitap = new Kitap();
            kitap.ID = Convert.ToInt16(IDText.Text);
            kitap.Adi = AdıText.Text;
            kitap.SayfaSayisi = Convert.ToInt16(SayfaSayısı.Text);
            kitap.KitapTurID = Convert.ToInt16(kitapTuruText.EditValue);
            kitap.YayınEviID = Convert.ToInt16(yayıneviadıtext.EditValue);
            kitap.KayitYapan = KayıtYapanText.Text;
            kitap.YazarID = Convert.ToInt16(yazaradı.EditValue);
            kitap.Barkod = BarkodText.Text;
            //if(pictureBox1.Image!=null)
            //    kitap.Resim = ImageToByteArray(pictureBox1.Image);
            kitap.DegisiklikYapan = LoginForm.LoginForm.kullanici.KullaniciAdi;
            ClientHelper.EntityUpdate("Kitap", IDText.Text, kitap);
            
            var mfrm = (FrmKitap)Application.OpenForms["FrmKitap"];
            if (mfrm != null)
                mfrm.Listele();
            this.Close();
        }

        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Resim formatına göre değiştirilebilir (Jpeg, Png, Gif, vb.)
                return ms.ToArray();
            }
        }
        public void ResimEkle()
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog openfileDiaolog = new OpenFileDialog();
            openfileDiaolog.ShowDialog();
            pictureBox1.ImageLocation = openfileDiaolog.FileName;
        }

        private void IDText_EditValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}

