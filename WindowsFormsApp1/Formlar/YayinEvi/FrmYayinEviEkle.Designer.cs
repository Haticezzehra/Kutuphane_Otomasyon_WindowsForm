namespace WindowsFormsApp1.Formlar.YayinEvi
{
    partial class FrmYayinEviEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYayinEviEkle));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.iptalEt = new DevExpress.XtraEditors.SimpleButton();
            this.YayinEviEkle = new DevExpress.XtraEditors.SimpleButton();
            this.AdıText = new DevExpress.XtraEditors.TextEdit();
            this.KayıtYapanText = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.KayıtYapanTexttt = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdıText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanTexttt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.iptalEt);
            this.layoutControl1.Controls.Add(this.YayinEviEkle);
            this.layoutControl1.Controls.Add(this.AdıText);
            this.layoutControl1.Controls.Add(this.KayıtYapanText);
            this.layoutControl1.Location = new System.Drawing.Point(8, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(769, 320);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // iptalEt
            // 
            this.iptalEt.Location = new System.Drawing.Point(12, 86);
            this.iptalEt.Name = "iptalEt";
            this.iptalEt.Size = new System.Drawing.Size(745, 22);
            this.iptalEt.StyleController = this.layoutControl1;
            this.iptalEt.TabIndex = 16;
            this.iptalEt.Text = "İptal Et";
            this.iptalEt.Click += new System.EventHandler(this.iptalEt_Click);
            // 
            // YayinEviEkle
            // 
            this.YayinEviEkle.Location = new System.Drawing.Point(12, 60);
            this.YayinEviEkle.Name = "YayinEviEkle";
            this.YayinEviEkle.Size = new System.Drawing.Size(745, 22);
            this.YayinEviEkle.StyleController = this.layoutControl1;
            this.YayinEviEkle.TabIndex = 15;
            this.YayinEviEkle.Text = "Kayıt Et";
            this.YayinEviEkle.Click += new System.EventHandler(this.YayinEviEkle_Click);
            // 
            // AdıText
            // 
            this.AdıText.Location = new System.Drawing.Point(76, 12);
            this.AdıText.Name = "AdıText";
            this.AdıText.Size = new System.Drawing.Size(681, 20);
            this.AdıText.StyleController = this.layoutControl1;
            this.AdıText.TabIndex = 3;
            // 
            // KayıtYapanText
            // 
            this.KayıtYapanText.Enabled = false;
            this.KayıtYapanText.Location = new System.Drawing.Point(76, 36);
            this.KayıtYapanText.Name = "KayıtYapanText";
            this.KayıtYapanText.Size = new System.Drawing.Size(681, 20);
            this.KayıtYapanText.StyleController = this.layoutControl1;
            this.KayıtYapanText.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.KayıtYapanTexttt,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(769, 320);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.AdıText;
            this.layoutControlItem4.CustomizationFormText = "Adi Soyadi";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(749, 24);
            this.layoutControlItem4.Text = "Adı:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // KayıtYapanTexttt
            // 
            this.KayıtYapanTexttt.Control = this.KayıtYapanText;
            this.KayıtYapanTexttt.CustomizationFormText = "Adi Soyadi";
            this.KayıtYapanTexttt.Location = new System.Drawing.Point(0, 24);
            this.KayıtYapanTexttt.Name = "KayıtYapanTexttt";
            this.KayıtYapanTexttt.Size = new System.Drawing.Size(749, 24);
            this.KayıtYapanTexttt.Text = "Kayıt Yapan:";
            this.KayıtYapanTexttt.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.YayinEviEkle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(749, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.iptalEt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(749, 226);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmYayinEviEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 321);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmYayinEviEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayın Evi Ekle";
            this.Load += new System.EventHandler(this.FrmYayinEviEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdıText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KayıtYapanTexttt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit AdıText;
        private DevExpress.XtraEditors.TextEdit KayıtYapanText;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem KayıtYapanTexttt;
        private DevExpress.XtraEditors.SimpleButton YayinEviEkle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton iptalEt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}