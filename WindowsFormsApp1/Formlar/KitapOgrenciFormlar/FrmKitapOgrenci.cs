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
using WindowsFormsApp1.FormKontrol;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.KitapOgrenciFormlar
{
    public partial class FrmKitapOgrenci : Form
    {
       
        public FrmKitapOgrenci()
        {
            InitializeComponent();
        }
        private void FrmKitapOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            ClientHelper.EntityDelete("Ogrenci", gridView1.GetFocusedRowCellValue("ID").ToString());
            Listele();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapOgrenciEkle"))
            {
                Formlar.KitapOgrenciFormlar.KitapOgrenciEkle frm = new Formlar.KitapOgrenciFormlar.KitapOgrenciEkle();
                frm.Show();
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapOgrenciguncelle"))
            {
                Formlar.KitapOgrenciFormlar.KitapOgrenciguncelle frm = new Formlar.KitapOgrenciFormlar.KitapOgrenciguncelle();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapOgrenciguncelle"))
            {
                Formlar.KitapOgrenciFormlar.KitapOgrenciguncelle frm = new Formlar.KitapOgrenciFormlar.KitapOgrenciguncelle();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        public void Listele()
        {
            gridControl1.DataSource = ClientHelper.GetAllEntity<GetModelKitapOgrenci>("KitapOgrenci");
        }

      
    }
}
