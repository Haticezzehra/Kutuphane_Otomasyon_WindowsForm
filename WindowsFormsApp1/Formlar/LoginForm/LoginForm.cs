using DataAccessLayer;
using DataAccessLayer.LoginProgres;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Formlar.LoginForm
{
    public partial class LoginForm : Form
    {
        LoginProcess login = new LoginProcess();
        public static Kullanici kullanici;
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            ///Json için load
            //var kullanici = login.JsonDataOku();
            //KullanıcıAdıText.Text = kullanici.KullaniciAdi;
            //ParolaText.Text = kullanici.Parola;
            //if(KullanıcıAdıText.Text!="")
            //   checkBox1.Checked = true;
            kullanici = login.readData("XML");
            KullanıcıAdıText.Text = kullanici.KullaniciAdi;
            ParolaText.Text = kullanici.Parola;
            if (KullanıcıAdıText.Text != "")
                checkBox1.Checked = true;
        }
        private void GirisYap_Click(object sender, EventArgs e)
        {
            LoginControl();
        }
        public void LoginControl()
        {
            string JsonToken = ClientHelper.GetToken(KullanıcıAdıText.Text, ParolaText.Text);
            TokenAl tokenAl = JsonConvert.DeserializeObject<TokenAl>(JsonToken);
            ClientHelper.SetToken = tokenAl;
            if (tokenAl.access_token != null)
            {

                MessageBox.Show("Hoş Geldiniz");
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
                if (checkBox1.Checked)
                {
                    //Json için
                    //login.JsonYaz(KullanıcıAdıText.Text, ParolaText.Text);
                    login.XmlYaz(KullanıcıAdıText.Text, ParolaText.Text);
                }
                else
                {
                    //Json
                    // login.JsonBilgiSil();
                    //Xml
                    login.XmlBilgiSil();
                }
            }
        }


    }
}
