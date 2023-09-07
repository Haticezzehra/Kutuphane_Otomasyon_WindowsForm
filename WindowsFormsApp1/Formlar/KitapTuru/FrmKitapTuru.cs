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

namespace WindowsFormsApp1.Formlar.KitapTuru
{
    public partial class FrmKitapTuru : Form
    {
       
        public FrmKitapTuru()
        {
            InitializeComponent();
        }
        private void FrmKitapTuru_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void KitapTuruSil_Click(object sender, EventArgs e)
        {

            ClientHelper.EntityDelete("KitapTuru", gridView1.GetFocusedRowCellValue("ID").ToString());
            Listele();
        }

        private void BtnKitapTuruEkle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapTuruEkle"))
            {
                Formlar.KitapTuru.KitapTuruEkle frm = new Formlar.KitapTuru.KitapTuruEkle();
                frm.Show();
            }
        }

        private void OgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapTuruGuncelle"))
            {
                Formlar.KitapTuru.KitapTuruGuncelle frm = new Formlar.KitapTuru.KitapTuruGuncelle();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapTuruGuncelle"))
            {
                Formlar.KitapTuru.KitapTuruGuncelle frm = new Formlar.KitapTuru.KitapTuruGuncelle();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        public void Listele()
        {
            gridControl1.DataSource = ClientHelper.GetAllEntity<GetModelKitapTuru>("KitapTuru");
        }

       
    }
}
