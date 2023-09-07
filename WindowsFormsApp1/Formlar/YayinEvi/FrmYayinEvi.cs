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

namespace WindowsFormsApp1.Formlar.YayinEvi
{
    public partial class FrmYayinEvi : Form
    {
        
        public FrmYayinEvi()
        {
            InitializeComponent();
        }

        private void FrmYayinEvi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnYayinEviEkle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmYayinEviEkle"))
            {
                Formlar.YayinEvi.FrmYayinEviEkle frm = new FrmYayinEviEkle();
                frm.Show();
            }
        }
        private void YayinEviSil_Click(object sender, EventArgs e)
        {
            ClientHelper.EntityDelete("YayinEvi", gridView1.GetFocusedRowCellValue("ID").ToString());
            Listele();
        }

        private void YayinEviGuncelle_Click(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("YayinEviDetay"))
            {
                Formlar.YayinEvi.YayinEviDetay frm = new Formlar.YayinEvi.YayinEviDetay();
                frm.IDText.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        public void Listele()
        {
            gridControl2.DataSource = ClientHelper.GetAllEntity<DataAccessLayer.YayinEvi>("YayinEvi");
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("YayinEviDetay"))
            {
                Formlar.YayinEvi.YayinEviDetay frm = new Formlar.YayinEvi.YayinEviDetay();
                frm.IDText.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
    }
}
