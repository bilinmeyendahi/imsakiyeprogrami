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
//using Microsoft.PointOfService;

namespace STOKC

{

    public partial class frmsatis : Form
    {
        //baglanti1,baglanti2,baglanti3,baglanti4,baglanti5,baglanti6,baglanti7,baglanti8=Stok Düş SqlConnection
        //baglantim:Müşteri Ekle SqlConnection
        //baglantia=Stok Ara SqlConnection
        //baglantiy=Yazıcı SqlConnection
        //con=İşyeri Seç SqlConnection
        //bag=Satış İşlemi SqlConnection

        //komut1,komut2,komut3,komut4,komut5,komut6,komut7,komut8=Stok Düş SqlCommand
        //cmd=İşyeri Seç SqlCommand
        //kmt,kmt1=Satış İşlemi SqlCommand
        //dam=Müşteri Ekle SqlDataAdapter
        //day=Yazıcı Seçimi SqlDataAdapter
        //dau=Stok Ürün Ara SqlDataAdapter
        //das=Satış İşlemi SqlDataAdapter
        //dt=Müşteri Ekle DataTable
        //dt1=Yazıcı Listele Datatable
        //dr=İşyeri Seç SqlDataReader
        //ds=Stok Listele DataSet
        //dts=Satış İşlemi DataSet

        SqlConnection baglantim, baglanti1, baglanti2, baglanti3, baglanti4, baglanti5, baglanti6, baglanti7, baglanti8, con, baglantiy, bag, bagl, bags;//Veritabanı bağlantısında kullanacağımız tool
        SqlCommand cmd, komut1, komut2, komut3, komut4, komut5, komut6, komut7, komut8, kmt, kmt1, komutm;
        SqlDataAdapter dal, dam, day, das, dasl, dass;

        DataTable dt, dt1;
        SqlDataReader dr;
        DataSet ds, dts, dtsl, dtss;
        public frmsatis()
        {
            InitializeComponent();
        }

        public void listelestok()
        {
            SqlClass bgl = new SqlClass();
            SqlDataAdapter dau = new SqlDataAdapter("Select * from TblStok", bgl.baglanti());
            DataSet ds = new DataSet();

            dau.Fill(ds, "TblStok");
            dataGridView1.DataSource = ds.Tables["TblStok"];

            try
            {
                dataGridView1.Columns[0].HeaderText = "STOK NO";//data gridviewdeki kolonları başlığı

                dataGridView1.Columns[1].HeaderText = "ADI";
                dataGridView1.Columns[2].HeaderText = "ADEDİ";
                dataGridView1.Columns[3].HeaderText = "FİYATI";

                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 280;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].Width = 80;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void listelesatis()
        {

            SqlClass bgl = new SqlClass();
            SqlDataAdapter dasl = new SqlDataAdapter("Select * from TblSatis where sTarih >= '" + sTariha.Text + " 00:00:00.000' AND sTarih <= '" + sTariha.Text + " 23:59:59.999'", bgl.baglanti());
            dtsl = new DataSet();
            dasl.Fill(dtsl, "TblSatis");
            dataGridView2.DataSource = dtsl.Tables["TblSatis"];

            try
            {
                dataGridView2.Columns[0].HeaderText = "S.NO";//data gridviewdeki kolonları başlığı
                dataGridView2.Columns[0].Width = 50;
                dataGridView2.Columns[1].HeaderText = "TARİH";
                dataGridView2.Columns[1].Width = 140;

                dataGridView2.Columns[2].HeaderText = "M.NO";
                dataGridView2.Columns[2].Width = 100;
                dataGridView2.Columns[3].HeaderText = "M.AD";
                dataGridView2.Columns[3].Width = 150;
                dataGridView2.Columns[4].HeaderText = "TOPLAM";
                dataGridView2.Columns[4].Width = 100;
                dataGridView2.Columns[5].HeaderText = "ORAN %";
                dataGridView2.Columns[5].Width = 75;
                dataGridView2.Columns[6].HeaderText = "KDV";
                dataGridView2.Columns[6].Width = 100;
                dataGridView2.Columns[7].HeaderText = "G.TOPLAM";
                dataGridView2.Columns[7].Width = 100;
                dataGridView2.Columns[8].HeaderText = "ÖDEME";
                dataGridView2.Columns[8].Width = 100;
                dataGridView2.Columns[9].HeaderText = "Y";
                dataGridView2.Columns[9].Width = 100;
                //Sütun değerlerini toplama
                if (dataGridView2.RowCount > 0)
                {
                    decimal iTotal = 0;

                    for (int index = 0; index <= dataGridView2.RowCount - 1; index++)
                    {
                        iTotal += Convert.ToDecimal(dataGridView2.Rows[index].Cells[7].Value); // hangi column ise onun indexi yazılacak 

                    }
                    ststoplam.Text = iTotal.ToString();
                }

                int satirsayisi = dataGridView2.RowCount;
                satirsay.Text = satirsayisi.ToString();

            }
            catch
            {
                ;
            }

            if (dataGridView2.RowCount < 0)
            {
                MessageBox.Show("KAYIT BULUNAMADI");
            }


        }

        public void listelefis()
        {

            bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");
            das = new SqlDataAdapter("Select *from TBLFIS", bag);
            dts = new DataSet();


            bag.Open();
            das.Fill(dts, "TBLFIS");
            dataGridView3.DataSource = dts.Tables["TBLFIS"];
            bag.Close();
            try
            {
                dataGridView3.Columns[0].HeaderText = "F.NO";//data gridviewdeki kolonları başlığı
                dataGridView3.Columns[0].Width = 50;
                dataGridView3.Columns[1].HeaderText = "FİŞ NO";
                dataGridView3.Columns[1].Width = 90;
                dataGridView3.Columns[2].HeaderText = "ÜRÜN AD";
                dataGridView3.Columns[2].Width = 50;
                dataGridView3.Columns[3].HeaderText = "ÜRÜN ADET";
                dataGridView3.Columns[3].Width = 100;
                dataGridView3.Columns[4].HeaderText = "B.FİYAT";
                dataGridView3.Columns[4].Width = 150;
                dataGridView3.Columns[5].HeaderText = "T.FİYAT";
                dataGridView3.Columns[5].Width = 100;


            }
            catch
            {
                ;
            }
            bagl = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");
            dasl = new SqlDataAdapter("Select *from TBLSATIS where fno = '" + fnoa.Text + "'", bagl);
            dtsl = new DataSet();
            bagl.Open();
            dasl.Fill(dtsl, "TBLSATIS");
            dataGridView2.DataSource = dtsl.Tables["TBLSATIS"];
            bagl.Close();
            try
            {
                dataGridView2.Columns[0].HeaderText = "S.NO";//data gridviewdeki kolonları başlığı
                dataGridView2.Columns[0].Width = 50;
                dataGridView2.Columns[1].HeaderText = "TARİH";
                dataGridView2.Columns[1].Width = 140;

                dataGridView2.Columns[2].HeaderText = "M.NO";
                dataGridView2.Columns[2].Width = 100;
                dataGridView2.Columns[3].HeaderText = "M.AD";
                dataGridView2.Columns[3].Width = 150;
                dataGridView2.Columns[4].HeaderText = "TOPLAM";
                dataGridView2.Columns[4].Width = 100;
                dataGridView2.Columns[5].HeaderText = "ORAN %";
                dataGridView2.Columns[5].Width = 75;
                dataGridView2.Columns[6].HeaderText = "KDV";
                dataGridView2.Columns[6].Width = 100;
                dataGridView2.Columns[7].HeaderText = "G.TOPLAM";
                dataGridView2.Columns[7].Width = 100;
                dataGridView2.Columns[8].HeaderText = "ÖDEME";
                dataGridView2.Columns[8].Width = 100;
                dataGridView2.Columns[9].HeaderText = "Y";
                dataGridView2.Columns[9].Width = 100;
                //Sütun değerlerini toplama
                if (dataGridView2.RowCount > 0)
                {
                    decimal iTotal = 0;

                    for (int index = 0; index <= dataGridView2.RowCount - 1; index++)
                    {
                        iTotal += Convert.ToDecimal(dataGridView2.Rows[index].Cells[7].Value); // hangi column ise onun indexi yazılacak 

                    }
                    ststoplam.Text = iTotal.ToString();
                }

                int satirsayisi = dataGridView2.RowCount;
                satirsay.Text = satirsayisi.ToString();

            }
            catch
            {
                ;
            }

            if (dataGridView2.RowCount < 1)
            {
                MessageBox.Show("KAYIT BULUNAMADI");
            }

        }

        public void satistemizle()
        {
            /*sno.Clear();
            starih.Text = "";
            makbuzno.Clear();
            musteriad.Text = "";
            urunad1.Clear(); urunad2.Clear(); urunad3.Clear(); urunad4.Clear(); urunad5.Clear(); urunad6.Clear(); urunad7.Clear(); urunad8.Clear();
            urunadet1.Clear(); urunadet2.Clear(); urunadet3.Clear(); urunadet4.Clear(); urunadet5.Clear(); urunadet6.Clear(); urunadet7.Clear(); urunadet8.Clear();
            birimfiyat1.Clear(); birimfiyat2.Clear(); birimfiyat3.Clear(); birimfiyat4.Clear(); birimfiyat5.Clear(); birimfiyat6.Clear(); birimfiyat7.Clear(); birimfiyat8.Clear();
            tfiyat1.Clear(); tfiyat2.Clear(); tfiyat3.Clear(); tfiyat4.Clear(); tfiyat5.Clear(); tfiyat6.Clear(); tfiyat7.Clear(); tfiyat8.Clear();
            un.Clear(); un2.Clear(); un3.Clear(); un4.Clear(); un5.Clear(); un6.Clear(); un7.Clear(); un8.Clear();
            us1.Clear(); us2.Clear(); us3.Clear(); us4.Clear(); us5.Clear(); us6.Clear(); us7.Clear(); us8.Clear();
            uk1.Clear(); uk2.Clear(); uk3.Clear(); uk4.Clear(); uk5.Clear(); uk6.Clear(); uk7.Clear(); uk8.Clear();

            toplam.Clear();

            kdv.Clear();
            gtoplam.Clear();
            odemetur.Text = "";
            yaziyla.Clear();*/


        }

        public void sifirtemizle()
        {
            /* if (urunadet1.Text == "0" || birimfiyat1.Text == "0" || tfiyat1.Text == "0")
             {
                 urunadet1.Text = "";
                 birimfiyat1.Text = "";
                 tfiyat1.Text = "";
             }
             if (urunadet2.Text == "0" || birimfiyat2.Text == "0" || tfiyat2.Text == "0") { urunadet2.Text = ""; birimfiyat2.Text = ""; tfiyat2.Text = ""; }
             if (urunadet3.Text == "0" || birimfiyat3.Text == "0" || tfiyat3.Text == "0") { urunadet3.Text = ""; birimfiyat3.Text = ""; tfiyat3.Text = ""; }
             if (urunadet4.Text == "0" || birimfiyat4.Text == "0" || tfiyat4.Text == "0") { urunadet4.Text = ""; birimfiyat4.Text = ""; tfiyat4.Text = ""; }
             if (urunadet5.Text == "0" || birimfiyat5.Text == "0" || tfiyat5.Text == "0") { urunadet5.Text = ""; birimfiyat5.Text = ""; tfiyat5.Text = ""; }
             if (urunadet6.Text == "0" || birimfiyat6.Text == "0" || tfiyat6.Text == "0") { urunadet6.Text = ""; birimfiyat6.Text = ""; tfiyat6.Text = ""; }
             if (urunadet7.Text == "0" || birimfiyat7.Text == "0" || tfiyat7.Text == "0") { urunadet7.Text = ""; birimfiyat7.Text = ""; tfiyat7.Text = ""; }
             if (urunadet8.Text == "0" || birimfiyat8.Text == "0" || tfiyat8.Text == "0") { urunadet8.Text = ""; birimfiyat8.Text = ""; tfiyat8.Text = ""; }
             */
        }

        public void isyerisec()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            ino.Text = "1";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from TBLISYERI where ino='" + ino.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
                if (dr.Read())
                {
                    isad.Text = dr["isad"].ToString();
                    vergiDairesi.Text = dr["vergidairesi"].ToString();
                    vergiNo.Text = dr["vergino"].ToString();

                }
                else
                { }
            {


                con.Close();


            }

        }
        public void yazdir()
        {

            try
            {
                short baskiAdeti = Convert.ToInt16(fissayi.Text);
                printDocument1.PrinterSettings.Copies = baskiAdeti;
                // Select the printer.
                printDocument1.PrinterSettings.PrinterName = fisprint.Text;

                // Print.
                printDocument1.Print();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


            /* PosPrinter posPrinter;
            /* PosPrinter posPrinter;
             var explorer = new PosExplorer();
             var deviceInfo = explorer.GetDevice(DeviceType.PosPrinter);
             if (deviceInfo == null)
             {
                 MessageBox.Show("Yazıcı bulunamadı!");
                 return;
             }

             posPrinter = (PosPrinter)explorer.CreateInstance(deviceInfo);
             posPrinter.Open();
             posPrinter.Claim(500);
             posPrinter.DeviceEnabled = true;

             posPrinter.StatusUpdateEvent += (s, evt) =>
             {
                 if (evt.Status == PosPrinter.StatusCoverOpen)
                 {
                     MessageBox.Show("Yazıcının kağıt kapağı açıldı");
                 }
                 if (evt.Status == PosPrinter.StatusCoverOK)
                 {
                     MessageBox.Show("Yazıcının kağıt kapağı kapandı");
                 }
                 if (evt.Status == PosPrinter.StatusJournalCartridgeEmpty)
                 {
                     MessageBox.Show("Yazıcının kartuşu bitmek üzere");
                 }
                 //istediğin eventleri yakalayabilirsin bir sürü var
             };



             posPrinter.PrintNormal(PrinterStation.Slip, isad.Text);
             posPrinter.PrintNormal(PrinterStation.Slip, "Vergi Dairesi:"+ vergidairesi.Text +"           "+"Vergi No:" + vergino.Text + Environment.NewLine );
             posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
             posPrinter.PrintNormal(PrinterStation.Slip, "Sn\t:" +musteriad.Text + Environment.NewLine);
             posPrinter.PrintNormal(PrinterStation.Slip, "FİŞ NO\t:"+sno.Text + Environment.NewLine);
             posPrinter.PrintNormal(PrinterStation.Slip, "TAR-SAAT\t\t:"+starih.Text +"  -   "+ssaat.Text+ Environment.NewLine);
             posPrinter.PrintNormal(PrinterStation.Slip, "********************************************************************" + Environment.NewLine);
             //ne yazdırmak istiyorsan buraya
             //posPrinter.PrintNormal(PrinterStation.Slip, string.Format({0,30})"Ürün Adı\t"+Environment.NewLine);
             posPrinter.PrintNormal(PrinterStation.Slip, urunad1.Text+"                                 "+urunadet1.Text+"      "+birimfiyat1.Text+"      "+tfiyat1.Text+ Environment.NewLine);
             posPrinter.PrintNormal(PrinterStation.Slip, "BAKİYE\t\t: 16,20 [B]" + Environment.NewLine);
             posPrinter.CutPaper(100); //kağıdı tam kes, 100 yerine 50 yazarsan yarısına kadar keser
             */
        }

        public void listetemizle()
        {
            //if (dataGridView2.RowCount > 0)
            //{
            //    dataGridView2.Columns.Clear();
            //    dtsl.Clear();

            //}
            //if (dataGridView3.RowCount > 0)
            //{
            //    dataGridView3.Columns.Clear();
            //    dts.Clear();
            //}
            //satirsay.Clear();
            //ststoplam.Clear();

        }

        public void adetbutonkapat()
        {
            urunadet1.ReadOnly = true;
            urunadet2.ReadOnly = true;
            urunadet3.ReadOnly = true;
            urunadet4.ReadOnly = true;
            urunadet5.ReadOnly = true;
            urunadet6.ReadOnly = true;
            urunadet7.ReadOnly = true;
            urunadet8.ReadOnly = true;

            button18.Enabled = false;
        }
        public void adetbutonac()
        {
            urunadet1.ReadOnly = false;
            urunadet2.ReadOnly = false;
            urunadet3.ReadOnly = false;
            urunadet4.ReadOnly = false;
            urunadet5.ReadOnly = false;
            urunadet6.ReadOnly = false;
            urunadet7.ReadOnly = false;
            urunadet8.ReadOnly = false;

            button18.Enabled = true;
        }


        private void Urun2cikar_Click(object sender, EventArgs e)
        {
            urunad2.Clear();
            urunadet2.Clear();
            birimfiyat2.Clear();
            tfiyat2.Clear();
            un2.Clear();
            us2.Clear();
            uk2.Clear();
        }

        private void Urun3cikar_Click(object sender, EventArgs e)
        {
            urunad3.Clear();
            urunadet3.Clear();
            birimfiyat3.Clear();
            tfiyat3.Clear();
            un3.Clear();
            us3.Clear();
            uk3.Clear();
        }

        private void Urun4cikar_Click(object sender, EventArgs e)
        {
            urunad4.Clear();
            urunadet4.Clear();
            birimfiyat4.Clear();
            tfiyat4.Clear();
            un4.Clear();
            us4.Clear();
            uk4.Clear();
        }

        private void Urun2ekle_Click(object sender, EventArgs e)
        {
            if (urunadet2.Text == "")
            {
                urunad2.Clear(); birimfiyat2.Clear(); tfiyat2.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad3.Text || surunad.Text == urunad4.Text || surunad.Text == urunad5.Text || surunad.Text == urunad6.Text || surunad.Text == urunad7.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad2.Text = surunad.Text;
                    birimfiyat2.Text = surunfiyat.Text;
                    un2.Text = sun.Text;
                    us2.Text = surunadet.Text;
                    uk2.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }

        private void Urun6ekle_Click(object sender, EventArgs e)
        {
            if (urunadet6.Text == "")
            {
                urunad6.Clear(); birimfiyat6.Clear(); tfiyat6.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad2.Text || surunad.Text == urunad3.Text || surunad.Text == urunad4.Text || surunad.Text == urunad5.Text || surunad.Text == urunad7.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad6.Text = surunad.Text;
                    birimfiyat6.Text = surunfiyat.Text;
                    un6.Text = sun.Text;
                    us6.Text = surunadet.Text;
                    uk6.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }

        private void Urun7ekle_Click(object sender, EventArgs e)
        {
            if (urunadet7.Text == "")
            {
                urunad7.Clear(); birimfiyat7.Clear(); tfiyat7.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad2.Text || surunad.Text == urunad3.Text || surunad.Text == urunad4.Text || surunad.Text == urunad5.Text || surunad.Text == urunad6.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad7.Text = surunad.Text;
                    birimfiyat7.Text = surunfiyat.Text;
                    un7.Text = sun.Text;
                    us7.Text = surunadet.Text;
                    uk7.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }

        private void Urun8ekle_Click(object sender, EventArgs e)
        {
            if (urunadet8.Text == "")
            {
                urunad8.Clear(); birimfiyat8.Clear(); tfiyat8.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad2.Text || surunad.Text == urunad3.Text || surunad.Text == urunad4.Text || surunad.Text == urunad5.Text || surunad.Text == urunad6.Text || surunad.Text == urunad7.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad8.Text = surunad.Text;
                    birimfiyat8.Text = surunfiyat.Text;
                    un8.Text = sun.Text;
                    us8.Text = surunadet.Text;
                    uk8.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listetemizle();
            button6.Enabled = true;
            button7.Enabled = true;
        }



        private void Urun3ekle_Click(object sender, EventArgs e)
        {
            if (urunadet3.Text == "")
            {
                urunad3.Clear(); birimfiyat3.Clear(); tfiyat3.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad2.Text || surunad.Text == urunad4.Text || surunad.Text == urunad5.Text || surunad.Text == urunad6.Text || surunad.Text == urunad7.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad3.Text = surunad.Text;
                    birimfiyat3.Text = surunfiyat.Text;
                    un3.Text = sun.Text;
                    us3.Text = surunadet.Text;
                    uk3.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (fnoa.Text != ""/* && dataGridView3.RowCount > 0 && dataGridView3.RowCount < 9*/)
            {
                adetbutonkapat();
                isyerisec();
                musteriAd.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();//3 müşteri ad
                font4.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();//0 fiş no
                sno.Text = font4.Text;
                starih.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();//1 tarih saat
                starih.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();//2 makbuzno
                toplam.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                kdvoran.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
                kdv.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                gtoplam.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                odemetur.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                yaziyla.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
                int sayd;
                sayd = 0;


                if (dataGridView3.RowCount == sayd + 1)
                {
                    urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                }
                else
                {
                    if (dataGridView3.RowCount == sayd + 2)
                    {
                        urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                        urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                    }

                    else
                    {
                        if (dataGridView3.RowCount == sayd + 3)

                        {
                            urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                            urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                            urunad3.Text = dataGridView3.Rows[2].Cells[2].Value.ToString(); urunadet3.Text = dataGridView3.Rows[2].Cells[3].Value.ToString(); birimfiyat3.Text = dataGridView3.Rows[2].Cells[4].Value.ToString(); tfiyat3.Text = dataGridView3.Rows[2].Cells[5].Value.ToString();
                        }

                        else
                        {

                            if (dataGridView3.RowCount == sayd + 4)

                            {
                                urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                                urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                                urunad3.Text = dataGridView3.Rows[2].Cells[2].Value.ToString(); urunadet3.Text = dataGridView3.Rows[2].Cells[3].Value.ToString(); birimfiyat3.Text = dataGridView3.Rows[2].Cells[4].Value.ToString(); tfiyat3.Text = dataGridView3.Rows[2].Cells[5].Value.ToString();
                                urunad4.Text = dataGridView3.Rows[3].Cells[2].Value.ToString(); urunadet4.Text = dataGridView3.Rows[3].Cells[3].Value.ToString(); birimfiyat4.Text = dataGridView3.Rows[3].Cells[4].Value.ToString(); tfiyat4.Text = dataGridView3.Rows[3].Cells[5].Value.ToString();
                            }
                            else
                            {
                                if (dataGridView3.RowCount == sayd + 5)

                                {
                                    urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                                    urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                                    urunad3.Text = dataGridView3.Rows[2].Cells[2].Value.ToString(); urunadet3.Text = dataGridView3.Rows[2].Cells[3].Value.ToString(); birimfiyat3.Text = dataGridView3.Rows[2].Cells[4].Value.ToString(); tfiyat3.Text = dataGridView3.Rows[2].Cells[5].Value.ToString();
                                    urunad4.Text = dataGridView3.Rows[3].Cells[2].Value.ToString(); urunadet4.Text = dataGridView3.Rows[3].Cells[3].Value.ToString(); birimfiyat4.Text = dataGridView3.Rows[3].Cells[4].Value.ToString(); tfiyat4.Text = dataGridView3.Rows[3].Cells[5].Value.ToString();
                                    urunad5.Text = dataGridView3.Rows[4].Cells[2].Value.ToString(); urunadet5.Text = dataGridView3.Rows[4].Cells[3].Value.ToString(); birimfiyat5.Text = dataGridView3.Rows[4].Cells[4].Value.ToString(); tfiyat5.Text = dataGridView3.Rows[4].Cells[5].Value.ToString();
                                }
                                else
                                {
                                    if (dataGridView3.RowCount == sayd + 6)

                                    {
                                        urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                                        urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                                        urunad3.Text = dataGridView3.Rows[2].Cells[2].Value.ToString(); urunadet3.Text = dataGridView3.Rows[2].Cells[3].Value.ToString(); birimfiyat3.Text = dataGridView3.Rows[2].Cells[4].Value.ToString(); tfiyat3.Text = dataGridView3.Rows[2].Cells[5].Value.ToString();
                                        urunad4.Text = dataGridView3.Rows[3].Cells[2].Value.ToString(); urunadet4.Text = dataGridView3.Rows[3].Cells[3].Value.ToString(); birimfiyat4.Text = dataGridView3.Rows[3].Cells[4].Value.ToString(); tfiyat4.Text = dataGridView3.Rows[3].Cells[5].Value.ToString();
                                        urunad5.Text = dataGridView3.Rows[4].Cells[2].Value.ToString(); urunadet5.Text = dataGridView3.Rows[4].Cells[3].Value.ToString(); birimfiyat5.Text = dataGridView3.Rows[4].Cells[4].Value.ToString(); tfiyat5.Text = dataGridView3.Rows[4].Cells[5].Value.ToString();
                                        urunad6.Text = dataGridView3.Rows[5].Cells[2].Value.ToString(); urunadet6.Text = dataGridView3.Rows[5].Cells[3].Value.ToString(); birimfiyat6.Text = dataGridView3.Rows[5].Cells[4].Value.ToString(); tfiyat6.Text = dataGridView3.Rows[5].Cells[5].Value.ToString();
                                    }
                                    else
                                    {
                                        if (dataGridView3.RowCount == sayd + 7)

                                        {
                                            urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                                            urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                                            urunad3.Text = dataGridView3.Rows[2].Cells[2].Value.ToString(); urunadet3.Text = dataGridView3.Rows[2].Cells[3].Value.ToString(); birimfiyat3.Text = dataGridView3.Rows[2].Cells[4].Value.ToString(); tfiyat3.Text = dataGridView3.Rows[2].Cells[5].Value.ToString();
                                            urunad4.Text = dataGridView3.Rows[3].Cells[2].Value.ToString(); urunadet4.Text = dataGridView3.Rows[3].Cells[3].Value.ToString(); birimfiyat4.Text = dataGridView3.Rows[3].Cells[4].Value.ToString(); tfiyat4.Text = dataGridView3.Rows[3].Cells[5].Value.ToString();
                                            urunad5.Text = dataGridView3.Rows[4].Cells[2].Value.ToString(); urunadet5.Text = dataGridView3.Rows[4].Cells[3].Value.ToString(); birimfiyat5.Text = dataGridView3.Rows[4].Cells[4].Value.ToString(); tfiyat5.Text = dataGridView3.Rows[4].Cells[5].Value.ToString();
                                            urunad6.Text = dataGridView3.Rows[5].Cells[2].Value.ToString(); urunadet6.Text = dataGridView3.Rows[5].Cells[3].Value.ToString(); birimfiyat6.Text = dataGridView3.Rows[5].Cells[4].Value.ToString(); tfiyat6.Text = dataGridView3.Rows[5].Cells[5].Value.ToString();
                                            urunad7.Text = dataGridView3.Rows[6].Cells[2].Value.ToString(); urunadet7.Text = dataGridView3.Rows[6].Cells[3].Value.ToString(); birimfiyat7.Text = dataGridView3.Rows[6].Cells[4].Value.ToString(); tfiyat7.Text = dataGridView3.Rows[6].Cells[5].Value.ToString();

                                        }
                                        else
                                        {
                                            if (dataGridView3.RowCount == sayd + 8)

                                            {
                                                urunad1.Text = dataGridView3.Rows[0].Cells[2].Value.ToString(); urunadet1.Text = dataGridView3.Rows[0].Cells[3].Value.ToString(); birimfiyat1.Text = dataGridView3.Rows[0].Cells[4].Value.ToString(); tfiyat1.Text = dataGridView3.Rows[0].Cells[5].Value.ToString();
                                                urunad2.Text = dataGridView3.Rows[1].Cells[2].Value.ToString(); urunadet2.Text = dataGridView3.Rows[1].Cells[3].Value.ToString(); birimfiyat2.Text = dataGridView3.Rows[1].Cells[4].Value.ToString(); tfiyat2.Text = dataGridView3.Rows[1].Cells[5].Value.ToString();
                                                urunad3.Text = dataGridView3.Rows[2].Cells[2].Value.ToString(); urunadet3.Text = dataGridView3.Rows[2].Cells[3].Value.ToString(); birimfiyat3.Text = dataGridView3.Rows[2].Cells[4].Value.ToString(); tfiyat3.Text = dataGridView3.Rows[2].Cells[5].Value.ToString();
                                                urunad4.Text = dataGridView3.Rows[3].Cells[2].Value.ToString(); urunadet4.Text = dataGridView3.Rows[3].Cells[3].Value.ToString(); birimfiyat4.Text = dataGridView3.Rows[3].Cells[4].Value.ToString(); tfiyat4.Text = dataGridView3.Rows[3].Cells[5].Value.ToString();
                                                urunad5.Text = dataGridView3.Rows[4].Cells[2].Value.ToString(); urunadet5.Text = dataGridView3.Rows[4].Cells[3].Value.ToString(); birimfiyat5.Text = dataGridView3.Rows[4].Cells[4].Value.ToString(); tfiyat5.Text = dataGridView3.Rows[4].Cells[5].Value.ToString();
                                                urunad6.Text = dataGridView3.Rows[5].Cells[2].Value.ToString(); urunadet6.Text = dataGridView3.Rows[5].Cells[3].Value.ToString(); birimfiyat6.Text = dataGridView3.Rows[5].Cells[4].Value.ToString(); tfiyat6.Text = dataGridView3.Rows[5].Cells[5].Value.ToString();
                                                urunad7.Text = dataGridView3.Rows[6].Cells[2].Value.ToString(); urunadet7.Text = dataGridView3.Rows[6].Cells[3].Value.ToString(); birimfiyat7.Text = dataGridView3.Rows[6].Cells[4].Value.ToString(); tfiyat7.Text = dataGridView3.Rows[6].Cells[5].Value.ToString();
                                                urunad8.Text = dataGridView3.Rows[7].Cells[2].Value.ToString(); urunadet8.Text = dataGridView3.Rows[7].Cells[3].Value.ToString(); birimfiyat8.Text = dataGridView3.Rows[7].Cells[4].Value.ToString(); tfiyat8.Text = dataGridView3.Rows[7].Cells[5].Value.ToString();
                                            }
                                        }

                                    }

                                }

                            }
                        }
                    }
                }
                yazdir();
            }

            else
            {
                ;
            }

        }



        private void urunadet1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void urunadet8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            listelesatis();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fnoa.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }

        private void kdv_TextChanged(object sender, EventArgs e)
        {

        }

        private void toplam_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme2 fust = new FrmMusteriListeleme2();


            fust.TopMost = true;
            fust.Show();



        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listelesatis();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fisara();
        }

        private void Urun4ekle_Click(object sender, EventArgs e)
        {
            if (urunadet4.Text == "")
            {
                urunad4.Clear(); birimfiyat4.Clear(); tfiyat4.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad2.Text || surunad.Text == urunad3.Text || surunad.Text == urunad5.Text || surunad.Text == urunad6.Text || surunad.Text == urunad7.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad4.Text = surunad.Text;
                    birimfiyat4.Text = surunfiyat.Text;
                    un4.Text = sun.Text;
                    us4.Text = surunadet.Text;
                    uk4.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            DialogResult cevap = new DialogResult();
            hesapla();


            if (toplam.Text == "" || kdv.Text == "" || gtoplam.Text == "")
            {
                MessageBox.Show("Ürün Seçim İşlemini Tamamlamadınız", "EKSİK İŞLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                cevap = MessageBox.Show("Satış Tutarı:" + " " + gtoplam.Text + " " + "SATIŞ İŞLEMİNE DEVAM ETMEK İSTİYOR MUSUNUZ?", "SATIŞ ONAYI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.Yes)
                {

                    if (urunad1.Text != "")
                    {
                        satisstokdus1();
                    }

                    if (urunad2.Text != "")
                    {
                        satisstokdus2();
                    }
                    if (urunad3.Text != "")
                    {
                        satisstokdus3();
                    }
                    if (urunad4.Text != "")
                    {
                        satisstokdus4();
                    }
                    if (urunad5.Text != "")
                    {
                        satisstokdus5();
                    }

                    if (urunad6.Text != "")
                    {
                        satisstokdus6();
                    }
                    if (urunad7.Text != "")
                    {
                        satisstokdus7();
                    }
                    if (urunad8.Text != "")
                    {
                        satisstokdus8();
                    }

                    sifirtemizle();

                    bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");
                    das = new SqlDataAdapter("Select *from TBLFIS where fno like '" + font4.Text + "'", bag);
                    dts = new DataSet();
                    bag.Open();
                    string kayit = "INSERT INTO TBLSATIS (starih,makbuzno,musteriad,toplam,kdvoran,kdv,gtoplam,odemetur,yaziyla) VALUES (@starih,@makbuzno,@musteriad,@toplam,@kdvoran,@kdv,@gtoplam,@odemetur,@yaziyla);SELECT SCOPE_IDENTITY()";
                    SqlCommand kmt = new SqlCommand(kayit, bag);
                    kmt.Parameters.AddWithValue("@starih", starih.Text);

                    kmt.Parameters.AddWithValue("@makbuzno", makbuzno.Text);
                    kmt.Parameters.AddWithValue("@musteriad", musteriAd.Text);
                    kmt.Parameters.AddWithValue("@toplam", toplam.Text);
                    kmt.Parameters.AddWithValue("@kdvoran", kdvoran.Text);
                    kmt.Parameters.AddWithValue("@kdv", kdv.Text);
                    kmt.Parameters.AddWithValue("@gtoplam", gtoplam.Text);
                    kmt.Parameters.AddWithValue("@odemetur", odemetur.Text);
                    kmt.Parameters.AddWithValue("@yaziyla", yaziyla.Text);
                    //kmt.ExecuteNonQuery();
                    //kmt.CommandText = "SELECT last_insert_rowid()"; // "select max(sno) from TBLSATIS";
                    string sonkayitid = kmt.ExecuteScalar().ToString();
                    font4.Text = sonkayitid;

                    bool varmis = false;
                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO TBLFIS(fno,urunad,urunadet,birimfiyat,tfiyat)  VALUES");
                    if (urunad1.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad1.Text + "'," + urunadet1.Text + "," + birimfiyat1.Text + "," + tfiyat1.Text + ")");
                    }
                    if (urunad2.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad2.Text + "'," + urunadet2.Text + "," + birimfiyat2.Text + "," + tfiyat2.Text + ")");
                    }

                    if (urunad3.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad3.Text + "'," + urunadet3.Text + "," + birimfiyat3.Text + "," + tfiyat3.Text + ")");
                    }
                    if (urunad4.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad4.Text + "'," + urunadet4.Text + "," + birimfiyat4.Text + "," + tfiyat4.Text + ")");
                    }
                    if (urunad5.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad5.Text + "'," + urunadet5.Text + "," + birimfiyat5.Text + "," + tfiyat5.Text + ")");
                    }
                    if (urunad6.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad6.Text + "'," + urunadet6.Text + "," + birimfiyat6.Text + "," + tfiyat6.Text + ")");
                    }

                    if (urunad7.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad7.Text + "'," + urunadet7.Text + "," + birimfiyat7.Text + "," + tfiyat7.Text + ")");
                    }
                    if (urunad8.Text.Trim() != "")
                    {
                        if (varmis)
                            sb.Append(",");
                        else
                            varmis = true;
                        sb.Append("(" + font4.Text + ",'" + urunad8.Text + "'," + urunadet8.Text + "," + birimfiyat8.Text + "," + tfiyat8.Text + ")");
                    }
                    sb.Append(";");
                    SqlCommand kmtf = new SqlCommand(sb.ToString(), bag);
                    kmtf.ExecuteNonQuery();
                    bag.Close();

                    //MessageBox.Show("Satış İşlemi Tamamlandı ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);//kayot eklendiğine dair kullanıcı bilgilendirme

                    noktavirgul();
                    yazdir();
                    //musterikaydet();
                    satistemizle();
                }
                if (cevap == DialogResult.No)
                {
                    satistemizle();
                }
            }


        }

        private void Urun5ekle_Click(object sender, EventArgs e)
        {
            if (urunadet5.Text == "")
            {
                urunad5.Clear(); birimfiyat5.Clear(); tfiyat5.Clear();
            }
            else
            {
                if (surunad.Text == urunad1.Text || surunad.Text == urunad2.Text || surunad.Text == urunad3.Text || surunad.Text == urunad4.Text || surunad.Text == urunad6.Text || surunad.Text == urunad7.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    urunad5.Text = surunad.Text;
                    birimfiyat5.Text = surunfiyat.Text;
                    un5.Text = sun.Text;
                    us5.Text = surunadet.Text;
                    uk5.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }

        private void Urun5cikar_Click(object sender, EventArgs e)
        {
            urunad5.Clear();
            urunadet5.Clear();
            birimfiyat5.Clear();
            tfiyat5.Clear();
            un5.Clear();
            us5.Clear();
            uk5.Clear();
        }

        private void Urun6cikar_Click(object sender, EventArgs e)
        {
            urunad6.Clear();
            urunadet6.Clear();
            birimfiyat6.Clear();
            tfiyat6.Clear();
            un6.Clear();
            us6.Clear();
            uk6.Clear();
        }

        private void Urun7cikar_Click(object sender, EventArgs e)
        {
            urunad7.Clear();
            urunadet7.Clear();
            birimfiyat7.Clear();
            tfiyat7.Clear();
            un7.Clear();
            us7.Clear();
            uk7.Clear();
        }

        private void Urun8cikar_Click(object sender, EventArgs e)
        {
            urunad8.Clear();
            urunadet8.Clear();
            birimfiyat8.Clear();
            tfiyat8.Clear();
            un8.Clear();
            us8.Clear();
            uk8.Clear();
        }

        public void hesapla()
        {
            if (odemetur.Text == "")
            {
                odemetur.Text = "Nakit";

            }
            if (kdvoran.Text == "")
            {
                kdvoran.Text = "18";
            }
            else
            {

                if (urunad1.Text == "" && urunad2.Text == "" && urunad3.Text == "" && urunad4.Text == "" && urunad5.Text == "" && urunad6.Text == "" && urunad7.Text == "" && urunad8.Text == "")
                {
                    MessageBox.Show("ÜRÜN SEÇİMİ YAPMADINIZ", "ÜRÜN SEÇİMİ GEREKLİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (urunad1.Text.Trim() == "" || urunadet1.Text.Trim() == "")
                    {

                        urunadet1.Text = "0";
                        birimfiyat1.Text = "0";
                        tfiyat1.Text = "0";
                    }

                    if (urunad2.Text == "" || urunadet2.Text == "")
                    {
                        urunadet2.Text = "0";
                        birimfiyat2.Text = "0";
                        tfiyat2.Text = "0";
                    }

                    if (urunad3.Text == "" || urunadet3.Text == "")
                    {
                        urunadet3.Text = "0";
                        birimfiyat3.Text = "0";
                        tfiyat3.Text = "0";
                    }
                    if (urunad4.Text == "" || urunadet4.Text == "")
                    {
                        urunadet4.Text = "0";
                        birimfiyat4.Text = "0";
                        tfiyat4.Text = "0";
                    }
                    if (urunad5.Text == "" || urunadet5.Text == "")
                    {
                        urunadet5.Text = "0";
                        birimfiyat5.Text = "0";
                        tfiyat5.Text = "0";
                    }
                    if (urunad6.Text == "" || urunadet6.Text == "")
                    {
                        urunadet6.Text = "0";
                        birimfiyat6.Text = "0";
                        tfiyat6.Text = "0";
                    }
                    if (urunad7.Text == "" || urunadet7.Text == "")
                    {
                        urunadet7.Text = "0";
                        birimfiyat7.Text = "0";
                        tfiyat7.Text = "0";
                    }
                    if (urunad8.Text == "" || urunadet8.Text == "")
                    {
                        urunadet8.Text = "0";
                        birimfiyat8.Text = "0";
                        tfiyat8.Text = "0";
                    }
                    if (odemetur.Text == "")
                    {
                        MessageBox.Show("Lütfen ödeme türü giriniz");

                    }


                    decimal tf1 = Convert.ToDecimal(urunadet1.Text);

                    decimal tf2 = Convert.ToDecimal(birimfiyat1.Text);
                    decimal tutar1 = tf1 * tf2;
                    tfiyat1.Text = tutar1.ToString();


                    decimal tf3 = Convert.ToDecimal(urunadet2.Text);
                    decimal tf4 = Convert.ToDecimal(birimfiyat2.Text);
                    decimal tutar2 = tf3 * tf4;
                    tfiyat2.Text = tutar2.ToString();


                    decimal tf5 = Convert.ToDecimal(urunadet3.Text);
                    decimal tf6 = Convert.ToDecimal(birimfiyat3.Text);
                    decimal tutar3 = tf5 * tf6;
                    tfiyat3.Text = tutar3.ToString();


                    decimal tf7 = Convert.ToDecimal(urunadet4.Text);
                    decimal tf8 = Convert.ToDecimal(birimfiyat4.Text);
                    decimal tutar4 = tf7 * tf8;
                    tfiyat4.Text = tutar4.ToString();



                    decimal tf9 = Convert.ToDecimal(urunadet5.Text);
                    decimal tf10 = Convert.ToDecimal(birimfiyat5.Text);
                    decimal tutar5 = tf9 * tf10;
                    tfiyat5.Text = tutar5.ToString();



                    decimal tf11 = Convert.ToDecimal(urunadet6.Text);
                    decimal tf12 = Convert.ToDecimal(birimfiyat6.Text);

                    decimal tutar6 = tf11 * tf12;
                    tfiyat6.Text = tutar6.ToString();


                    decimal tf13 = Convert.ToDecimal(urunadet7.Text);
                    decimal tf14 = Convert.ToDecimal(birimfiyat7.Text);
                    tfiyat7.Text = Convert.ToString(tf13 * tf14);
                    decimal tutar7 = tf13 * tf14;
                    tfiyat7.Text = tutar7.ToString();


                    decimal tf15 = Convert.ToDecimal(urunadet8.Text);
                    decimal tf16 = Convert.ToDecimal(birimfiyat8.Text);
                    decimal tutar8 = tf15 * tf16;
                    tfiyat8.Text = tutar8.ToString();

                    decimal tpf1 = Convert.ToDecimal(tfiyat1.Text);
                    decimal tpf2 = Convert.ToDecimal(tfiyat2.Text);
                    decimal tpf3 = Convert.ToDecimal(tfiyat3.Text);
                    decimal tpf4 = Convert.ToDecimal(tfiyat4.Text);
                    decimal tpf5 = Convert.ToDecimal(tfiyat5.Text);
                    decimal tpf6 = Convert.ToDecimal(tfiyat6.Text);
                    decimal tpf7 = Convert.ToDecimal(tfiyat7.Text);
                    decimal tpf8 = Convert.ToDecimal(tfiyat8.Text);

                    decimal gt = tpf1 + tpf2 + tpf3 + tpf4 + tpf5 + tpf6 + tpf7 + tpf8;
                    gtoplam.Text = gt.ToString();

                    /*decimal tpl = Convert.ToDecimal(toplam.Text);*/




                    decimal kdvo = Convert.ToDecimal(kdvoran.Text);

                    decimal kdm = gt / (1 + kdvo / 100);
                    toplam.Text = kdm.ToString("#.##");
                    decimal sayi = gt - kdm;
                    kdv.Text = sayi.ToString("#.##");
                    yaziyaCevir(gt);
                    virgulnokta();
                }
            }
        }

        public void satisstokdus1()
        {
            baglanti1 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi1 = Convert.ToDecimal(us1.Text);
            decimal sayi2 = Convert.ToDecimal(urunadet1.Text);
            decimal ss1 = sayi1 - sayi2;
            uk1.Text = ss1.ToString();

            komut1 = new SqlCommand();
            baglanti1.Open();
            komut1.Connection = baglanti1;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut1.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk1.Text + "'WHERE sno=" + un.Text + "";//update komutu


            komut1.ExecuteNonQuery();
            baglanti1.Close();
            listelestok();
        }
        public void satisstokdus2()
        {
            baglanti2 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi3 = Convert.ToDecimal(us2.Text);
            decimal sayi4 = Convert.ToDecimal(urunadet2.Text);

            decimal ss2 = sayi3 - sayi4;
            uk2.Text = ss2.ToString();

            komut2 = new SqlCommand();
            baglanti2.Open();
            komut2.Connection = baglanti2;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut2.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk2.Text + "'WHERE sno=" + un2.Text + "";//update komutu


            komut2.ExecuteNonQuery();
            baglanti2.Close();
            listelestok();
        }

        public void satisstokdus3()
        {
            baglanti3 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi5 = Convert.ToDecimal(us3.Text);
            decimal sayi6 = Convert.ToDecimal(urunadet3.Text);
            decimal ss3 = sayi5 - sayi6;
            uk3.Text = ss3.ToString();

            komut3 = new SqlCommand();
            baglanti3.Open();
            komut3.Connection = baglanti3;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut3.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk3.Text + "'WHERE sno=" + un3.Text + "";//update komutu


            komut3.ExecuteNonQuery();
            baglanti3.Close();
            listelestok();
        }
        public void satisstokdus4()
        {
            baglanti4 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi7 = Convert.ToDecimal(us4.Text);
            decimal sayi8 = Convert.ToDecimal(urunadet4.Text);
            decimal ss4 = sayi7 - sayi8;
            uk4.Text = ss4.ToString();

            komut4 = new SqlCommand();
            baglanti4.Open();
            komut4.Connection = baglanti4;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut4.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk4.Text + "'WHERE sno=" + un4.Text + "";//update komutu


            komut4.ExecuteNonQuery();
            baglanti4.Close();
            listelestok();
        }
        public void fisara()
        {
            //bagf = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");  
            listelefis();
            das = new SqlDataAdapter("Select *from TBLFIS where fno like '" + fnoa.Text + "' ", bag);
            dts = new DataSet();
            bag.Open();
            das.Fill(dts, "TBLFIS");
            bag.Close();
            dataGridView3.DataSource = dts.Tables["TBLFIS"];
            if (dataGridView3.RowCount <= 0)
            {
                MessageBox.Show("FİŞ BULUNAMADI");
            }
        }

        private void Urun1cikar_Click(object sender, EventArgs e)
        {
            urunad1.Clear();
            urunadet1.Clear();
            birimfiyat1.Clear();
            tfiyat1.Clear();
            un.Clear();
            us1.Clear();
            uk1.Clear();
        }

        private void Urun1ekle_Click(object sender, EventArgs e)
        {
            if (urunadet1.Text == "")
            {
                urunad1.Clear(); birimfiyat1.Clear(); tfiyat1.Clear();

            }
            else
            {
                if (surunad.Text == urunad2.Text || surunad.Text == urunad3.Text || surunad.Text == urunad4.Text || surunad.Text == urunad5.Text || surunad.Text == urunad6.Text || surunad.Text == urunad7.Text || surunad.Text == urunad8.Text)
                {
                    MessageBox.Show("Bu ürün zaten seçim listenizde var", "MÜKERRER SEÇİM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    urunad1.Text = surunad.Text;
                    birimfiyat1.Text = surunfiyat.Text;
                    un.Text = sun.Text;
                    us1.Text = surunadet.Text;
                    uk1.Text = surunadet.Text;
                    urunekletemizle();
                }
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sun.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            surunad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surunadet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            surunfiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void TextBox45_TextChanged(object sender, EventArgs e)
        {
            SqlClass bgl = new SqlClass();
            SqlDataAdapter sdau = new SqlDataAdapter("Select *from TblStok where urunAd like '%" + textBox45.Text + "%' ", bgl.baglanti());
            ds = new DataSet();
            sdau.Fill(ds, "TblStok");
            dataGridView1.DataSource = ds.Tables["TblStok"];
        }

        private void Frmsatis_Load(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            starih.Text = zaman.ToString();
            starih.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            listelestok();
            isyerisec();
            yazicilistele();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmana fan = (frmana)Application.OpenForms["frmana"];
            fan.Show();
            fan.Goster();
            this.Close();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);




            {


                // Create a StringFormat object with the each line of text, and the block
                // of text centered on the page.*/
                StringFormat stringFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Center
                };

                // Draw the text and the surrounding rectangle.

                var format = new StringFormat() { Alignment = StringAlignment.Far };



                e.Graphics.DrawString(isad.Text, font1.Font, Brushes.Black, 50, 10);// ilk rakam soldan mesafe, ikinci rakam üstten mesafe
                e.Graphics.DrawString("V. Dairesi:" + vergiDairesi.Text, font2.Font, Brushes.Black, 10, 30);
                e.Graphics.DrawString("V. No:" + vergiNo.Text, font2.Font, Brushes.Black, 160, 30);
                e.Graphics.DrawString("************************************", font2.Font, Brushes.Black, 10, 50);
                e.Graphics.DrawString("Sn:" + musteriAd.Text, font2.Font, Brushes.Black, 10, 70);
                e.Graphics.DrawString("Fiş No:" + font4.Text, font2.Font, Brushes.Black, 10, 90);
                e.Graphics.DrawString("Tarih-Saat:" + starih.Text, font2.Font, Brushes.Black, 10, 110);
                e.Graphics.DrawString("************************************", font2.Font, Brushes.Black, 10, 125);
                e.Graphics.DrawString("Ürün Adı", font3.Font, Brushes.Black, 10, 130);
                e.Graphics.DrawString("Ürün Adedi", font3.Font, Brushes.Black, 150, 130, format);
                e.Graphics.DrawString("B.Fiyat", font3.Font, Brushes.Black, 200, 130, format);

                e.Graphics.DrawString("T.Fiyat", font3.Font, Brushes.Black, 250, 130, format);
                e.Graphics.DrawString("------------", font3.Font, Brushes.Black, 10, 140);
                e.Graphics.DrawString("------------", font3.Font, Brushes.Black, 150, 140, format);
                e.Graphics.DrawString("------------", font3.Font, Brushes.Black, 200, 140, format);
                e.Graphics.DrawString("------------", font3.Font, Brushes.Black, 250, 140, format);

                //if (urunad1.Text != "" || urunadet1.Text != "0" ||urunadet1.Text!="")
                if (urunad1.Text != "" && urunadet1.Text != "0" && urunadet1.Text != "")
                {
                    e.Graphics.DrawString(urunad1.Text, font4.Font, Brushes.Black, 10, 150);
                    e.Graphics.DrawString(urunadet1.Text, font4.Font, Brushes.Black, 150, 150, format);
                    e.Graphics.DrawString(birimfiyat1.Text + " " + "₺", font4.Font, Brushes.Black, 200, 150, format);
                    e.Graphics.DrawString(tfiyat1.Text + " " + "₺", font4.Font, Brushes.Black, 250, 150, format);
                }
                if (urunad2.Text != "" && urunadet2.Text != "0" && urunadet2.Text != "")
                {
                    e.Graphics.DrawString(urunad2.Text, font4.Font, Brushes.Black, 10, 165);
                    e.Graphics.DrawString(urunadet2.Text, font4.Font, Brushes.Black, 150, 165, format);
                    e.Graphics.DrawString(birimfiyat2.Text + " " + "₺", font4.Font, Brushes.Black, 200, 165, format);
                    e.Graphics.DrawString(tfiyat2.Text + " " + " " + "₺", font4.Font, Brushes.Black, 250, 165, format);
                }
                if (urunad3.Text != "" && urunadet3.Text != "0" && urunadet3.Text != "")
                {
                    e.Graphics.DrawString(urunad3.Text, font4.Font, Brushes.Black, 10, 180);
                    e.Graphics.DrawString(urunadet3.Text, font4.Font, Brushes.Black, 150, 180, format);
                    e.Graphics.DrawString(birimfiyat3.Text + " " + "₺", font4.Font, Brushes.Black, 200, 180, format);
                    e.Graphics.DrawString(tfiyat3.Text + " " + "₺", font4.Font, Brushes.Black, 250, 180, format);
                }
                if (urunad4.Text != "" && urunadet4.Text != "0" && urunadet4.Text != "")
                {
                    e.Graphics.DrawString(urunad4.Text, font4.Font, Brushes.Black, 10, 195);
                    e.Graphics.DrawString(urunadet4.Text, font4.Font, Brushes.Black, 150, 195, format);
                    e.Graphics.DrawString(birimfiyat4.Text + " " + "₺", font4.Font, Brushes.Black, 200, 195, format);
                    e.Graphics.DrawString(tfiyat4.Text + " " + "₺", font4.Font, Brushes.Black, 250, 195, format);
                }
                if (urunad5.Text != "" && urunadet5.Text != "0" && urunadet5.Text != "")
                {
                    e.Graphics.DrawString(urunad5.Text, font4.Font, Brushes.Black, 10, 210);
                    e.Graphics.DrawString(urunadet5.Text, font4.Font, Brushes.Black, 150, 210, format);
                    e.Graphics.DrawString(birimfiyat5.Text + "₺", font4.Font, Brushes.Black, 200, 210, format);
                    e.Graphics.DrawString(tfiyat5.Text + " " + "₺", font4.Font, Brushes.Black, 250, 210, format);
                }
                if (urunad6.Text != "" && urunadet6.Text != "0" && urunadet6.Text != "")
                {
                    e.Graphics.DrawString(urunad6.Text, font4.Font, Brushes.Black, 10, 225);
                    e.Graphics.DrawString(urunadet6.Text, font4.Font, Brushes.Black, 150, 225, format);
                    e.Graphics.DrawString(birimfiyat6.Text + " " + "₺", font4.Font, Brushes.Black, 200, 225, format);
                    e.Graphics.DrawString(tfiyat6.Text + " " + "₺", font4.Font, Brushes.Black, 250, 225, format);
                }
                if (urunad7.Text != "" && urunadet7.Text != "0" && urunadet7.Text != "")
                {
                    e.Graphics.DrawString(urunad7.Text, font4.Font, Brushes.Black, 10, 240);
                    e.Graphics.DrawString(urunadet7.Text, font4.Font, Brushes.Black, 150, 240, format);
                    e.Graphics.DrawString(birimfiyat7.Text + " " + "₺", font4.Font, Brushes.Black, 200, 240, format);
                    e.Graphics.DrawString(tfiyat7.Text + " " + "₺", font4.Font, Brushes.Black, 250, 240, format);
                }
                if (urunad8.Text != "" && urunadet8.Text != "0" && urunadet8.Text != "")
                {
                    e.Graphics.DrawString(urunad8.Text, font4.Font, Brushes.Black, 10, 255);
                    e.Graphics.DrawString(urunadet8.Text, font4.Font, Brushes.Black, 150, 255, format);
                    e.Graphics.DrawString(birimfiyat8.Text + " " + "₺", font4.Font, Brushes.Black, 200, 255, format);
                    e.Graphics.DrawString(tfiyat8.Text + " " + "₺", font4.Font, Brushes.Black, 250, 255, format);
                }
                e.Graphics.DrawString("________________________________", font2.Font, Brushes.Black, 10, 270);
                e.Graphics.DrawString("TOPLAM :", font4.Font, Brushes.Black, 150, 290);
                e.Graphics.DrawString(toplam.Text + " " + "₺", font4.Font, Brushes.Black, 250, 290, format);
                if (kdvoran.Text != "" && kdvoran.Text != "0" && kdv.Text != "" && kdv.Text != "0")
                {
                    e.Graphics.DrawString("KDV :" + kdvoran.Text, font4.Font, Brushes.Black, 150, 310);
                    e.Graphics.DrawString(kdv.Text + " " + "₺", font4.Font, Brushes.Black, 250, 310, format);
                }
                e.Graphics.DrawString(odemetur.Text, font4.Font, Brushes.Black, 50, 330);
                e.Graphics.DrawString("G.TOPLAM :", font4.Font, Brushes.Black, 150, 330);
                e.Graphics.DrawString(gtoplam.Text + " " + "₺", font4.Font, Brushes.Black, 250, 330, format);

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime zaman = DateTime.Now;
            starih.Text = zaman.ToString();
            satistemizle();
            adetbutonac();

        }

        private void Font4_TextChanged(object sender, EventArgs e)
        {
            bags = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");
            dass = new SqlDataAdapter("Select *from TBLFIS where fno like '" + font4.Text + "' ", bags);
            dtss = new DataSet();
            bags.Open();
            dass.Fill(dts, "TBLFIS");
            bags.Close();
            dataGridView3.DataSource = dtss.Tables["TBLFIS"];
        }

        public void satisstokdus5()
        {
            baglanti5 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi9 = Convert.ToDecimal(us5.Text);
            decimal sayi10 = Convert.ToDecimal(urunadet5.Text);
            decimal ss5 = sayi9 - sayi10;
            uk5.Text = ss5.ToString();

            komut5 = new SqlCommand();
            baglanti5.Open();
            komut5.Connection = baglanti5;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut5.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk5.Text + "'WHERE sno=" + un5.Text + "";//update komutu


            komut5.ExecuteNonQuery();
            baglanti5.Close();
            listelestok();
        }

        public void satisstokdus6()
        {
            baglanti6 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi11 = Convert.ToDecimal(us6.Text);
            decimal sayi12 = Convert.ToDecimal(urunadet6.Text);
            decimal ss6 = sayi11 - sayi12;
            uk6.Text = ss6.ToString();

            komut6 = new SqlCommand();
            baglanti6.Open();
            komut6.Connection = baglanti6;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut6.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk6.Text + "'WHERE sno=" + un6.Text + "";//update komutu


            komut6.ExecuteNonQuery();
            baglanti6.Close();
            listelestok();
        }

        public void satisstokdus7()
        {
            baglanti7 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi13 = Convert.ToDecimal(us7.Text);
            decimal sayi14 = Convert.ToDecimal(urunadet7.Text);
            decimal ss7 = sayi13 - sayi14;
            uk7.Text = ss7.ToString();

            komut7 = new SqlCommand();
            baglanti7.Open();
            komut7.Connection = baglanti7;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut7.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk7.Text + "'WHERE sno=" + un7.Text + "";//update komutu


            komut7.ExecuteNonQuery();
            baglanti7.Close();
            listelestok();
        }
        public void satisstokdus8()
        {
            baglanti8 = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");


            decimal sayi15 = Convert.ToDecimal(us7.Text);
            decimal sayi16 = Convert.ToDecimal(urunadet7.Text);
            decimal ss8 = sayi15 - sayi16;
            uk8.Text = ss8.ToString();

            komut8 = new SqlCommand();
            baglanti8.Open();
            komut8.Connection = baglanti8;
            //OleDbCommand komut=new OleDbCommand("UPDATE stokbil SET stokAdi='" + textBox1.Text + "',stokModeli='" + textBox2.Text + "',stokSeriNo='" + textBox3.Text + "',stokAdedi='" + textBox4.Text + "',stokTarih='" + dateTimePicker1.Text + "',kayitYapan='" + textBox5.Text + "',dosyaAdi='" + DosyaAdi + "' WHERE id="+id,);

            komut8.CommandText = "UPDATE TBLSTOK SET urunadet='" + uk8.Text + "'WHERE sno=" + un8.Text + "";//update komutu


            komut8.ExecuteNonQuery();
            baglanti8.Close();
            listelestok();
        }


        public void yazicilistele()
        {
            baglantiy = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=FOTODB;Integrated Security=True");
            day = new SqlDataAdapter("Select *from TBLPRINTERS", baglantiy);
            dt1 = new DataTable();
            baglantiy.Open();
            day.Fill(dt1);
            fisprint.DataSource = dt1;
            fisprint.DisplayMember = "fisprint";
            baglantiy.Close();
        }
        public void urunekletemizle()
        {
            surunad.Clear();
            surunadet.Clear();
            surunfiyat.Clear();
        }
        public string yaziyaCevir(decimal tutar)
        {
            string sTutar = tutar.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
            string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] binler = { "Katrilyon", "Trilyon", "Milyar", "Milyon", "Bin", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

            int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

            lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "Yüz"; //yüzler                

                if (grupDegeri == "BirYüz") //biryüz düzeltiliyor.
                    grupDegeri = "Yüz";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                if (grupDegeri != "") //binler
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BirBin") //birbin düzeltiliyor.
                    grupDegeri = "Bin";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " TL ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0") //kuruş onlar
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0") //kuruş birler
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Kr.";
            else
                yazi += "Sıfır Kr.";
            yaziyla.Text = yazi.ToString();
            return yazi;
        }

        public void virgulnokta()
        {

            //urunadet1.Text = urunadet1.Text.Replace(",", ".");urunadet2.Text = urunadet2.Text.Replace(",", "."); urunadet3.Text = urunadet3.Text.Replace(",", ".");
            //urunadet4.Text = urunadet4.Text.Replace(",", ".");urunadet5.Text = urunadet5.Text.Replace(",", ".");urunadet6.Text = urunadet6.Text.Replace(",", ".");
            //urunadet7.Text = urunadet7.Text.Replace(",", ".");urunadet8.Text = urunadet8.Text.Replace(",", ".");
            birimfiyat1.Text = birimfiyat1.Text.Replace(",", "."); tfiyat1.Text = tfiyat1.Text.Replace(",", ".");
            birimfiyat2.Text = birimfiyat2.Text.Replace(",", "."); tfiyat2.Text = tfiyat2.Text.Replace(",", ".");
            birimfiyat3.Text = birimfiyat3.Text.Replace(",", "."); tfiyat3.Text = tfiyat3.Text.Replace(",", ".");
            birimfiyat3.Text = birimfiyat3.Text.Replace(",", "."); tfiyat3.Text = tfiyat3.Text.Replace(",", ".");
            birimfiyat4.Text = birimfiyat4.Text.Replace(",", "."); tfiyat4.Text = tfiyat4.Text.Replace(",", ".");
            birimfiyat5.Text = birimfiyat5.Text.Replace(",", "."); tfiyat5.Text = tfiyat5.Text.Replace(",", ".");
            birimfiyat6.Text = birimfiyat6.Text.Replace(",", "."); tfiyat6.Text = tfiyat6.Text.Replace(",", ".");
            birimfiyat7.Text = birimfiyat7.Text.Replace(",", "."); tfiyat7.Text = tfiyat7.Text.Replace(",", ".");
            birimfiyat8.Text = birimfiyat8.Text.Replace(",", "."); tfiyat8.Text = tfiyat8.Text.Replace(",", ".");
            toplam.Text = toplam.Text.Replace(",", "."); kdv.Text = kdv.Text.Replace(",", "."); gtoplam.Text = gtoplam.Text.Replace(",", ".");

        }
        public void noktavirgul()
        {
            urunadet1.Text = urunadet1.Text.Replace(".", ","); birimfiyat1.Text = birimfiyat1.Text.Replace(".", ","); tfiyat1.Text = tfiyat1.Text.Replace(".", ",");
            urunadet2.Text = urunadet2.Text.Replace(".", ","); birimfiyat2.Text = birimfiyat2.Text.Replace(".", ","); tfiyat2.Text = tfiyat2.Text.Replace(".", ",");
            urunadet3.Text = urunadet3.Text.Replace(".", ","); birimfiyat3.Text = birimfiyat3.Text.Replace(".", ","); tfiyat3.Text = tfiyat3.Text.Replace(".", ",");
            urunadet4.Text = urunadet4.Text.Replace(".", ","); birimfiyat4.Text = birimfiyat4.Text.Replace(".", ","); tfiyat4.Text = tfiyat4.Text.Replace(".", ",");
            urunadet5.Text = urunadet5.Text.Replace(".", ","); birimfiyat5.Text = birimfiyat5.Text.Replace(".", ","); tfiyat5.Text = tfiyat5.Text.Replace(".", ",");
            urunadet6.Text = urunadet6.Text.Replace(".", ","); birimfiyat6.Text = birimfiyat6.Text.Replace(".", ","); tfiyat6.Text = tfiyat6.Text.Replace(".", ",");
            urunadet7.Text = urunadet7.Text.Replace(".", ","); birimfiyat7.Text = birimfiyat7.Text.Replace(".", ","); tfiyat7.Text = tfiyat7.Text.Replace(".", ",");
            urunadet8.Text = urunadet8.Text.Replace(".", ","); birimfiyat8.Text = birimfiyat8.Text.Replace(".", ","); tfiyat8.Text = tfiyat8.Text.Replace(".", ",");
            toplam.Text = toplam.Text.Replace(".", ","); kdv.Text = kdv.Text.Replace(".", ","); gtoplam.Text = gtoplam.Text.Replace(".", ",");
        }

    }
}


