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

namespace WindowsFormsApp1.Formlar
{
    public partial class FrmOgrenci : Form
    {
      

        public FrmOgrenci()
        {

            InitializeComponent();
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ClientHelper.EntityDelete("Ogrenci", gridView1.GetFocusedRowCellValue("ID").ToString());
            Listele();
        }

        private void OgrenciGuncelle_Click_1(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("OgrenciGuncelle"))
            {
                Formlar.OgrenciFormlar.OgrenciGuncelle frm = new Formlar.OgrenciFormlar.OgrenciGuncelle();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }

        private void BtnOgrenciEkle_Click_1(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("OgrenciEkle"))
            {
                Formlar.OgrenciFormlar.OgrenciEkle frm = new Formlar.OgrenciFormlar.OgrenciEkle();
                frm.Show();
            }
        }
        public void Listele()
        {
            gridControl1.DataSource = ClientHelper.GetAllEntity<GetModelOgrenci>("Ogrenci");
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("OgrenciGuncelle"))
            {
                Formlar.OgrenciFormlar.OgrenciGuncelle frm = new Formlar.OgrenciFormlar.OgrenciGuncelle();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
    }
}
