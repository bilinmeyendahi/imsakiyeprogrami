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
    public partial class frmUserList : Form
    {
        public frmUserList()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            ID.Clear();
            KullaniciAdi.Clear();
          
            Yetki.Clear();
        }
        public void listele()
        {

            SqlClass bgl = new SqlClass();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,KullaniciAdi,Yetki from TblKullanici", bgl.baglanti());
            DataSet ds = new DataSet();

            da.Fill(ds, "TblKullanici");
            dataGridView1.DataSource = ds.Tables["TblKullanici"];

            try
            {
                dataGridView1.Columns[0].HeaderText = "T.C.NO";//data gridviewdeki kolonları başlığı

                dataGridView1.Columns[1].HeaderText = "KULLANICI ADI";
                 dataGridView1.Columns[2].HeaderText = "YETKİ";
                dataGridView1.Columns[0].Width = 225;//datagridviewdeki kolonların genişliği
                dataGridView1.Columns[1].Width = 225;
                dataGridView1.Columns[2].Width = 225;
            



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void frmUserList_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmUserTanim fust = new FrmUserTanim();
            fust.Text = "Yeni Kullanıcı Oluşturma";
            fust.btnGuncelleKaydet.Visible = false;
            fust.TopMost = true;
            fust.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FrmUserTanim fut = new FrmUserTanim();
            fut.Text = "Kullanıcı Bilgilerini Görüntüleme";
            fut.btnYeniKaydet.Visible = false;
            fut.btnGuncelleKaydet.Visible = false;
            fut.ID.Text = ID.Text;
            fut.ID.ReadOnly = true;
            fut.KullaniciAdi.Text = KullaniciAdi.Text;
            fut.KullaniciAdi.ReadOnly = true;
            fut.Sifre.ReadOnly = true;
           
            fut.GuvenlikSoru.Enabled = false;
            fut.GuvenlikCevap.Enabled = false;
            fut.Yetki.Text = Yetki.Text;
            fut.Yetki.Enabled = false;
            fut.Show();
            fut.TopMost = true;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmUserTanim fust1 = new FrmUserTanim();
            fust1.Text = "Kullanıcı Bilgilerini Güncelleme";

            fust1.btnYeniKaydet.Visible = false;
            fust1.TopMost = true;
            fust1.ID.Text = ID.Text;
            fust1.ID.ReadOnly = true;
            fust1.KullaniciAdi.Text = KullaniciAdi.Text;
           

            fust1.Yetki.Text = Yetki.Text;

            fust1.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ID.Text.Trim() == "")
            {
                MessageBox.Show("Tablodan kayıt seçmediniz. Lütfen tablodan kayıt seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            else
            {

                DialogResult cevap;
                cevap = MessageBox.Show(KullaniciAdi.Text + " " + "kullanıcısını silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//silinme onayı için sorma hatalı kayıt silmenin önüne geçmek için.
                if (cevap == DialogResult.Yes)
                {
                    SqlClass bgl = new SqlClass();
                    SqlCommand komut = new SqlCommand();

                    komut.Connection = bgl.baglanti();
                    komut.CommandText = "delete from TblKullanici where ID=" + ID.Text + "";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("**SİLİNDİ**");
                    listele();
                    Temizle();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//hangi sütündaki alan hangi texte gelecek
            KullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
          
            Yetki.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlClass bgl = new SqlClass();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,KullaniciAdi,Yetki from TblKullanici where KullaniciAdi like '%" + textBox1.Text + "%' ", bgl.baglanti());
            DataSet ds = new DataSet();

            da.Fill(ds, "TblKullanici");

            dataGridView1.DataSource = ds.Tables["TblKullanici"];

            
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.goster();
            fan.menuStrip1.Enabled = true;
            this.Close();
        }
    }
}
