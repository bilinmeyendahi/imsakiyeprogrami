using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace IMSAKIYE


   
{
    
    public partial class FrmHatirla : Form
    {
       
        public FrmHatirla()
        {
            InitializeComponent();
        }




       

        public void panelgizle()
        {
            lblsoru.Visible = false;
            GuvenlikSoru.Visible = false;
            lblcevap.Visible = false;
            GuvenlikCevap.Visible = false;
            btnSifrem.Visible = false;
            btntamam.Visible = false;
            sifre.Visible = false;
        }

        public void panelgoster()
        {
            lblsoru.Visible = true;
            GuvenlikSoru.Visible = true;
            lblcevap.Visible = true;
            GuvenlikCevap.Visible = true;
            btnSifrem.Visible = true;
            btntamam.Visible = true;
            sifre.Visible = true;
        }
        private void btnSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                SqlClass bgl = new SqlClass();

                SqlCommand komut = new SqlCommand();
                
                komut.Connection = bgl.baglanti();
                komut.CommandText = "Select * from TblKullanici where ID=@ID AND KullaniciAdi=@KullaniciAdi";
                komut.Parameters.AddWithValue("@ID", ID.Text);
                komut.Parameters.AddWithValue("@KullaniciAdi", KullaniciAdi.Text);
                komut.ExecuteNonQuery();
              SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    GuvenlikSoru.Text = dr["GuvenlikSoru"].ToString();
                    panelgoster();
                    btntamam.Visible = false;
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı.");
                    Environment.Exit(0);
                }
                //baglanti.Dispose();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



       



       
        private void timer1_Tick(object sender, EventArgs e)
        {

            Random Rastgele = new Random();
            int sy1 = Rastgele.Next(0, 999);
            sifre.ForeColor = Color.FromArgb(sy1);
        }

       

        private void frmhatirla_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Make a GraphicsPath to represent the ellipse.
            Rectangle rect = new Rectangle(
                10, 10,
                this.ClientSize.Width - 20,
                this.ClientSize.Height - 20);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);

            // Make a PathGradientBrush from the path.
            using (PathGradientBrush br = new PathGradientBrush(path))
            {
                br.CenterColor = Color.Blue;
                br.SurroundColors = new Color[] { this.BackColor };
                e.Graphics.FillEllipse(br, rect);
            }
        }


        private void BtntxtSifrem_Click(object sender, EventArgs e)
        {
            try
            {

                SqlClass bgl = new SqlClass();
                SqlCommand komut = new SqlCommand();
                
                komut.Connection = bgl.baglanti();
                komut.CommandText = "Select * from TblKullanici where GuvenlikSoru=@GuvenlikSoru AND GuvenlikCevap=@GuvenlikCevap";
                komut.Parameters.AddWithValue("@GuvenlikSoru", GuvenlikSoru.Text);
                komut.Parameters.AddWithValue("@GuvenlikCevap", GuvenlikCevap.Text);
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {

                    sifre.Text = dr["Sifre"].ToString();
                    panelgoster();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı.");
                    Environment.Exit(0);
                }
                //baglanti.Dispose();
              
            }
         catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

}

private void TxtKullaniciKod_Click(object sender, EventArgs e)
{
    ID.Clear();

}



private void btntamam_Click(object sender, EventArgs e)
{
    frmgiris fg = (frmgiris)Application.OpenForms["frmgiris"];
    fg.KullaniciAdi.Text = KullaniciAdi.Text;
    fg.Sifre.Text = sifre.Text;
    fg.Show();
    this.Close();
}

        private void FrmHatirla_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            panelgizle();
        }

        private void KullaniciAdi_Click(object sender, EventArgs e)
        {
            KullaniciAdi.Clear();
        }
    }
}

       
       

      
    

    
       
