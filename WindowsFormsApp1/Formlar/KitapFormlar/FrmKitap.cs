using DataAccessLayer;
using DataAccessLayer.Concrete;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.FormKontrol;

using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.KitapFormlar
{
    public partial class FrmKitap : Form
    {
        
        public FrmKitap()
        {
            InitializeComponent();
        }
        private void FrmKitap_Load(object sender, EventArgs e)
        {    
            Listele();        
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            ClientHelper.EntityDelete("Kitap", gridView1.GetFocusedRowCellValue("ID").ToString());
            
            Listele();
        }
       
      
        private void KitapGuncelle_Click_1(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapDetay"))
            {
                Formlar.KitapFormlar.KitapDetay frm = new Formlar.KitapFormlar.KitapDetay();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapDetay"))
            {
                Formlar.KitapFormlar.KitapDetay frm = new Formlar.KitapFormlar.KitapDetay();
                frm.IDText.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
                frm.Show();
            }
        }
        public void Listele()
        {

            gridControlKitap.DataSource = ClientHelper.GetAllEntity<GetModelKitap>("Kitap");



        }
        public Image byteArrayToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void gridControlKitap_Click(object sender, EventArgs e)
        {

        }

        private void BtnKitapEkle_Click_1(object sender, EventArgs e)
        {
            if (!FormControl.MDIFormAcikmi("KitapEkle"))
            {
                Formlar.KitapFormlar.KitapEkle frm = new Formlar.KitapFormlar.KitapEkle();
                frm.Show();
                Listele();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
