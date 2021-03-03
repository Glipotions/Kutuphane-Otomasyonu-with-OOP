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
using Service;

namespace kutuphaneSistemi
{
    public partial class Kitap : MetroFramework.Forms.MetroForm
    {
        IKitaplarService kitaplarService;
        IKutuphaneService kutuphaneService;
        IKitapTeslimGecmisiService kitapTeslimGecmisi;

        public Kitap()
        {
            InitializeComponent();
        }

        void KitapListele()
        {
            kitaplarService = new KitaplarService();
            var sonuc = kitaplarService.KitaplarListesi("Select *from Kitaplar");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView1.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz
        }

        void KitapListele1()
        {
            kitaplarService = new KitaplarService();
            var sonuc = kitaplarService.KitaplarListesi("Select *from Kitaplar");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView2.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz
        }

        void KitapEmanetGoruntule()
        {
            kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("Select *from Kutuphane");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView3.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz
        }

        void KitapTeslimGoruntule()
        {
            kitapTeslimGecmisi = new KitapTeslimGecmisiService();
            var sonuc = kitapTeslimGecmisi.KitapTeslimGecmisiListesi("Select *from KitapTeslimGecmisi");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView4.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz
        }



        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                kitaplarService = new KitaplarService();
                kitaplarService.insert("Insert into Kitaplar (KitapKodu,KitapAdı,Yazar,Tür,SayfaSayısı,BasımTarihi) values ('" + Convert.ToInt32(txtKod.Text) + "','" + txtKitapAdi.Text + "','" + txtYazar.Text + "'" +
                    ",'" + txtKitapTuru.Text + "','" + txtSayfaSayisi.Text + "','" + txtBasimTarihi.Text + "')");

                MessageBox.Show($"Kitap Eklendi! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch { MessageBox.Show($"BU KİTAP KODU İLE KAYITLI KİTAP ZATEN VAR!! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            KitapListele();


        }

        private void Kitap_Load(object sender, EventArgs e)
        {
            KitapListele();
            KitapListele1();
            KitapEmanetGoruntule();
            KitapTeslimGoruntule();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            kitaplarService = new KitaplarService();
            kitaplarService.delete("Delete From Kitaplar Where KitapKodu='" + dataGridView1.CurrentRow.Cells["KitapKodu"].Value + "'");
            MessageBox.Show($"Kitap Silindi! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KitapListele();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKod.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtKitapTuru.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSayfaSayisi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtBasimTarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
    
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            kitaplarService = new KitaplarService();
            kitaplarService.update("Update Kitaplar Set KitapAdı='" + txtKitapAdi.Text + "',Yazar='" + txtYazar.Text + "'," +
                "Tür='" + txtKitapTuru.Text + "',SayfaSayısı='" + txtSayfaSayisi.Text + "',BasımTarihi='" + txtBasimTarihi.Text + "' Where KitapKodu='" + Convert.ToInt32(txtKod.Text) + "'");

            MessageBox.Show($"Güncellendi! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KitapListele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKod.Text = null;
            txtKitapAdi.Text = null;
            txtKitapTuru.Text = null;
            txtYazar.Text = null;
            txtSayfaSayisi.Text = null;
            txtBasimTarihi.Text = null;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            kitaplarService = new KitaplarService();
            var sonuc = kitaplarService.KitaplarListesi("select *from Kitaplar where KitapKodu like '%" + txtKodlaAra.Text + "%'");
            dataGridView2.DataSource = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitaplarService = new KitaplarService();
            var sonuc = kitaplarService.KitaplarListesi("select *from Kitaplar where KitapAdı like '%" + txtAdAra.Text + "%'");
            dataGridView2.DataSource = sonuc;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtAdAra.Text = null;
            txtKodlaAra.Text = null;
            KitapListele1();
        }

        private void btnKitapGecmisKod_Click(object sender, EventArgs e)
        {

            kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("select *from Kutuphane where KitapKodu like '%" + txtKitapGecmisKod.Text + "%'");
            dataGridView3.DataSource = sonuc;

            kitapTeslimGecmisi = new KitapTeslimGecmisiService();
            var sonuc1 = kitapTeslimGecmisi.KitapTeslimGecmisiListesi("select *from KitapTeslimGecmisi where KitapKodu like '%" + txtKitapGecmisKod.Text + "%'");
            dataGridView4.DataSource = sonuc1;

        }

        private void btnKitapGecmisAd_Click(object sender, EventArgs e)
        {

            kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("select *from Kutuphane where KitapAdı like '%" + txtKitapGecmisAd.Text + "%'");
            dataGridView3.DataSource = sonuc;

            kitapTeslimGecmisi = new KitapTeslimGecmisiService();
            var sonuc1 = kitapTeslimGecmisi.KitapTeslimGecmisiListesi("select *from KitapTeslimGecmisi where KitapAdı like '%" + txtKitapGecmisAd.Text + "%'");
            dataGridView4.DataSource = sonuc1;

        }

        private void btnGecmisYeni_Click(object sender, EventArgs e)
        {
            txtKitapGecmisKod.Text = null;
            txtKitapGecmisAd.Text = null;
            KitapEmanetGoruntule();
            KitapTeslimGoruntule();
        }
    }
}
