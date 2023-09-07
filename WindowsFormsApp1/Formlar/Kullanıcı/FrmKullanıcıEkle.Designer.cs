namespace WindowsFormsApp1.Formlar.Kullanıcı
{
    partial class FrmKullanıcıEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanıcıEkle));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.iptalEt = new DevExpress.XtraEditors.SimpleButton();
            this.KullanıcıEkle = new DevExpress.XtraEditors.SimpleButton();
            this.KullanıcıAdıText = new DevExpress.XtraEditors.TextEdit();
            this.ParolaText = new DevExpress.XtraEditors.TextEdit();
            this.KayıtYapanText = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KullanıcıAdıText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParolaText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.iptalEt);
            this.layoutControl1.Controls.Add(this.KullanıcıEkle);
            this.layoutControl1.Controls.Add(this.KullanıcıAdıText);
            this.layoutControl1.Controls.Add(this.ParolaText);
            this.layoutControl1.Controls.Add(this.KayıtYapanText);
            this.layoutControl1.Location = new System.Drawing.Point(5, 6);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(777, 309);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // iptalEt
            // 
            this.iptalEt.Location = new System.Drawing.Point(12, 110);
            this.iptalEt.Name = "iptalEt";
            this.iptalEt.Size = new System.Drawing.Size(753, 22);
            this.iptalEt.StyleController = this.layoutControl1;
            this.iptalEt.TabIndex = 16;
            this.iptalEt.Text = "İptal Et";
            this.iptalEt.Click += new System.EventHandler(this.iptalEt_Click);
            // 
            // KullanıcıEkle
            // 
            this.KullanıcıEkle.Location = new System.Drawing.Point(12, 84);
            this.KullanıcıEkle.Name = "KullanıcıEkle";
            this.KullanıcıEkle.Size = new System.Drawing.Size(753, 22);
            this.KullanıcıEkle.StyleController = this.layoutControl1;
            this.KullanıcıEkle.TabIndex = 15;
            this.KullanıcıEkle.Text = "Kayıt Et";
            this.KullanıcıEkle.Click += new System.EventHandler(this.KullanıcıEkle_Click);
            // 
            // KullanıcıAdıText
            // 
            this.KullanıcıAdıText.Location = new System.Drawing.Point(76, 12);
            this.KullanıcıAdıText.Name = "KullanıcıAdıText";
            this.KullanıcıAdıText.Size = new System.Drawing.Size(689, 20);
            this.KullanıcıAdıText.StyleController = this.layoutControl1;
            this.KullanıcıAdıText.TabIndex = 3;
            // 
            // ParolaText
            // 
            this.ParolaText.Location = new System.Drawing.Point(76, 36);
            this.ParolaText.Name = "ParolaText";
            this.ParolaText.Size = new System.Drawing.Size(689, 20);
            this.ParolaText.StyleController = this.layoutControl1;
            this.ParolaText.TabIndex = 3;
            // 
            // KayıtYapanText
            // 
            this.KayıtYapanText.Enabled = false;
            this.KayıtYapanText.Location = new System.Drawing.Point(76, 60);
            this.KayıtYapanText.Name = "KayıtYapanText";
            this.KayıtYapanText.Size = new System.Drawing.Size(689, 20);
            this.KayıtYapanText.StyleController = this.layoutControl1;
            this.KayıtYapanText.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(777, 309);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.KullanıcıAdıText;
            this.layoutControlItem4.CustomizationFormText = "Adi Soyadi";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(757, 24);
            this.layoutControlItem4.Text = "Kullanıcı Adı:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ParolaText;
            this.layoutControlItem1.CustomizationFormText = "Adi Soyadi";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(757, 24);
            this.layoutControlItem1.Text = "Parola:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.KayıtYapanText;
            this.layoutControlItem2.CustomizationFormText = "Adi Soyadi";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(757, 24);
            this.layoutControlItem2.Text = "Kayıt Yapan:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.KullanıcıEkle;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(757, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.iptalEt;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(757, 191);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FrmKullanıcıEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKullanıcıEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kaydet";
            this.Load += new System.EventHandler(this.FrmKullanıcıEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KullanıcıAdıText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParolaText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit KullanıcıAdıText;
        private DevExpress.XtraEditors.TextEdit ParolaText;
        private DevExpress.XtraEditors.TextEdit KayıtYapanText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton KullanıcıEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton iptalEt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}