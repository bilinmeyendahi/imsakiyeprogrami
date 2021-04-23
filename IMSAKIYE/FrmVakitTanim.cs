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
    public partial class FrmVakitTanim : Form
    {
        
        public FrmVakitTanim()
        {
            InitializeComponent();
        }
       

       

        private void button3_Click(object sender, EventArgs e)
        {
            if (id.Text == "" )
            {
                MessageBox.Show("Alanları Boş Geçmeyiniz", "Boş Alan Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlClass bgl = new SqlClass();
                
                SqlCommand komut = new SqlCommand();

                komut.Connection = bgl.baglanti();
                //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);
                komut.CommandText = "UPDATE TblImsakiye SET Bolge='" + Bolge.Text + "',Baslangic='" + Baslangic.Text + "',Bitis='" + Bitis.Text + "',Kadir='" + Kadir.Text + "',Tarih='" + Tarih.Text + "',Gun='" + Gun.Text + "',Sahur='" + Sahur.Text + "',Ogle='" + Ogle.Text + "',Ikindi='" + Ikindi.Text + "',Iftar='" + Iftar.Text + "',Yatsi='" + Yatsi.Text + "' WHERE id=" + id.Text + "";//update komutu
                komut.ExecuteNonQuery();

                MessageBox.Show("**GÜNCELLENDİ**");

                FrmVakit fst = (FrmVakit)Application.OpenForms["FrmVakit"];
                fst.listele();
                fst.temizle();
                this.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmVakit fst = (FrmVakit)Application.OpenForms["FrmVakit"];
            fst.temizle();
            this.Close();
        }


       

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmbolgesec fbs = new frmbolgesec();
            fbs.TopMost = true;
            fbs.Show();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmdonemsec fds = new frmdonemsec();
            fds.TopMost = true;
            fds.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmozelsec fos = new frmozelsec();
            fos.TopMost = true;
            fos.Show();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            SqlClass bgl = new SqlClass();

            SqlCommand komut = new SqlCommand();

            komut.Connection = bgl.baglanti();
            komut.CommandText = "INSERT INTO TblImsakiye(Bolge,Baslangic,Bitis,Kadir,Bayram,Tarih,Gun,Sahur,Ogle,Ikindi,Iftar,Yatsi) VALUES ('" + Bolge.Text + "','" + Baslangic.Text + "','" + Bitis.Text + "','" + Kadir.Text + "','" + Bayram.Text + "','" + Tarih.Text + "','" + Gun.Text + "','" + Sahur.Text + "','" + Ogle.Text + "','" + Ikindi.Text + "','" + Iftar.Text + "','" + Yatsi.Text + "')";//veritabanına kayıt ekleme komutu
            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//kayot eklendiğine dair kullanıcı bilgilendirme
            Gun.Text= "";

      
            
        }
    }
    }
