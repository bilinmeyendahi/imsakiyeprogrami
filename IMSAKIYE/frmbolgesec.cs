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
    public partial class frmbolgesec : Form

    {

        public frmbolgesec()

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
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblCityKaza where ililce like '%" + textBox1.Text + "%'  ", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "TblCityKaza");

            dataGridView1.DataSource = ds.Tables["TblCityKaza"];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ililce.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ililce.Text == "")
            {
                MessageBox.Show("Seçim Yapmadınız", "Seçim Yapmalısınız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                FrmVakitTanim fvt = (FrmVakitTanim)Application.OpenForms["FrmVakitTanim"];
                fvt.Bolge.Text =ililce.Text;
                this.Close();
            }
        }
    }


}

