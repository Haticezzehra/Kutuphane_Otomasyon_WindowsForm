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

namespace WindowsFormsApp1.Formlar.Kullanıcı
{
    public partial class Kullanıcı : Form
    {
        
        public Kullanıcı()
        {
            InitializeComponent();
        }
        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void KullanıcıEkle_Click_1(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKullanıcıEkle"))
            {
                Formlar.Kullanıcı.FrmKullanıcıEkle frm = new Formlar.Kullanıcı.FrmKullanıcıEkle();
                frm.Show();
            }
        }

        private void KullanıcıGuncelle_Click_1(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKullanıcıDetay"))
            {
                Formlar.Kullanıcı.FrmKullanıcıDetay frm = new Formlar.Kullanıcı.FrmKullanıcıDetay();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

            ClientHelper.EntityDelete("Kullanıcı", gridView1.GetFocusedRowCellValue("ID").ToString());
            Listele();

        }



        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("FrmKullanıcıDetay"))
            {
                Formlar.Kullanıcı.FrmKullanıcıDetay frm = new Formlar.Kullanıcı.FrmKullanıcıDetay();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        public void Listele()
        {
            gridControl3.DataSource = ClientHelper.GetAllEntity<GetModelKullanici>("Kullanıcı");
        }


    }
}
