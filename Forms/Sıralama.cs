using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace kutuphaneSistemi
{
    public partial class Sıralama : Form
    {

        GraphPane myPane = new GraphPane();
        PointPairList listPoints = new PointPairList();
        public Sıralama()
        {
            InitializeComponent();

            myPane = zedGraphControl1.GraphPane;
            
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void Sıralama_Load(object sender, EventArgs e)
        {
            Listele();
            ListeleEmanet();
            lblKalanKitap.Text = Convert.ToString(Convert.ToInt32(lblToplamKitap.Text) - Convert.ToInt32(lblEmanetKitap.Text));
            Grafik();
        }

        void Listele()
        {
            IKitaplarService kitaplarService = new KitaplarService();
            var sonuc = kitaplarService.KitaplarListesi("Select *from Kitaplar");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            lblToplamKitap.Text = sonuc.Count.ToString();
        }

        void ListeleEmanet()
        {
            IKutuphaneService kutuphaneService = new KutuphaneService();
            var sonuc = kutuphaneService.kutuphaneListesi("Select *from Kutuphane");  //Veritabanından bilgileri çekiyoruz ve sonuc değişkenine atıyoruz
            lblEmanetKitap.Text = sonuc.Count.ToString();
        }
        void Grafik()
        {   
            myPane.Title.Text = "Kitap Grafiği";
            myPane.XAxis.Title.Text = "Kitaplar";
            myPane.YAxis.Title.Text = "Kitap Sayısı";
            PointPair pointPair = new PointPair(1, Convert.ToInt32(lblToplamKitap.Text));
            listPoints.Add(pointPair);
            pointPair = new PointPair(2, Convert.ToInt32(lblKalanKitap.Text));
            listPoints.Add(pointPair);
            pointPair = new PointPair(3, Convert.ToInt32(lblEmanetKitap.Text));
            listPoints.Add(pointPair);
            LineItem lineItem = myPane.AddCurve("Kitap Sayısı",listPoints,Color.Red);
            zedGraphControl1.AxisChange();
        }

        private void zedGraphControl1_DoubleClick(object sender, EventArgs e)
        {
            zedGraphControl1.ZoomOutAll(myPane);
        }

        private string zedGraphControl1_PointValueEvent(ZedGraphControl sender, GraphPane pane, CurveItem curve, int iPt)
        {
            return lblToplamKitap.Text + " ; " + curve.Label.Text + (curve[iPt].Y.ToString());
        }
    }
}
