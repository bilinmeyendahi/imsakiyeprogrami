using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace STOKC


{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();

        }

        public SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");



        private void label1_Click(object sender, EventArgs e)
        {
            FrmHatirla ac = new FrmHatirla();
            ac.Show();
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(KullaniciAdi.Text) || String.IsNullOrWhiteSpace(Sifre.Text))
            {
                MessageBox.Show("Eksiksiz Giriniz!", " HATA ::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            try
            {

                SqlClass bgl = new SqlClass();
                string sql = "select * FROM TblKullanici WHERE KullaniciAdi=@KullaniciAdi AND Sifre=@Sifre";
                SqlParameter prms1 = new SqlParameter("@KullaniciAdi", KullaniciAdi.Text);
                SqlParameter prms2 = new SqlParameter("@Sifre", Sifre.Text);
                SqlCommand cmd = new SqlCommand(sql, bgl.baglanti());
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count != 0)

                {
                    frmana fas = new frmana();
                    fas.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı ve şifre", "..::HATA::..");
                    Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
