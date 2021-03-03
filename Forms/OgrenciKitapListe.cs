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
    public partial class OgrenciKitapListe : MetroFramework.Forms.MetroForm
    {

        public OgrenciKitapListe()
        {
            InitializeComponent();
        }

        void EmanetListele()
        {
            IOgrenciEmanetService ogrenciEmanetService = new OgrenciEmanetService();
            var sonuc = ogrenciEmanetService.ogrenciEmanetListesi("Select *from OgrenciEmanet");
            dataGridView1.DataSource = sonuc;
        }

        void TeslimEdilen()
        {
            
            IOgrenciTeslimService ogrenciTeslimService = new OgrenciTeslimService();
            var sonuc = ogrenciTeslimService.ogrenciTeslimListesi("Select *from OgrenciTeslim");
            dataGridView2.DataSource = sonuc;
        }

        private void OgrenciKitapListe_Load(object sender, EventArgs e)
        {
            EmanetListele();
            TeslimEdilen();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            IOgrenciEmanetService ogrenciEmanetService = new OgrenciEmanetService();
            var sonuc = ogrenciEmanetService.ogrenciEmanetListesi("select *from OgrenciEmanet where Tc like '%" + textBox1.Text + "%'");
            dataGridView1.DataSource = sonuc;

            IOgrenciTeslimService ogrenciTeslimService = new OgrenciTeslimService();
            var sonuc1 = ogrenciTeslimService.ogrenciTeslimListesi("select *from OgrenciTeslim where Tc like '%" + textBox1.Text + "%'");
            dataGridView2.DataSource = sonuc1;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            button1.PerformClick();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
