namespace IMSAKIYE

{
    partial class FrmVakit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVakit));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Bolge = new System.Windows.Forms.TextBox();
            this.Baslangic = new System.Windows.Forms.TextBox();
            this.Bitis = new System.Windows.Forms.TextBox();
            this.Kadir = new System.Windows.Forms.TextBox();
            this.Bayram = new System.Windows.Forms.TextBox();
            this.Tarih = new System.Windows.Forms.TextBox();
            this.Gun = new System.Windows.Forms.TextBox();
            this.Sahur = new System.Windows.Forms.TextBox();
            this.Ogle = new System.Windows.Forms.TextBox();
            this.Ikindi = new System.Windows.Forms.TextBox();
            this.Iftar = new System.Windows.Forms.TextBox();
            this.Yatsi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tarihe Göre Ara";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 456);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(21, 46);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(59, 23);
            this.id.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Image = global::IMSAKIYE.Properties.Resources.Custom_Icon_Design_Flatastic_2_Product;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(502, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 41);
            this.button1.TabIndex = 48;
            this.button1.Text = "YENİLE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = global::IMSAKIYE.Properties.Resources.Custom_Icon_Design_Flatastic_8_Go_back;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(784, 498);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(485, 41);
            this.btnCikis.TabIndex = 47;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = global::IMSAKIYE.Properties.Resources.Papirus_Team_Papirus_Apps_Iron_product_logo;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.Location = new System.Drawing.Point(248, 497);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(248, 41);
            this.btnGuncelle.TabIndex = 45;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::IMSAKIYE.Properties.Resources.Custom_Icon_Design_Flatastic_4_Add_item;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(11, 497);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(231, 41);
            this.btnEkle.TabIndex = 44;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 49;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(756, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(837, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 51;
            this.button3.Text = "TEMİZLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(334, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(416, 24);
            this.comboBox1.TabIndex = 52;
            // 
            // Bolge
            // 
            this.Bolge.Location = new System.Drawing.Point(86, 46);
            this.Bolge.Name = "Bolge";
            this.Bolge.ReadOnly = true;
            this.Bolge.Size = new System.Drawing.Size(100, 23);
            this.Bolge.TabIndex = 53;
            // 
            // Baslangic
            // 
            this.Baslangic.Location = new System.Drawing.Point(192, 46);
            this.Baslangic.Name = "Baslangic";
            this.Baslangic.ReadOnly = true;
            this.Baslangic.Size = new System.Drawing.Size(100, 23);
            this.Baslangic.TabIndex = 54;
            // 
            // Bitis
            // 
            this.Bitis.Location = new System.Drawing.Point(298, 46);
            this.Bitis.Name = "Bitis";
            this.Bitis.ReadOnly = true;
            this.Bitis.Size = new System.Drawing.Size(100, 23);
            this.Bitis.TabIndex = 55;
            // 
            // Kadir
            // 
            this.Kadir.Location = new System.Drawing.Point(404, 46);
            this.Kadir.Name = "Kadir";
            this.Kadir.ReadOnly = true;
            this.Kadir.Size = new System.Drawing.Size(100, 23);
            this.Kadir.TabIndex = 56;
            // 
            // Bayram
            // 
            this.Bayram.Location = new System.Drawing.Point(510, 46);
            this.Bayram.Name = "Bayram";
            this.Bayram.ReadOnly = true;
            this.Bayram.Size = new System.Drawing.Size(100, 23);
            this.Bayram.TabIndex = 57;
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(616, 46);
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Size = new System.Drawing.Size(100, 23);
            this.Tarih.TabIndex = 58;
            // 
            // Gun
            // 
            this.Gun.Location = new System.Drawing.Point(722, 46);
            this.Gun.Name = "Gun";
            this.Gun.ReadOnly = true;
            this.Gun.Size = new System.Drawing.Size(84, 23);
            this.Gun.TabIndex = 59;
            // 
            // Sahur
            // 
            this.Sahur.Location = new System.Drawing.Point(812, 46);
            this.Sahur.Name = "Sahur";
            this.Sahur.ReadOnly = true;
            this.Sahur.Size = new System.Drawing.Size(79, 23);
            this.Sahur.TabIndex = 60;
            // 
            // Ogle
            // 
            this.Ogle.Location = new System.Drawing.Point(897, 46);
            this.Ogle.Name = "Ogle";
            this.Ogle.ReadOnly = true;
            this.Ogle.Size = new System.Drawing.Size(81, 23);
            this.Ogle.TabIndex = 61;
            // 
            // Ikindi
            // 
            this.Ikindi.Location = new System.Drawing.Point(984, 46);
            this.Ikindi.Name = "Ikindi";
            this.Ikindi.ReadOnly = true;
            this.Ikindi.Size = new System.Drawing.Size(63, 23);
            this.Ikindi.TabIndex = 62;
            // 
            // Iftar
            // 
            this.Iftar.Location = new System.Drawing.Point(1053, 46);
            this.Iftar.Name = "Iftar";
            this.Iftar.ReadOnly = true;
            this.Iftar.Size = new System.Drawing.Size(75, 23);
            this.Iftar.TabIndex = 63;
            // 
            // Yatsi
            // 
            this.Yatsi.Location = new System.Drawing.Point(1134, 46);
            this.Yatsi.Name = "Yatsi";
            this.Yatsi.ReadOnly = true;
            this.Yatsi.Size = new System.Drawing.Size(75, 23);
            this.Yatsi.TabIndex = 64;
            // 
            // FrmVakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1281, 551);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Yatsi);
            this.Controls.Add(this.Iftar);
            this.Controls.Add(this.Ikindi);
            this.Controls.Add(this.Ogle);
            this.Controls.Add(this.Sahur);
            this.Controls.Add(this.Gun);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.Bayram);
            this.Controls.Add(this.Kadir);
            this.Controls.Add(this.Bitis);
            this.Controls.Add(this.Baslangic);
            this.Controls.Add(this.Bolge);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVakit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vakit Listesi";
            this.Load += new System.EventHandler(this.FrmVakit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Bolge;
        private System.Windows.Forms.TextBox Baslangic;
        private System.Windows.Forms.TextBox Bitis;
        private System.Windows.Forms.TextBox Kadir;
        private System.Windows.Forms.TextBox Bayram;
        private System.Windows.Forms.TextBox Tarih;
        private System.Windows.Forms.TextBox Gun;
        private System.Windows.Forms.TextBox Sahur;
        private System.Windows.Forms.TextBox Ogle;
        private System.Windows.Forms.TextBox Ikindi;
        private System.Windows.Forms.TextBox Iftar;
        private System.Windows.Forms.TextBox Yatsi;
    }
}