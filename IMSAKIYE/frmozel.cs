using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSAKIYE

{
    public partial class frmozel : Form


    {

        public frmozel()


        {
            InitializeComponent();
        }
        public void Temizle()
        {
            id.Clear();
          


        }

        public void listele()
        {
            SqlClass bgl = new SqlClass();

            SqlDataAdapter da = new SqlDataAdapter("Select *from TblOzel", bgl.baglanti());
            DataSet ds = new DataSet();

            da.Fill(ds, "TblOzel");
            dataGridView1.DataSource = ds.Tables["TblOzel"];

            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "G.NO";//data gridviewdeki kolonları başlığı
                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].HeaderText = "KADİR GECESİ";
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].HeaderText = "BAYRAM NAMAZI";
                dataGridView1.Columns[2].Width = 200;
                


            }
            catch
            {
                ;
            }
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//hangi sütündaki alan hangi texte gelecek
                      kadirgecesi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bayramnamazi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void frmbolge_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.Show();
            fan.Goster();
            this.Close();
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            FrmOzelTanim fdt = new FrmOzelTanim();
            fdt.Text = "Yeni Kayıt Oluşturma";
            fdt.btnGuncelleKaydet.Visible = false;
            fdt.TopMost = true;
            fdt.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmOzelTanim fdt = new FrmOzelTanim();
            fdt.Text = "Bilgileri Güncelleme";

            fdt.btnYeniKaydet.Visible = false;
            fdt.TopMost = true;
            fdt.id.Text = id.Text;
            fdt.id.ReadOnly = true;
            
            fdt.kadirgecesi.Text = kadirgecesi.Text;
            fdt.bayramnamazi.Text = bayramnamazi.Text;
            fdt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (id.Text.Trim() == "")
            {
                MessageBox.Show("Tablodan kayıt seçmediniz. Lütfen tablodan kayıt seçiniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            else
            {

                DialogResult cevap;
                cevap = MessageBox.Show("Kaydı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//silinme onayı için sorma hatalı kayıt silmenin önüne geçmek için.
                if (cevap == DialogResult.Yes)
                {
                    SqlClass bgl = new SqlClass();
                    SqlCommand komut = new SqlCommand();

                    komut.Connection = bgl.baglanti();
                    komut.CommandText = "delete from TblOzel where id=" + id.Text + "";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("**SİLİNDİ**");
                    listele();
                    Temizle();
                }
            }
        }
    }
}
