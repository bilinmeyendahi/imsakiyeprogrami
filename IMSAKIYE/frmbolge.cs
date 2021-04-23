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
    public partial class frmbolge : Form
    {
       
        public frmbolge()
        {
            InitializeComponent();
        }
        public void listele()
        {
            SqlClass bgl = new SqlClass();
           
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblCityKaza", bgl.baglanti());
            DataSet ds = new DataSet();
            
            da.Fill(ds, "TblCityKaza");
            dataGridView1.DataSource = ds.Tables["TblCityKaza"];
           
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "i.NO";//data gridviewdeki kolonları başlığı

                dataGridView1.Columns[1].HeaderText = "İL-İLÇE";
              
                dataGridView1.Columns[1].Width = 350;
                



            }
            catch
            {
                ;
            }
        }

        public void ilgetir()
        {

            SqlClass bgl = new SqlClass();
            SqlDataAdapter adaptor = new SqlDataAdapter("select * from TblCity  ", bgl.baglanti());
            DataTable tablo2 = new DataTable();
            adaptor.Fill(tablo2);
            illiste.ValueMember = "id";
            illiste.DisplayMember = "baslik";
            illiste.DataSource = tablo2;
            illiste.Text = "";
           
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.Show();
            fan.Goster();
            this.Close();
        }

      
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (pn.Text == "")
            {
                MessageBox.Show("Lütfen listeden seçim yapınız", "SEÇİM YAPMADINIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlClass bgl = new SqlClass();
                SqlCommand komut = new SqlCommand();
               
                komut.Connection = bgl.baglanti();

                //cmd = new SQLiteCommand();
                //con.Open();
                //cmd.Connection = con;
                //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);
                komut.CommandText = "UPDATE TblCityKaza SET ililce='" + ililce.Text + "'WHERE pn=" + pn.Text + "";//update komutu
                komut.ExecuteNonQuery();
               
                MessageBox.Show("**GÜNCELLENDİ**");
                listele();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//hangi sütündaki alan hangi texte gelecek
            ililce.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            
        }

        private void frmbolge_Load(object sender, EventArgs e)
        {
            ilgetir();
            listele();
        }

        private void illiste_SelectedValueChanged(object sender, EventArgs e)
        {
            if (illiste.SelectedIndex != -1)
            {
                SqlClass bgl = new SqlClass();
                SqlDataAdapter adaptor = new SqlDataAdapter("select * from TblKaza where ilid = " + illiste.SelectedValue, bgl.baglanti());
                DataTable tablo = new DataTable();
                adaptor.Fill(tablo);
                ilceliste.ValueMember = "id";
                ilceliste.DisplayMember = "ilcead";
                ilceliste.DataSource = tablo;
                ilceliste.Text = "";
            }
        }

        private void ilceliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            ililce.Text = illiste.Text + " - " + ilceliste.Text;
        }
    }
}
