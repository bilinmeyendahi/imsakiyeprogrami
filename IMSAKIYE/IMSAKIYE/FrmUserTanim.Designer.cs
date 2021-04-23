namespace STOKC
{
    partial class FrmUserTanim
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            this.Sifre = new System.Windows.Forms.TextBox();
            this.GuvenlikSoru = new System.Windows.Forms.ComboBox();
            this.GuvenlikCevap = new System.Windows.Forms.TextBox();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnYeniKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Yetki = new System.Windows.Forms.ComboBox();
            this.btnGuncelleKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifresi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Güvenlik Sorusu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Güvenlik Cevabı";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(130, 6);
            this.ID.MaxLength = 11;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(106, 23);
            this.ID.TabIndex = 6;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.Location = new System.Drawing.Point(341, 6);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(193, 23);
            this.KullaniciAdi.TabIndex = 7;
            // 
            // Sifre
            // 
            this.Sifre.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Sifre.Location = new System.Drawing.Point(594, 6);
            this.Sifre.Name = "Sifre";
            this.Sifre.PasswordChar = 'l';
            this.Sifre.Size = new System.Drawing.Size(188, 22);
            this.Sifre.TabIndex = 8;
            // 
            // GuvenlikSoru
            // 
            this.GuvenlikSoru.FormattingEnabled = true;
            this.GuvenlikSoru.Items.AddRange(new object[] {
            "ANNENİZİN KIZLIK SOYADI NEDİR?",
            "BABANIZIN DEDESİ?",
            "EN SEVDİĞİNİZ HAYVAN?",
            "EN SEVDİĞİNİZ YEMEK?",
            "EN SEVDİĞİNİZ ÇOCUKLUK ARKADAŞINIZ?",
            "ARABANIZIN MODELİ?",
            "KEDİNİZİN ADI?",
            "KÖPEĞİNİZİN ADI?",
            "EŞİNİZİN EN SEVDİĞİ ÇİÇEK?",
            "TATİLDE HANGİ YÖREYİ SEVDİNİZ?"});
            this.GuvenlikSoru.Location = new System.Drawing.Point(130, 41);
            this.GuvenlikSoru.Name = "GuvenlikSoru";
            this.GuvenlikSoru.Size = new System.Drawing.Size(341, 24);
            this.GuvenlikSoru.TabIndex = 24;
            // 
            // GuvenlikCevap
            // 
            this.GuvenlikCevap.Location = new System.Drawing.Point(594, 41);
            this.GuvenlikCevap.Name = "GuvenlikCevap";
            this.GuvenlikCevap.Size = new System.Drawing.Size(188, 23);
            this.GuvenlikCevap.TabIndex = 25;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = global::STOKC.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back;
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.Location = new System.Drawing.Point(619, 70);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(160, 42);
            this.btnVazgec.TabIndex = 29;
            this.btnVazgec.Text = "Kapat";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeniKaydet
            // 
            this.btnYeniKaydet.Image = global::STOKC.Properties.Resources.Icons8_Ios7_User_Interface_Save_As;
            this.btnYeniKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniKaydet.Location = new System.Drawing.Point(454, 70);
            this.btnYeniKaydet.Name = "btnYeniKaydet";
            this.btnYeniKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnYeniKaydet.TabIndex = 27;
            this.btnYeniKaydet.Text = "Kaydet";
            this.btnYeniKaydet.UseVisualStyleBackColor = true;
            this.btnYeniKaydet.Click += new System.EventHandler(this.btnYeniKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Yetki";
            // 
            // Yetki
            // 
            this.Yetki.FormattingEnabled = true;
            this.Yetki.Items.AddRange(new object[] {
            "Admin",
            "Kullanıcı"});
            this.Yetki.Location = new System.Drawing.Point(130, 74);
            this.Yetki.Name = "Yetki";
            this.Yetki.Size = new System.Drawing.Size(197, 24);
            this.Yetki.TabIndex = 31;
            // 
            // btnGuncelleKaydet
            // 
            this.btnGuncelleKaydet.Image = global::STOKC.Properties.Resources.Icons8_Ios7_User_Interface_Save_As;
            this.btnGuncelleKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelleKaydet.Location = new System.Drawing.Point(454, 71);
            this.btnGuncelleKaydet.Name = "btnGuncelleKaydet";
            this.btnGuncelleKaydet.Size = new System.Drawing.Size(162, 42);
            this.btnGuncelleKaydet.TabIndex = 32;
            this.btnGuncelleKaydet.Text = "Kaydet";
            this.btnGuncelleKaydet.UseVisualStyleBackColor = true;
            this.btnGuncelleKaydet.Click += new System.EventHandler(this.btnGuncelleKaydet_Click);
            // 
            // FrmUserTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(791, 119);
            this.ControlBox = false;
            this.Controls.Add(this.Yetki);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.GuvenlikCevap);
            this.Controls.Add(this.GuvenlikSoru);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullaniciAdi);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniKaydet);
            this.Controls.Add(this.btnGuncelleKaydet);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnVazgec;
        public System.Windows.Forms.ComboBox Yetki;
        public System.Windows.Forms.TextBox ID;
        public System.Windows.Forms.TextBox KullaniciAdi;
        public System.Windows.Forms.TextBox Sifre;
        public System.Windows.Forms.ComboBox GuvenlikSoru;
        public System.Windows.Forms.TextBox GuvenlikCevap;
        public System.Windows.Forms.Button btnYeniKaydet;
        public System.Windows.Forms.Button btnGuncelleKaydet;
    }
}

