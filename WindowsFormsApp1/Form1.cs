using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FormKontrol;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("YazarEkle"))
            {
                Formlar.YazarFormlar.YazarEkle frm = new Formlar.YazarFormlar.YazarEkle();

                frm.Show();
            }
        }

       

        

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmYayinEviEkle"))
            {
                Formlar.YayinEvi.FrmYayinEviEkle frm = new Formlar.YayinEvi.FrmYayinEviEkle();
                frm.Show();
            }
        }

       
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("OgrenciEkle"))
            {
                Formlar.OgrenciFormlar.OgrenciEkle frm = new Formlar.OgrenciFormlar.OgrenciEkle();

                frm.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKullanıcıEkle"))
            {
                Formlar.Kullanıcı.FrmKullanıcıEkle frm = new Formlar.Kullanıcı.FrmKullanıcıEkle();
                frm.Show();
            }
        }

      

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapEkle"))
            {
                Formlar.KitapFormlar.KitapEkle frm = new Formlar.KitapFormlar.KitapEkle();
                frm.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapTuruEkle"))
            {
                Formlar.KitapTuru.KitapTuruEkle frm = new Formlar.KitapTuru.KitapTuruEkle();
                frm.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKitapOgrenci"))
            {
                Formlar.KitapOgrenciFormlar.FrmKitapOgrenci frm = new Formlar.KitapOgrenciFormlar.FrmKitapOgrenci();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapOgrenciEkle"))
            {
                Formlar.KitapOgrenciFormlar.KitapOgrenciEkle frm = new Formlar.KitapOgrenciFormlar.KitapOgrenciEkle();
                frm.Show();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKitapOgrenci"))
            {
                Formlar.KitapOgrenciFormlar.FrmKitapOgrenci frm = new Formlar.KitapOgrenciFormlar.FrmKitapOgrenci();
                frm.MdiParent = this;
                frm.Show();
            }
           // URL.KitapGetir.Get<Kitap>("?id=1");
        }

        private void OgrenciBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmOgrenci"))
            {
                Formlar.FrmOgrenci frm = new Formlar.FrmOgrenci();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void KitapBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKitap"))
            {
                Formlar.KitapFormlar.FrmKitap frm = new Formlar.KitapFormlar.FrmKitap();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmYazar"))
            {
                Formlar.YazarFormlar.FrmYazar frm = new Formlar.YazarFormlar.FrmYazar();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void KullanıcıBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("Kullanıcı"))
            {
                Formlar.Kullanıcı.Kullanıcı frm = new Formlar.Kullanıcı.Kullanıcı();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void YayınEvi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmYayinEvi"))
            {
                Formlar.YayinEvi.FrmYayinEvi frm = new Formlar.YayinEvi.FrmYayinEvi();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKitapTuru"))
            {
                Formlar.KitapTuru.FrmKitapTuru frm = new Formlar.KitapTuru.FrmKitapTuru();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void KitapOgrenciBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKitapOgrenci"))
            {
                Formlar.KitapOgrenciFormlar.FrmKitapOgrenci frm = new Formlar.KitapOgrenciFormlar.FrmKitapOgrenci();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}

