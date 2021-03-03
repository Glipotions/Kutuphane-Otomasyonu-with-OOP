using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneSistemi
{
    public partial class Kutuphane : MetroFramework.Forms.MetroForm
    {
        IKutuphaneService kutuphaneService;
        IOgrenciEmanetService ogrenciEmanetService;
        IAlinanKitaplarService alinanKitaplarService;
        IOgrenciTeslimService ogrenciTeslimService;
        IKitapTeslimGecmisiService kitapTeslimGecmisiService;


        public Kutuphane()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı;
        OleDbCommand komut;
        //OleDbDataAdapter da;
        OleDbDataReader read;
        void KutuphaneListele()
        {
            IKutuphaneService kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("Select *from Kutuphane");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView1.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz

        }
        
        void KitapListesi()
        {
            string sorgu = "select *from Kitaplar";
            komut = new OleDbCommand(sorgu, baglantı);

            baglantı.Open();
            read = komut.ExecuteReader();
            while (read.Read())
            {
                cbKitapAdi.Items.Add(read["KitapAdı"].ToString());
                cbKitapAdiAra.Items.Add(read["KitapAdı"].ToString());
            }
            baglantı.Close();
        }
        void AlinanlariListele()
        {
            IAlinanKitaplarService alinanKitaplar = new AlinanKitaplarService();
            var sonuc = alinanKitaplar.AlinanKitaplarListesi("Select *from AlinanKitaplar");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView2.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            
            string sorgu = "select *from Ogrenci where Tc='"+txtTc.Text+"'";
            komut = new OleDbCommand(sorgu, baglantı);

            if (baglantı.State == ConnectionState.Open)
            {
            }
            else
            { baglantı.Open(); }
            read = komut.ExecuteReader();
            while(read.Read())
            {
                txtAd.Text = read["Ad"].ToString();
                //txtSoyad.Text = read["Soyad"].ToString();
            }
            

        }

        private void Kutuphane_Load(object sender, EventArgs e)
        {
            baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kutuphane.accdb.mdb");
            KutuphaneListele();
            AlinanlariListele();
            renklendirme();
            KitapListesi();
            dateTimePicker1.Text = DateTime.Now.AddDays(15).ToShortDateString();


        }
        // teslim aldı teslim etti


        private void renklendirme()
        {
            DataGridViewCellStyle styleYesil = new DataGridViewCellStyle();
            styleYesil.BackColor = Color.Green;
            dataGridView2.Columns[4].DefaultCellStyle = styleYesil;
            //[0] aldığı tarih    [1] teslim etmesi gereken tarih

            DateTime d1;
            DateTime d2;
            DataGridViewCellStyle styleKırmızı = new DataGridViewCellStyle();
            DataGridViewCellStyle styleSarı = new DataGridViewCellStyle();

            styleKırmızı.BackColor = Color.Red;
            styleSarı.BackColor = Color.Yellow;

            //styleKırmızı.ForeColor = Color.White;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                d1 = Convert.ToDateTime(DateTime.Now.ToShortDateString());  //bugünün tarihi
                d2 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);  //vermesi gereken tarih
                TimeSpan ts = d1 - d2;

                if (ts.Days > 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle = styleKırmızı;
                }
                else if (ts.Days >= -2)
                {
                    dataGridView1.Rows[i].DefaultCellStyle = styleSarı;
                }

            }
        }


        private void txtKod_TextChanged(object sender, EventArgs e)
        {
            string sorgu = "select *from Kitaplar where KitapKodu='" + txtKod.Text + "'";
            komut = new OleDbCommand(sorgu, baglantı);
            if (baglantı.State == ConnectionState.Open){}
            else
            { baglantı.Open(); }
            read = komut.ExecuteReader();
            while (read.Read())
            {
                cbKitapAdi.Text = read["KitapAdı"].ToString();
                txtYazar.Text = read["Yazar"].ToString();
                txtKitapTuru.Text = read["Tür"].ToString();
                txtSayfaSayisi.Text = read["SayfaSayısı"].ToString();
                txtBasimTarihi.Text = read["BasımTarihi"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            kutuphaneService = new KutuphaneService();
            kutuphaneService.insert("Insert into Kutuphane (TeslimAldıgıTarih,TeslimEdilecekTarih,Tc,Ad,KitapKodu,KitapAdı) values ('" + DateTime.Now.ToShortDateString() + "','" + dateTimePicker1.Text + "'," +
                "'" + txtTc.Text + "','" + txtAd.Text + "'" +
                ",'" + Convert.ToInt32(txtKod.Text) + "','" + cbKitapAdi.Text + "')");

            //DateTime.Now.AddDays(15).ToShortDateString()

            ogrenciEmanetService = new OgrenciEmanetService();
            ogrenciEmanetService.insert("Insert into OgrenciEmanet (Tc,Ad,KitapKodu,KitapAdı) values ('" + txtTc.Text + "','" + txtAd.Text + "'" +
                ",'" + Convert.ToInt32(txtKod.Text) + "','" + cbKitapAdi.Text + "')");
            MessageBox.Show($"Kitap Teslim Verildi ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            KutuphaneListele();
            renklendirme();
        }


        private void cbKitapAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbDataReader read;
            string sorgu = "select *from Kitaplar where KitapAdı='" + cbKitapAdi.SelectedItem + "'";
            komut = new OleDbCommand(sorgu, baglantı);
            if (baglantı.State == ConnectionState.Open)
            {
            }
            else
            { baglantı.Open(); }
            read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKod.Text = read["KitapKodu"].ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ////Alınan Kitaplar Kısmı
            alinanKitaplarService = new AlinanKitaplarService();
            alinanKitaplarService.insert("Insert into AlinanKitaplar (TeslimEdilenTarih,Tc,Ad,KitapKodu,KitapAdı) values ('" + DateTime.Now.ToShortDateString() + "','" + dataGridView1.CurrentRow.Cells["Tc"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + "'" +
                ",'" + dataGridView1.CurrentRow.Cells["KitapKodu"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["KitapAdı"].Value.ToString() + "')");

            

            //// Öğrenci Teslim Ettiği kitaplar kısmı 
            ogrenciTeslimService = new OgrenciTeslimService();
            ogrenciTeslimService.insert("Insert into OgrenciTeslim (Tc,Ad,KitapKodu,KitapAdı) values ('" + dataGridView1.CurrentRow.Cells["Tc"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + "'" +
                ",'" + dataGridView1.CurrentRow.Cells["KitapKodu"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["KitapAdı"].Value.ToString() + "')");


            // Kitap Teslim Geçmişi Tablosuna Ekleme kısmı 
            kitapTeslimGecmisiService = new KitapTeslimGecmisiService();
            kitapTeslimGecmisiService.insert("Insert into KitapTeslimGecmisi (KitapKodu,KitapAdı,TeslimAlmaTarihi,TeslimEdilmeTarihi,Tc,Ad) values ('"+ dataGridView1.CurrentRow.Cells["KitapKodu"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["KitapAdı"].Value.ToString() + "'" +
                ",'"+ dataGridView1.CurrentRow.Cells["TeslimAldıgıTarih"].Value.ToString() +"','"+ DateTime.Now.ToShortDateString() + "'"+
                ",'" + dataGridView1.CurrentRow.Cells["Tc"].Value.ToString() + "','" + dataGridView1.CurrentRow.Cells["Ad"].Value.ToString()+"')");


            // TABLOLARDAN SİLME KOMUTLARI AŞAĞIDA

            // Öğrenci Emanet Tablosundan Silme Komutları
            ogrenciEmanetService = new OgrenciEmanetService();
            ogrenciEmanetService.delete("Delete From OgrenciEmanet Where Tc='" + dataGridView1.CurrentRow.Cells["Tc"].Value + "' and KitapKodu='"+ dataGridView1.CurrentRow.Cells["KitapKodu"].Value + "'");

            // Kütüphaneden Teslim edilen kısmından silinme komutları
            kutuphaneService = new KutuphaneService();
            kutuphaneService.delete("Delete From Kutuphane Where Tc='" + dataGridView1.CurrentRow.Cells["Tc"].Value + "' and KitapKodu='" + dataGridView1.CurrentRow.Cells["KitapKodu"].Value + "'");

            MessageBox.Show($"Kitap Teslim Alındı! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AlinanlariListele();
            KutuphaneListele();
            renklendirme();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView1.CurrentRow.Cells["Tc"].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString();

            txtKod.Text = dataGridView1.CurrentRow.Cells["KitapKodu"].Value.ToString();
            cbKitapAdi.Text = dataGridView1.CurrentRow.Cells["KitapAdı"].Value.ToString();


            DateTime d1;
            DateTime d2;

            //styleKırmızı.ForeColor = Color.White;
            try
            {
                d1 = Convert.ToDateTime(DateTime.Now.ToShortDateString());  //bugünün tarihi
                d2 = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value);  //vermesi gereken tarih
                                                                                   //d2 = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);
                TimeSpan ts = d1 - d2;
                if (ts.Days > 0)
                { lblBorc.Text = Convert.ToString(ts.Days); }
                else
                { lblBorc.Text = "0"; }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("select *from Kutuphane where Tc like '%" + txtTcAra.Text + "%'");
            dataGridView1.DataSource = sonuc;
        }

        private void txtKitapKoduAra_TextChanged(object sender, EventArgs e)
        {
            kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("select *from Kutuphane where KitapKodu like '%" + txtKitapKoduAra.Text + "%'");
            dataGridView1.DataSource = sonuc;
        }

        private void cbKitapAdiAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("select *from Kutuphane where KitapAdı like '%" + cbKitapAdiAra.Text + "%'");
            dataGridView1.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAd.Text = null;
            txtBasimTarihi.Text = null;
            txtKitapTuru.Text = null;
            txtSayfaSayisi.Text = null;
            txtYazar.Text = null;
            txtTc.Text = null;
            txtTcAra.Text = null;
            cbKitapAdi.Text = null;
            cbKitapAdiAra.Text = null;
            txtKitapKoduAra.Text = null;
            txtKod.Text = null;
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTcAra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
