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
    public partial class FrmImsakiye : Form


    {


        public FrmImsakiye()


        {
            InitializeComponent();
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
            SqlDataAdapter da = new SqlDataAdapter("Select ROW_NUMBER() OVER(ORDER BY id) AS SNo, Kadir,Bayram,Tarih,Gun,Sahur,Ogle,Ikindi,Iftar,Yatsi from TblImsakiye where Tarih >= '" + dateTimePicker1.Text + "' and Bolge='" + comboBox1.Text + "' ", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "TblImsakiye");

            dataGridView1.DataSource = ds.Tables["TblImsakiye"];
            try
            {

                dataGridView1.Columns[0].HeaderText = "S.N";
                
                dataGridView1.Columns[1].HeaderText = "KADİR";
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "BAYRAM";
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "TARİH";
                dataGridView1.Columns[4].HeaderText = "GÜN";
                dataGridView1.Columns[5].HeaderText = "SAHUR";
                dataGridView1.Columns[6].HeaderText = "ÖĞLE";
                dataGridView1.Columns[7].HeaderText = "İKİNDİ";
                dataGridView1.Columns[8].HeaderText = "AKŞAM";
                dataGridView1.Columns[9].HeaderText = "YATSI";


                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 80;
                dataGridView1.Columns[9].Width = 80;
                if (dataGridView1.RowCount >= 1)
                {
                    kadirgecesi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    bayramnamazi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Kayıt bulunamadı");
                }
            }
            catch
            {
                ;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.Goster();
            fan.menuStrip1.Enabled = true;
            this.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void FrmVakit_Load(object sender, EventArgs e)
        {

            bolgegetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
