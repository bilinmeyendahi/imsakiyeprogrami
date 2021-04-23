namespace IMSAKIYE

{
    partial class FrmHatirla
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHatirla));
            this.KullaniciAdi = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sifre = new System.Windows.Forms.Label();
            this.GuvenlikCevap = new System.Windows.Forms.TextBox();
            this.lblcevap = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.GuvenlikSoru = new System.Windows.Forms.TextBox();
            this.btnSifrem = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.btntamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.KullaniciAdi.Location = new System.Drawing.Point(10, 37);
            this.KullaniciAdi.Name = "KullaniciAdi";
            this.KullaniciAdi.Size = new System.Drawing.Size(143, 23);
            this.KullaniciAdi.TabIndex = 2;
            this.KullaniciAdi.Text = "Kullanıcı Adı";
            this.KullaniciAdi.Click += new System.EventHandler(this.KullaniciAdi_Click);
            // 
            // ID
            // 
            this.ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ID.Location = new System.Drawing.Point(10, 8);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(143, 23);
            this.ID.TabIndex = 1;
            this.ID.Text = "Kullanıcı Kod";
            this.ID.Click += new System.EventHandler(this.TxtKullaniciKod_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre.ForeColor = System.Drawing.Color.White;
            this.sifre.Location = new System.Drawing.Point(12, 214);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(0, 59);
            this.sifre.TabIndex = 18;
            this.sifre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuvenlikCevap
            // 
            this.GuvenlikCevap.ForeColor = System.Drawing.Color.Black;
            this.GuvenlikCevap.Location = new System.Drawing.Point(9, 135);
            this.GuvenlikCevap.Name = "GuvenlikCevap";
            this.GuvenlikCevap.Size = new System.Drawing.Size(293, 23);
            this.GuvenlikCevap.TabIndex = 14;
            this.GuvenlikCevap.UseWaitCursor = true;
            // 
            // lblcevap
            // 
            this.lblcevap.AutoSize = true;
            this.lblcevap.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblcevap.Location = new System.Drawing.Point(12, 116);
            this.lblcevap.Name = "lblcevap";
            this.lblcevap.Size = new System.Drawing.Size(95, 16);
            this.lblcevap.TabIndex = 17;
            this.lblcevap.Text = "Cevabı Giriniz";
            this.lblcevap.UseWaitCursor = true;
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblsoru.Location = new System.Drawing.Point(12, 72);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(120, 16);
            this.lblsoru.TabIndex = 16;
            this.lblsoru.Text = "Güvenlik Sorunuz";
            this.lblsoru.UseWaitCursor = true;
            // 
            // GuvenlikSoru
            // 
            this.GuvenlikSoru.Enabled = false;
            this.GuvenlikSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GuvenlikSoru.Location = new System.Drawing.Point(10, 91);
            this.GuvenlikSoru.Name = "GuvenlikSoru";
            this.GuvenlikSoru.Size = new System.Drawing.Size(292, 23);
            this.GuvenlikSoru.TabIndex = 13;
            this.GuvenlikSoru.UseWaitCursor = true;
            // 
            // btnSifrem
            // 
            this.btnSifrem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSifrem.Location = new System.Drawing.Point(8, 164);
            this.btnSifrem.Name = "btnSifrem";
            this.btnSifrem.Size = new System.Drawing.Size(294, 47);
            this.btnSifrem.TabIndex = 15;
            this.btnSifrem.Text = "ŞİFREM NEDİR?";
            this.btnSifrem.UseVisualStyleBackColor = true;
            this.btnSifrem.UseWaitCursor = true;
            this.btnSifrem.Click += new System.EventHandler(this.BtntxtSifrem_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKapat.Location = new System.Drawing.Point(165, 37);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(137, 25);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSorgula.Location = new System.Drawing.Point(165, 4);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(137, 27);
            this.btnSorgula.TabIndex = 4;
            this.btnSorgula.Text = "SORGULA";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // btntamam
            // 
            this.btntamam.Location = new System.Drawing.Point(8, 315);
            this.btntamam.Name = "btntamam";
            this.btntamam.Size = new System.Drawing.Size(294, 23);
            this.btntamam.TabIndex = 19;
            this.btntamam.Text = "GİRİŞ SAYFASINA GÖNDER";
            this.btntamam.UseVisualStyleBackColor = true;
            this.btntamam.Click += new System.EventHandler(this.btntamam_Click);
            // 
            // FrmHatirla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(309, 343);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.GuvenlikCevap);
            this.Controls.Add(this.btntamam);
            this.Controls.Add(this.lblcevap);
            this.Controls.Add(this.btnSifrem);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.GuvenlikSoru);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.KullaniciAdi);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHatirla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HATIRLA";
            this.Load += new System.EventHandler(this.FrmHatirla_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmhatirla_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox KullaniciAdi;
        public System.Windows.Forms.Button btnSorgula;
        public System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sifre;
        public System.Windows.Forms.Button btnSifrem;
        public System.Windows.Forms.TextBox GuvenlikCevap;
        public System.Windows.Forms.Label lblcevap;
        public System.Windows.Forms.Label lblsoru;
        public System.Windows.Forms.TextBox GuvenlikSoru;
        private System.Windows.Forms.Button btntamam;
    }
}