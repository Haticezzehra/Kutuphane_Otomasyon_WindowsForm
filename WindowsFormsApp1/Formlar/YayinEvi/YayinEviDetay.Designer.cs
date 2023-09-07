namespace WindowsFormsApp1.Formlar.YayinEvi
{
    partial class YayinEviDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YayinEviDetay));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.iptalEt = new DevExpress.XtraEditors.SimpleButton();
            this.YayinEviGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.IDText = new DevExpress.XtraEditors.TextEdit();
            this.AdıText = new DevExpress.XtraEditors.TextEdit();
            this.KayıtYapanText = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.DegisiklikYapanText = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Text = new DevExpress.XtraLayout.LayoutControlItem();
            this.KayıtTarihiText = new DevExpress.XtraLayout.LayoutControlItem();
            this.Deg = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IDText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdıText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DegisiklikYapanText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtTarihiText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(180, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(180, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.iptalEt);
            this.layoutControl2.Controls.Add(this.YayinEviGuncelle);
            this.layoutControl2.Controls.Add(this.IDText);
            this.layoutControl2.Controls.Add(this.AdıText);
            this.layoutControl2.Controls.Add(this.KayıtYapanText);
            this.layoutControl2.Controls.Add(this.textEdit3);
            this.layoutControl2.Controls.Add(this.DegisiklikYapanText);
            this.layoutControl2.Location = new System.Drawing.Point(14, 9);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(767, 315);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // iptalEt
            // 
            this.iptalEt.Location = new System.Drawing.Point(12, 158);
            this.iptalEt.Name = "iptalEt";
            this.iptalEt.Size = new System.Drawing.Size(743, 22);
            this.iptalEt.StyleController = this.layoutControl2;
            this.iptalEt.TabIndex = 17;
            this.iptalEt.Text = "İptal Et";
            this.iptalEt.Click += new System.EventHandler(this.iptalEt_Click);
            // 
            // YayinEviGuncelle
            // 
            this.YayinEviGuncelle.Location = new System.Drawing.Point(12, 132);
            this.YayinEviGuncelle.Name = "YayinEviGuncelle";
            this.YayinEviGuncelle.Size = new System.Drawing.Size(743, 22);
            this.YayinEviGuncelle.StyleController = this.layoutControl2;
            this.YayinEviGuncelle.TabIndex = 16;
            this.YayinEviGuncelle.Text = "Yayin Evi Güncelle";
            this.YayinEviGuncelle.Click += new System.EventHandler(this.YayinEviGuncelle_Click);
            // 
            // IDText
            // 
            this.IDText.Enabled = false;
            this.IDText.Location = new System.Drawing.Point(94, 12);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(661, 20);
            this.IDText.StyleController = this.layoutControl2;
            this.IDText.TabIndex = 3;
            // 
            // AdıText
            // 
            this.AdıText.Location = new System.Drawing.Point(94, 36);
            this.AdıText.Name = "AdıText";
            this.AdıText.Size = new System.Drawing.Size(661, 20);
            this.AdıText.StyleController = this.layoutControl2;
            this.AdıText.TabIndex = 3;
            // 
            // KayıtYapanText
            // 
            this.KayıtYapanText.Enabled = false;
            this.KayıtYapanText.Location = new System.Drawing.Point(94, 60);
            this.KayıtYapanText.Name = "KayıtYapanText";
            this.KayıtYapanText.Size = new System.Drawing.Size(661, 20);
            this.KayıtYapanText.StyleController = this.layoutControl2;
            this.KayıtYapanText.TabIndex = 3;
            // 
            // textEdit3
            // 
            this.textEdit3.Enabled = false;
            this.textEdit3.Location = new System.Drawing.Point(94, 84);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(661, 20);
            this.textEdit3.StyleController = this.layoutControl2;
            this.textEdit3.TabIndex = 3;
            // 
            // DegisiklikYapanText
            // 
            this.DegisiklikYapanText.Enabled = false;
            this.DegisiklikYapanText.Location = new System.Drawing.Point(94, 108);
            this.DegisiklikYapanText.Name = "DegisiklikYapanText";
            this.DegisiklikYapanText.Size = new System.Drawing.Size(661, 20);
            this.DegisiklikYapanText.StyleController = this.layoutControl2;
            this.DegisiklikYapanText.TabIndex = 3;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.Text,
            this.KayıtTarihiText,
            this.Deg,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(767, 315);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.IDText;
            this.layoutControlItem4.CustomizationFormText = "Adi Soyadi";
            this.layoutControlItem4.Enabled = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(747, 24);
            this.layoutControlItem4.Text = "ID:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.AdıText;
            this.layoutControlItem1.CustomizationFormText = "Adi Soyadi";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(747, 24);
            this.layoutControlItem1.Text = "Adı:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // Text
            // 
            this.Text.Control = this.KayıtYapanText;
            this.Text.CustomizationFormText = "Adi Soyadi";
            this.Text.Enabled = false;
            this.Text.Location = new System.Drawing.Point(0, 48);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(747, 24);
            this.Text.Text = "Kayıt Yapan:";
            this.Text.TextSize = new System.Drawing.Size(79, 13);
            // 
            // KayıtTarihiText
            // 
            this.KayıtTarihiText.Control = this.textEdit3;
            this.KayıtTarihiText.CustomizationFormText = "Adi Soyadi";
            this.KayıtTarihiText.Location = new System.Drawing.Point(0, 72);
            this.KayıtTarihiText.Name = "KayıtTarihiText";
            this.KayıtTarihiText.Size = new System.Drawing.Size(747, 24);
            this.KayıtTarihiText.Text = "Kayıt Tarihi:";
            this.KayıtTarihiText.TextSize = new System.Drawing.Size(79, 13);
            // 
            // Deg
            // 
            this.Deg.Control = this.DegisiklikYapanText;
            this.Deg.CustomizationFormText = "Adi Soyadi";
            this.Deg.Location = new System.Drawing.Point(0, 96);
            this.Deg.Name = "Deg";
            this.Deg.Size = new System.Drawing.Size(747, 24);
            this.Deg.Text = "Değişiklik Yapan:";
            this.Deg.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.YayinEviGuncelle;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(747, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.iptalEt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 146);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(747, 149);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // YayinEviDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YayinEviDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.YayinEviDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IDText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdıText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DegisiklikYapanText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtTarihiText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit AdıText;
        private DevExpress.XtraEditors.TextEdit KayıtYapanText;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit DegisiklikYapanText;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem Text;
        private DevExpress.XtraLayout.LayoutControlItem KayıtTarihiText;
        private DevExpress.XtraLayout.LayoutControlItem Deg;
        private DevExpress.XtraEditors.SimpleButton YayinEviGuncelle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        public DevExpress.XtraEditors.TextEdit IDText;
        private DevExpress.XtraEditors.SimpleButton iptalEt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}