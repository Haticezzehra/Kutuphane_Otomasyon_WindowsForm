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

namespace WindowsFormsApp1.Formlar.YazarFormlar
{
    public partial class FrmYazar : Form
    {
       
        public FrmYazar()
        {
            InitializeComponent();
        }

        private void FrmYazar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void YazarSil_Click(object sender, EventArgs e)
        {
            ClientHelper.EntityDelete("Yazar", gridView1.GetFocusedRowCellValue("ID").ToString());
            Listele();
        }

        private void BtnYazarEkle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("YazarEkle"))
            {
                Formlar.YazarFormlar.YazarEkle frm = new Formlar.YazarFormlar.YazarEkle();
                frm.Show();
            }
        }

        private void Yazarguncelle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("YazarDetay"))
            {
                Formlar.YazarFormlar.YazarDetay frm = new Formlar.YazarFormlar.YazarDetay();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        public void Listele()
        {
            gridControl1.DataSource = ClientHelper.GetAllEntity<GetModelYazar>("Yazar");
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("YazarDetay"))
            {
                Formlar.YazarFormlar.YazarDetay frm = new Formlar.YazarFormlar.YazarDetay();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
    }
}
