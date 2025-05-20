using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            // Gerekli tanımlamalar yapılıyor
            int koloniBoyutu = (int)nudKoloni.Value;
            int altSinir = (int)nudAlt.Value;
            int ustSinir = (int)nudUst.Value;
            int cevrimSayisi = (int)nudCevrim.Value;
            int denemeSayisi = (int)nudDeneme.Value;

            chartFx.Series["fx"].Points.Clear();
            textBox1.Text = "";

            // Yapay arı kolonisi isimli bir sınıf oluşturuluyor ve formdan verilen bilgiler gönderiliyor.
            YapayAriKolonisi yapayAriKolonisi = new YapayAriKolonisi(koloniBoyutu, altSinir, ustSinir, cevrimSayisi, denemeSayisi);

            // Yakınsama grafiği için tüm değerleri göster
            for (int i = 0; i < yapayAriKolonisi.fxDegerleri.Count; i++)
            {
                chartFx.Series["fx"].Points.Add(yapayAriKolonisi.fxDegerleri[i]);
            }

            // En iyi değerleri bul
            int enIyiIndex = yapayAriKolonisi.fxDegerleri.IndexOf(yapayAriKolonisi.fxDegerleri.Min());
            double enIyiX1 = yapayAriKolonisi.eniyiX1List[enIyiIndex];
            double enIyiX2 = yapayAriKolonisi.eniyiX2List[enIyiIndex];
            double enIyiFx = yapayAriKolonisi.fxDegerleri[enIyiIndex];
            double enIyiFit = yapayAriKolonisi.fitDegerleri[enIyiIndex];

            // Önce en iyi sonuçları göster
            textBox1.Text = "EN İYİ SONUÇLAR" + Environment.NewLine;
            textBox1.Text += "===================" + Environment.NewLine;
            textBox1.Text += $"En İyi X1: {enIyiX1:F6}" + Environment.NewLine;
            textBox1.Text += $"En İyi X2: {enIyiX2:F6}" + Environment.NewLine;
            textBox1.Text += $"En İyi Fx: {enIyiFx:F6}" + Environment.NewLine;
            textBox1.Text += $"En İyi Fit: {enIyiFit:F6}" + Environment.NewLine;
            textBox1.Text += "===================" + Environment.NewLine + Environment.NewLine;

            // Sonra iterasyon sonuçlarını göster
            textBox1.Text += "İTERASYON SONUÇLARI:" + Environment.NewLine;
            textBox1.Text += "===================" + Environment.NewLine;
            for (int i = 0; i < yapayAriKolonisi.fxDegerleri.Count; i++)
            {
                textBox1.Text += $"İterasyon {i + 1}:" + Environment.NewLine;
                textBox1.Text += $"X1: {yapayAriKolonisi.eniyiX1List[i]:F6}" + Environment.NewLine;
                textBox1.Text += $"X2: {yapayAriKolonisi.eniyiX2List[i]:F6}" + Environment.NewLine;
                textBox1.Text += $"Fx: {yapayAriKolonisi.fxDegerleri[i]:F6}" + Environment.NewLine;
                textBox1.Text += $"Fit: {yapayAriKolonisi.fitDegerleri[i]:F6}" + Environment.NewLine;
                textBox1.Text += "-------------------" + Environment.NewLine;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Grafik başlıklarını ayarla
            chartFx.Titles.Add("Yakınsama Grafiği");
            
            // Fx grafiği için ayarlar
            chartFx.ChartAreas[0].AxisX.Title = "İterasyon";
            chartFx.ChartAreas[0].AxisY.Title = "Amaç Fonksiyonu Değeri (Fx)";
        }
    }
}
