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
    public partial class frmdonemsec : Form


    {

        public frmdonemsec()


        {
            InitializeComponent();
        }
        public void listele()
        {
            SqlClass bgl = new SqlClass();

            SqlDataAdapter da = new SqlDataAdapter("Select *from TblYil", bgl.baglanti());
            DataSet ds = new DataSet();

            da.Fill(ds, "TblYil");
            dataGridView1.DataSource = ds.Tables["TblYil"];

            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "Y.NO";//data gridviewdeki kolonları başlığı
                dataGridView1.Columns[1].Width = 60;
                dataGridView1.Columns[1].HeaderText = "YIL";
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[2].HeaderText = "BAŞLANGIÇ";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].HeaderText = "BİTİŞ";
                dataGridView1.Columns[3].Width = 150;


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
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblYil where DonemYil like '%" + textBox1.Text + "%'  ", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "TblYil");

            dataGridView1.DataSource = ds.Tables["TblYil"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Baslangic.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Bitis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Baslangic.Text == ""||Bitis.Text=="")
            {
                MessageBox.Show("Seçim Yapmadınız", "Seçim Yapmalısınız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmVakitTanim fvt = (FrmVakitTanim)Application.OpenForms["FrmVakitTanim"];
                fvt.Baslangic.Text = Baslangic.Text;
                fvt.Bitis.Text = Bitis.Text;
                this.Close();
            }
        }
    }


}

