namespace IMSAKIYE
{
    partial class FrmDonemTanim

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
            this.id = new System.Windows.Forms.TextBox();
            this.DonemYil = new System.Windows.Forms.ComboBox();
            this.Baslangic = new System.Windows.Forms.DateTimePicker();
            this.Bitis = new System.Windows.Forms.DateTimePicker();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.btnYeniKaydet = new System.Windows.Forms.Button();
            this.btnGuncelleKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "D.No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yıl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Başlangıç-Bitiş T.";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(130, 6);
            this.id.MaxLength = 11;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(106, 23);
            this.id.TabIndex = 6;
            // 
            // DonemYil
            // 
            this.DonemYil.FormattingEnabled = true;
            this.DonemYil.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056"});
            this.DonemYil.Location = new System.Drawing.Point(271, 5);
            this.DonemYil.Name = "DonemYil";
            this.DonemYil.Size = new System.Drawing.Size(135, 24);
            this.DonemYil.TabIndex = 33;
            // 
            // Baslangic
            // 
            this.Baslangic.CustomFormat = "yyyy.MM.dd";
            this.Baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Baslangic.Location = new System.Drawing.Point(130, 34);
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.Size = new System.Drawing.Size(135, 23);
            this.Baslangic.TabIndex = 34;
            // 
            // Bitis
            // 
            this.Bitis.CustomFormat = "yyyy.MM.dd";
            this.Bitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Bitis.Location = new System.Drawing.Point(271, 35);
            this.Bitis.Name = "Bitis";
            this.Bitis.Size = new System.Drawing.Size(135, 23);
            this.Bitis.TabIndex = 35;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Image = global::IMSAKIYE.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back;
            this.btnVazgec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVazgec.Location = new System.Drawing.Point(592, 5);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(160, 52);
            this.btnVazgec.TabIndex = 29;
            this.btnVazgec.Text = "Kapat";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // btnYeniKaydet
            // 
            this.btnYeniKaydet.Image = global::IMSAKIYE.Properties.Resources.Icons8_Ios7_User_Interface_Save_As;
            this.btnYeniKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeniKaydet.Location = new System.Drawing.Point(424, 7);
            this.btnYeniKaydet.Name = "btnYeniKaydet";
            this.btnYeniKaydet.Size = new System.Drawing.Size(162, 51);
            this.btnYeniKaydet.TabIndex = 27;
            this.btnYeniKaydet.Text = "Kaydet";
            this.btnYeniKaydet.UseVisualStyleBackColor = true;
            this.btnYeniKaydet.Click += new System.EventHandler(this.btnYeniKaydet_Click);
            // 
            // btnGuncelleKaydet
            // 
            this.btnGuncelleKaydet.Image = global::IMSAKIYE.Properties.Resources.Icons8_Ios7_User_Interface_Save_As;
            this.btnGuncelleKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelleKaydet.Location = new System.Drawing.Point(424, 6);
            this.btnGuncelleKaydet.Name = "btnGuncelleKaydet";
            this.btnGuncelleKaydet.Size = new System.Drawing.Size(162, 51);
            this.btnGuncelleKaydet.TabIndex = 32;
            this.btnGuncelleKaydet.Text = "Kaydet";
            this.btnGuncelleKaydet.UseVisualStyleBackColor = true;
            this.btnGuncelleKaydet.Click += new System.EventHandler(this.btnGuncelleKaydet_Click);
            // 
            // FrmDonemTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(764, 70);
            this.ControlBox = false;
            this.Controls.Add(this.Bitis);
            this.Controls.Add(this.Baslangic);
            this.Controls.Add(this.DonemYil);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelleKaydet);
            this.Controls.Add(this.btnYeniKaydet);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDonemTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnVazgec;
        public System.Windows.Forms.TextBox id;
        public System.Windows.Forms.Button btnYeniKaydet;
        public System.Windows.Forms.Button btnGuncelleKaydet;
        public System.Windows.Forms.ComboBox DonemYil;
        public System.Windows.Forms.DateTimePicker Baslangic;
        public System.Windows.Forms.DateTimePicker Bitis;
    }
}

