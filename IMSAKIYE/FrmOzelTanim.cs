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
    public partial class FrmOzelTanim : Form


    {

        public FrmOzelTanim()


        {
            InitializeComponent();
        }

        private void btnGuncelleKaydet_Click(object sender, EventArgs e)
        {
            if (id.Text == "" )//tüm text alanları boş geçilirse
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata:Güvenlik Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);//uyarı mesajı verdir
            }
            else

            {

                SqlClass bgl = new SqlClass();
                SqlCommand komut = new SqlCommand();
                komut.Connection = bgl.baglanti();
                komut.CommandText = "UPDATE TblOzel SET kadirgecesi='" + kadirgecesi.Text + "',bayramnamazi='" + bayramnamazi.Text + "'WHERE id=" + id.Text + "";
                komut.ExecuteNonQuery();
                MessageBox.Show("**GÜNCELLENDİ**");
                frmozel fst = (frmozel)Application.OpenForms["frmozel"];
                fst.listele();
                fst.Temizle();
                this.Close();


            }
        }



        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
           
                SqlClass bgl = new SqlClass();
                SqlCommand komut = new SqlCommand();
                komut.Connection = bgl.baglanti();
                komut.CommandText = "INSERT INTO TblOzel(kadirgecesi,bayramnamazi) VALUES ('" + kadirgecesi.Text + "','" + bayramnamazi.Text + "') ";
                komut.ExecuteNonQuery();


                MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmozel fst = (frmozel)Application.OpenForms["frmozel"];
                fst.listele();
                fst.Temizle();
                this.Close();
            

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            frmozel fst = (frmozel)Application.OpenForms["frmozel"];

            fst.Temizle();
            this.Close();
        }
    }
}
