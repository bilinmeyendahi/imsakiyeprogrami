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
    public partial class FrmDonemTanim : Form

    {

        public FrmDonemTanim()

        {
            InitializeComponent();
        }

        private void btnGuncelleKaydet_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || DonemYil.Text == "")//tüm text alanları boş geçilirse
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata:Güvenlik Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);//uyarı mesajı verdir
            }
            else

            {

                SqlClass bgl = new SqlClass();
                SqlCommand komut = new SqlCommand();
                komut.Connection = bgl.baglanti();
                komut.CommandText = "UPDATE TblYil SET DonemYil='" + DonemYil.Text + "',Baslangic='" + Baslangic.Text + "',Bitis='" + Bitis.Text + "'WHERE id=" + id.Text + "";
                komut.ExecuteNonQuery();
                MessageBox.Show("**GÜNCELLENDİ**");
                frmdonem fst = (frmdonem)Application.OpenForms["frmdonem"];
                fst.listele();
                fst.Temizle();
                this.Close();


            }
        }



        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            if (DonemYil.Text == "")//tüm text alanları boş geçilirse
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata:Güvenlik Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);//uyarı mesajı verdir
            }
            else
            {
                SqlClass bgl = new SqlClass();
                SqlCommand komut = new SqlCommand();
                komut.Connection = bgl.baglanti();
                komut.CommandText = "INSERT INTO TblYil(DonemYil,Baslangic,Bitis) VALUES ('" + DonemYil.Text + "','" + Baslangic.Text + "','" + Bitis.Text + "') ";
                komut.ExecuteNonQuery();




                MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmdonem fst = (frmdonem)Application.OpenForms["frmdonem"];
                fst.listele();
                fst.Temizle();
                this.Close();
            }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            frmdonem fst = (frmdonem)Application.OpenForms["frmdonem"];

            fst.Temizle();
            this.Close();
        }
    }
}
