# Yapay Arı Kolonisi (ABC) Algoritması Optimizasyon Uygulaması

Bu proje, Yapay Arı Kolonisi (Artificial Bee Colony - ABC) algoritmasının C# ile implementasyonunu içermektedir. Algoritma, optimizasyon problemlerini çözmek için doğadaki arıların besin arama davranışlarını taklit eder.

## 🎯 Projenin Amacı

Bu uygulama, aşağıdaki amaç fonksiyonunun minimum değerini bulmak için ABC algoritmasını kullanır:

```
f(x1,x2) = 2x1² - 1.05x1⁴ + (x1⁶/6) + x1x2 + x2²
```

## ✨ Özellikler

- Görsel yakınsama grafiği
- Detaylı iterasyon sonuçları
- En iyi sonuçların anlık gösterimi
- Parametre ayarlanabilir arayüz:
  - Koloni boyutu
  - Alt ve üst sınırlar
  - Çevrim sayısı
  - Deneme sayısı

## 🛠️ Teknik Detaylar

### Algoritma Bileşenleri

1. **İşçi Arılar**: Mevcut besin kaynaklarını iyileştirmeye çalışır
2. **Gözcü Arılar**: İşçi arıların bulduğu besin kaynaklarını değerlendirir
3. ** Kaşif Arılar**: Yeni besin kaynakları arar

### Kullanılan Sınıflar

- `Besin`: Besin kaynaklarını yönetir
- `Besinler`: Her bir besin kaynağının özelliklerini tutar
- `YapayAriKolonisi`: ABC algoritmasının ana mantığını içerir

## 📊 Sonuçların Gösterimi

Uygulama, algoritmanın çalışması sırasında:
- Yakınsama grafiği
- Her iterasyondaki X1, X2, Fx ve Fit değerleri
- Bulunan en iyi sonuçlar

bilgilerini gösterir.

## 🚀 Kullanım

1. Gerekli parametreleri ayarlayın:
   - Koloni Boyutu: Arı kolonisinin toplam boyutu
   - Alt/Üst Sınır: Değişkenlerin alabileceği minimum/maksimum değerler
   - Çevrim Sayısı: Algoritmanın kaç kez çalıştırılacağı
   - Deneme Sayısı: Bir besin kaynağının kaç kez iyileştirilmeye çalışılacağı

2. "Hesapla" butonuna tıklayın
3. Sonuçları grafik ve metin kutusunda inceleyin

## 💻 Gereksinimler

- .NET Framework 4.0 veya üzeri
- Windows Forms uygulaması
- System.Windows.Forms.DataVisualization (grafikler için)

## 📝 Lisans

Bu proje MIT lisansı altında lisanslanmıştır. Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 🤝 Katkıda Bulunma

1. Bu depoyu fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi commit edin (`git commit -m 'Add some amazing feature'`)
4. Branch'inizi push edin (`git push origin feature/amazing-feature`)
5. Bir Pull Request oluşturun

## 📞 İletişim

Proje Sahibi: [GitHub Profiliniz]

## 🙏 Teşekkürler

- ABC algoritmasının mucitleri
- Tüm katkıda bulunanlar
- Bu projeyi kullanan ve geri bildirimde bulunan herkes 