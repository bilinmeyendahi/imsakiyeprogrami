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

namespace STOKC
{
    public partial class frmyazici : Form
    {
       
        public frmyazici()
        {
            InitializeComponent();
        }
        public void listele()
        {
            SqlClass bgl = new SqlClass();
           
            SqlDataAdapter da = new SqlDataAdapter("Select *from TblPrinters", bgl.baglanti());
            DataSet ds = new DataSet();
            
            da.Fill(ds, "TblPrinters");
            dataGridView1.DataSource = ds.Tables["TblPrinters"];
           
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].HeaderText = "P.NO";//data gridviewdeki kolonları başlığı

                dataGridView1.Columns[1].HeaderText = "BELGE YAZICI";
                dataGridView1.Columns[2].HeaderText = "FİŞ YAZICI";

                dataGridView1.Columns[0].Width = 60;//datagridviewdeki kolonların genişliği
                dataGridView1.Columns[1].Width = 275;
                dataGridView1.Columns[2].Width = 275;



            }
            catch
            {
                ;
            }
        }
public void printerlist()
        {
            foreach(string yazici in PrinterSettings.InstalledPrinters)
            {
                belgePrint.Items.Add(yazici);
                fisPrint.Items.Add(yazici);
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.Show();
            fan.Goster();
            this.Close();
        }

      
        private void frmyazici_Load(object sender, EventArgs e)
        {
            
            printerlist();
            listele();
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
                komut.CommandText = "UPDATE TblPrinters SET belgePrint='" + belgePrint.Text + "',fisPrint='" + fisPrint.Text + "'WHERE pn=" + pn.Text + "";//update komutu
                komut.ExecuteNonQuery();
               
                MessageBox.Show("**GÜNCELLENDİ**");
                listele();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pn.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//hangi sütündaki alan hangi texte gelecek
            belgePrint.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            fisPrint.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
