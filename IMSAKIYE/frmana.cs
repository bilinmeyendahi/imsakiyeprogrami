using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMSAKIYE

{
    public partial class frmana : Form
    {
        public frmana()
        {
            InitializeComponent();
        }
        public void Gizle()
        {
            pbresim.Visible = false;
            
            
            tanımlamalarToolStripMenuItem.Enabled = false;
            imsakİşlemleriToolStripMenuItem.Enabled = false;
            imsakiyeiToolStripMenuItem.Enabled = false;
            pROGRAMDANÇIKIŞToolStripMenuItem.Enabled = false;
            işlemlerMenüsüToolStripMenuItem.Enabled = false;
            
        }

        public void Goster()
        {
            pbresim.Visible = true;
            pROGRAMDANÇIKIŞToolStripMenuItem.Enabled = true;
            tanımlamalarToolStripMenuItem.Enabled = true;
            imsakİşlemleriToolStripMenuItem.Enabled = true;
            imsakiyeiToolStripMenuItem.Enabled = true;
           
            işlemlerMenüsüToolStripMenuItem.Enabled = true;
           
        }

        private void kullanıcıTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserList fut = new frmUserList();
            Gizle();
            fut.MdiParent = this;
            fut.Show();
        }

       
       

        private void PROGRAMDANÇIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
                
        }

        
        private void İşlemlerMenüsüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab1 = new AboutBox1();
            Gizle();
            ab1.MdiParent = this;
            ab1.Show();
        }

        private void bolgeTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbolge fbl = new frmbolge();
            Gizle();
            fbl.MdiParent = this;
            fbl.Show();
        }

        private void dönemİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdonem fdn = new frmdonem();
            Gizle();
            fdn.MdiParent = this;
            fdn.Show();
        }

        private void ekTanımlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmozel foz = new frmozel();
            Gizle();
            foz.MdiParent = this;
            foz.Show();
        }

        private void imsakİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVakit fv = new FrmVakit();
            Gizle();
            fv.MdiParent = this;
            fv.Show();
        }

        private void imsakiyeiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImsakiye fi = new FrmImsakiye();
            Gizle();
            fi.MdiParent = this;
            fi.Show();
        }
    }
}
