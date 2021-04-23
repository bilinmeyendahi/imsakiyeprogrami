using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOKC

{
    public partial class frmana : Form
    {
        public frmana()
        {
            InitializeComponent();
        }
        public void gizle()
        {
            pbresim.Visible = false;
            isyeriTanımToolStripMenuItem.Enabled = false;
            kullanıcıTanımToolStripMenuItem.Enabled = false;
            urunTanımToolStripMenuItem.Enabled = false;
            MusteriTanımResmiToolStripMenuItem.Enabled = false;
            yazıcıTanımlamaToolStripMenuItem.Enabled = false;
            stokİşlemleriToolStripMenuItem.Enabled = false;
            satışİşlemiToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            pROGRAMDANÇIKIŞToolStripMenuItem.Enabled = false;
            işlemlerMenüsüToolStripMenuItem.Enabled = false;
            YARDIMtoolStripMenuItem.Enabled = false;
        }

        public void goster()
        {
            pbresim.Visible = true;
            isyeriTanımToolStripMenuItem.Enabled = true;
            kullanıcıTanımToolStripMenuItem.Enabled = true;
            urunTanımToolStripMenuItem.Enabled = true;
            MusteriTanımResmiToolStripMenuItem.Enabled = true;
            yazıcıTanımlamaToolStripMenuItem.Enabled = true;
            stokİşlemleriToolStripMenuItem.Enabled = true;
            satışİşlemiToolStripMenuItem.Enabled = true;
            raporlarToolStripMenuItem.Enabled = true;
            pROGRAMDANÇIKIŞToolStripMenuItem.Enabled = true;
            işlemlerMenüsüToolStripMenuItem.Enabled = true;
            YARDIMtoolStripMenuItem.Enabled = true;
        }

        private void kullanıcıTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList fut = new frmUserList();
            gizle();
            fut.MdiParent = this;
            fut.Show();
        }

        private void urunTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmuruntanim fur = new frmuruntanim();
            gizle();
            fur.MdiParent = this;
            fur.Show();*/
        }
        private void MusteriTanımResmiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmmusteri fmust = new frmmusteri();
            gizle();
            fmust.MdiParent = this;
            fmust.Show();*/
        }

        private void isyeriTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmisyeri fisy = new frmisyeri();
            gizle();
            fisy.MdiParent = this;
            fisy.Show();*/
        }

       

        private void yazıcıTanımlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmyazici fyt = new frmyazici();
            gizle();
            fyt.MdiParent = this;
            fyt.Show();*/
        }

        private void satışEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void genelStokRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmraporicmal frp = new frmraporicmal();
            gizle();
            frp.MdiParent = this;
            frp.Show();*/
        }

       

        private void SatışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmraporaylik frp = new frmraporaylik();
            gizle();
            frp.MdiParent = this;
            frp.Show();*/
        }

        private void PROGRAMDANÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
                
        }

        
        private void İşlemlerMenüsüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*AboutBox1 ab1 = new AboutBox1();
            gizle();
            ab1.MdiParent = this;
            ab1.Show();*/
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(@"yardim.chm");

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            }
        private void StokİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmstok fst = new frmstok();
            gizle();
            fst.MdiParent = this;
            fst.Show();*/
        }

        private void SatışİşlemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmsatis fst = new frmsatis();
            gizle();
            fst.MdiParent = this;
            fst.Show();*/
        }

        private void müşteriBazlıİcmalRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmrapormusteri frpm = new frmrapormusteri();
            gizle();
            frpm.MdiParent = this;
            frpm.Show();*/
        }

        private void müşteriBazlıAylıkSatışRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmrapormusteri2 frpm2 = new frmrapormusteri2();
            gizle();
            frpm2.MdiParent = this;
            frpm2.Show();*/
        }
    }
}
