using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSAKIYE

{
    public partial class FrmVakit : Form

    {
        

        public FrmVakit()

        {
            InitializeComponent();
        }
       
        public void temizle()
        {
            id.Clear();
            Bolge.Clear();
            Baslangic.Clear();
            Bitis.Clear();
            Kadir.Clear();
            Bayram.Clear();
            Tarih.Clear();
            Gun.Clear();
            Sahur.Clear();
            Ogle.Clear();
            Ikindi.Clear();
            Iftar.Clear();
            Yatsi.Clear();

        }
        public void bolgegetir()
        {
            SqlClass bgl = new SqlClass();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from TblCityKaza  ", bgl.baglanti());
            DataTable tablo2 = new DataTable();
            adaptor.Fill(tablo2);
            comboBox1.ValueMember = "pn";
            comboBox1.DisplayMember = "ililce";
            comboBox1.DataSource = tablo2;
            comboBox1.Text = "";
        }

        public void listele()
        {

            SqlClass bgl = new SqlClass();
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblImsakiye ORDER BY id DESC", bgl.baglanti());
            DataSet ds = new DataSet();
           
            da.Fill(ds, "TblImsakiye");
            dataGridView1.DataSource = ds.Tables["TblImsakiye"];
           
            try
            {
                dataGridView1.Columns[0].HeaderText = "KOD";//data gridviewdeki kolonları başlığı

                dataGridView1.Columns[1].HeaderText = "BÖLGE";
                dataGridView1.Columns[2].HeaderText = "BAŞLANGIÇ";
                dataGridView1.Columns[3].HeaderText = "BİTİŞ";
                dataGridView1.Columns[4].HeaderText = "KADİR";
                dataGridView1.Columns[5].HeaderText = "BAYRAM";
                dataGridView1.Columns[6].HeaderText = "TARİH";
                dataGridView1.Columns[7].HeaderText = "GÜN";
                dataGridView1.Columns[8].HeaderText = "SAHUR";
                dataGridView1.Columns[9].HeaderText = "ÖĞLE";
                dataGridView1.Columns[10].HeaderText = "İKİNDİ";
                dataGridView1.Columns[11].HeaderText = "AKŞAM";
                dataGridView1.Columns[12].HeaderText = "YATSI";

                dataGridView1.Columns[0].Width = 60;//datagridviewdeki kolonların genişliği
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 130;
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[8].Width = 80;
                dataGridView1.Columns[9].Width = 80;
                dataGridView1.Columns[10].Width = 80;
                dataGridView1.Columns[11].Width = 80;
                dataGridView1.Columns[12].Width = 80;

            }
            catch
            {
                ;
            }
        }

        
       

       

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Bolge.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Baslangic.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Bitis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Kadir.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Bayram.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Tarih.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Gun.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            Sahur.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            Ogle.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            Ikindi.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Iftar.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            Yatsi.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //frmstok fst = (frmstok)Application.OpenForms["frmstok"];
            //fst.Show();
            //fst.Enabled = true;
            //fst.urunadet.Text = "0";
            //this.Close();
        }

       

        

       

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.Goster();
            fan.menuStrip1.Enabled = true;
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmVakitTanim fust = new FrmVakitTanim();
            fust.Text = "Yeni Kayıt Oluşturma";
            fust.GuncelleKaydet.Visible = false;
            fust.TopMost = true;
            fust.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmVakitTanim fut = new FrmVakitTanim();
                     
            fut.Text = " Bilgileri Görüntüleme";
            fut.GuncelleKaydet.Visible = false;
            fut.Kaydet.Visible = false;
            fut.id.Text = id.Text;
            fut.Bolge.Text = Bolge.Text;
            fut.Baslangic.Text = Baslangic.Text;
            fut.Bitis.Text = Bitis.Text;
            fut.Kadir.Text = Kadir.Text;
            fut.Bayram.Text = Bayram.Text;
            fut.Tarih.Text = Tarih.Text;
            fut.Gun.Text = Gun.Text;
            fut.Sahur.Text = Sahur.Text;
            fut.Ogle.Text = Ogle.Text;
            fut.Ikindi.Text = Ikindi.Text;
            fut.Iftar.Text = Iftar.Text;
            fut.Yatsi.Text = Yatsi.Text;

            fut.id.ReadOnly = true;
            fut.Show();
            fut.TopMost = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
           FrmVakitTanim fust1 = new FrmVakitTanim();
             fust1.Text = "Bilgileri Güncelleme";

            fust1.Kaydet.Visible = false;
            fust1.TopMost = true;
            fust1.id.Text = id.Text;
            fust1.Bolge.Text = Bolge.Text;
            fust1.Baslangic.Text = Baslangic.Text;
            fust1.Bitis.Text = Bitis.Text;
            fust1.Kadir.Text = Kadir.Text;
            fust1.Bayram.Text = Bayram.Text;
            fust1.Tarih.Text = Tarih.Text;
            fust1.Gun.Text = Gun.Text;
            fust1.Sahur.Text = Sahur.Text;
            fust1.Ogle.Text = Ogle.Text;
            fust1.Ikindi.Text = Ikindi.Text;
            fust1.Iftar.Text = Iftar.Text;
            fust1.Yatsi.Text = Yatsi.Text;
           
            fust1.id.ReadOnly = true;
            
           
           
            fust1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlClass bgl = new SqlClass();
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblImsakiye where Tarih = '" + dateTimePicker1.Text + "' and Bolge='"+comboBox1.Text+"' ", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "TblImsakiye");

            dataGridView1.DataSource = ds.Tables["TblImsakiye"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void FrmVakit_Load(object sender, EventArgs e)
        {
            listele();
            bolgegetir();
        }
    }
    }
