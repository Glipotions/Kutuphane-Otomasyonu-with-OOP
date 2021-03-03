using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Service;
using Data;

namespace kutuphaneSistemi
{
    public partial class OgrenciFrm : MetroFramework.Forms.MetroForm
    {
        IOgrenciService ogrenciService;
        
        public OgrenciFrm()
        {
            InitializeComponent();
        }
        //OleDbConnection baglantı;
        //OleDbCommand komut;
        //OleDbDataAdapter da;
        //Baglanti baglantı = new Baglanti();
        
        void Listele()
        {
            IOgrenciService ogrenciService = new OgrenciService();
            var sonuc = ogrenciService.ogrenciListesi("Select *from Ogrenci");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            dataGridView1.DataSource = sonuc; //Veritabanından çektiklerimizi gösteriyoruz

        }
  

        private void button2_Click(object sender, EventArgs e)
        {
            ogrenciService = new OgrenciService();
            ogrenciService.delete("Delete From Ogrenci Where Tc='"+ dataGridView1.CurrentRow.Cells[0].Value + "'");
            MessageBox.Show($"Kayıt Silindi!! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();

        }
        
        private void Ogrenci_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTc.Text = null;
            txtAd.Text = null;
            txtMail.Text = null;
            txtTelefon.Text = null;
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ogrenciService = new OgrenciService();                     
                ogrenciService.insert("Insert into Ogrenci (Tc,Ad,Email,Telefon) values ('" + txtTc.Text + "','" + txtAd.Text + "','" + txtMail.Text + "','" + txtTelefon.Text + "')");
                MessageBox.Show($"Kayıt Eklendi!! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { MessageBox.Show($"BU TC'YE KAYITLI ÖĞRENCİ ZATEN VAR!! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            finally
            {
                dataGridView1.DataSource = null;
                Listele();
                
            }
           
        }
     
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ogrenciService = new OgrenciService();
            ogrenciService.update($"Update Ogrenci Set Ad='"+txtAd.Text+"', Email='"+txtMail.Text+"' , Telefon='"+txtTelefon.Text+"' Where Tc='"+txtTc.Text+"'");
            MessageBox.Show($"Kayıt Güncellendi ! ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            
        }



        private void txtTc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçtiğimiz satırın Textboxlarda görünmesini sağlar
            txtTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
