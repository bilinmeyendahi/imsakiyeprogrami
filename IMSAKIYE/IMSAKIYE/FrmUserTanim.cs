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

namespace STOKC
{
    public partial class FrmUserTanim : Form
    {

        public FrmUserTanim()
        {
            InitializeComponent();
        }

        private void btnGuncelleKaydet_Click(object sender, EventArgs e)
        {
            if (ID.Text == "" || KullaniciAdi.Text == ""  || Yetki.Text == "")//tüm text alanları boş geçilirse
            {
                MessageBox.Show("Boş Alan Bırakmayınız", "Hata:Güvenlik Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);//uyarı mesajı verdir
            }
            else

            {
                if (Sifre.Text == "" || GuvenlikSoru.Text == "" || GuvenlikCevap.Text == "")

                {
                    SqlClass bgl = new SqlClass();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = bgl.baglanti();
                    komut.CommandText = "UPDATE TblKullanici SET KullaniciAdi='" + KullaniciAdi.Text + "',Yetki='" + Yetki.Text + "' WHERE ID=" + ID.Text + "";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("**GÜNCELLENDİ**");
                    frmUserList fst = (frmUserList)Application.OpenForms["frmUserList"];
                    fst.listele();
                    fst.Temizle();
                    this.Close();

                }
                else
                {
                    SqlClass bgl = new SqlClass();
                    SqlCommand komut = new SqlCommand();
                    komut.Connection = bgl.baglanti();
                    komut.CommandText = "UPDATE TblKullanici SET KullaniciAdi='" + KullaniciAdi.Text + "',Sifre='" + Sifre.Text + "',GuvenlikSoru='" + GuvenlikSoru.Text + "',GuvenlikCevap='" + GuvenlikCevap.Text + "',Yetki='" + Yetki.Text + "' WHERE ID=" + ID.Text + "";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("**GÜNCELLENDİ**");
                    frmUserList fst = (frmUserList)Application.OpenForms["frmUserList"];
                    fst.listele();
                    fst.Temizle();
                    this.Close();
                }

            }
        }
    


    private void btnYeniKaydet_Click(object sender, EventArgs e)
    {
        if (ID.Text == "" || KullaniciAdi.Text == "" || Sifre.Text == "" ||  GuvenlikSoru.Text == "" || GuvenlikCevap.Text == "" || Yetki.Text == "")//tüm text alanları boş geçilirse
        {
            MessageBox.Show("Boş Alan Bırakmayınız", "Hata:Güvenlik Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Error);//uyarı mesajı verdir
        }
        else
        {
            SqlClass bgl = new SqlClass();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bgl.baglanti();
            komut.CommandText = "INSERT INTO TblKullanici(ID,KullaniciAdi,Sifre,GuvenlikSoru,GuvenlikCevap,Yetki) VALUES ('" + ID.Text + "','" + KullaniciAdi.Text + "','" + Sifre.Text + "','" + GuvenlikSoru.Text + "','" + GuvenlikCevap.Text + "','" + Yetki.Text + "') ";
            komut.ExecuteNonQuery();




            MessageBox.Show("Kayıt İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmUserList fst = (frmUserList)Application.OpenForms["frmUserList"];
                fst.listele();
                fst.Temizle();
                this.Close();
        }

    }

    private void btnVazgec_Click(object sender, EventArgs e)
    {
            frmUserList fst = (frmUserList)Application.OpenForms["frmUserList"];
         
            fst.Temizle();
            this.Close();
    }
}
    }
