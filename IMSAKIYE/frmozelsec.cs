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
    public partial class frmozelsec : Form



    {

        public frmozelsec()

        {
            InitializeComponent();
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
                dataGridView1.Columns[1].Width = 60;
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


        private void button2_Click(object sender, EventArgs e)
        {
            FrmVakitTanim fan = (FrmVakitTanim)Application.OpenForms["FrmVakitTanim"];

            this.Close();
        }


        private void frmbolge_Load(object sender, EventArgs e)
        {

            listele();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlClass bgl = new SqlClass();
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblOzel where kadirgecesi like '%" + textBox1.Text + "%'  ", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "TblOzel");

            dataGridView1.DataSource = ds.Tables["TblOzel"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kadirgecesi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bayramnamazi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kadirgecesi.Text == ""||bayramnamazi.Text=="")
            {
                MessageBox.Show("Seçim Yapmadınız", "Seçim Yapmalısınız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmVakitTanim fvt = (FrmVakitTanim)Application.OpenForms["FrmVakitTanim"];
                fvt.Kadir.Text = kadirgecesi.Text;
                fvt.Bayram.Text = bayramnamazi.Text;
                this.Close();
            }
        }
    }


}

