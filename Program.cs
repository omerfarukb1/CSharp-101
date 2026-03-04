using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*****Başlangıç Çalışmaları*****
            //string sehir,ilce;
            //sehir = "İstanbul";
            //ilce = "Kadıköy";
            //Console.Write(sehir + "-" +ilce);


            //int sayi;
            //sayi = 24;
            //Console.Write(sayi);


            //int sayi1, sayi2, toplam;
            //sayi1 = 5;
            //sayi2 = 6;
            //toplam = sayi1 + sayi2;
            //Console.Write(toplam);


            //int s1, s2, toplam, carpım, bolum, fark;
            //Console.WriteLine("***** Aritmetik İşlemler *****");
            //Console.WriteLine();
            //s1 = 20;
            //s2 = 5;
            //toplam = s1 + s2;
            //fark = s1 - s2;
            //carpım = s1 * s2;
            //bolum = s1 / s2;
            //Console.WriteLine("Toplam :" + toplam);
            //Console.WriteLine("Bölum :" + bolum);
            //Console.WriteLine("Fark :" + fark);
            //Console.WriteLine("Çarpım :" + carpım);
            //Console.WriteLine();
            //Console.WriteLine("***** Aritmetik İşlemler *****");


            //string ad, soyad, bolum, ders;
            //int s1, s2, s3, ort;
            //Console.WriteLine("***** Öğrenci Bilgi Sistemi *****");
            //Console.WriteLine();
            ////string değişkenleri atamaları
            //ad = "Ömer Faruk";
            //soyad = "Bulut";
            //bolum = "Elektrik Elektronik Mühendisliği";
            //ders = "Elektrik Devreleri";
            //Console.WriteLine(ad + " " + soyad);
            //Console.WriteLine("Bölüm: " + bolum);
            //Console.WriteLine("Ders: " + ders);

            ////string değişkenleri atamaları
            //s1 = 78;
            //s2 = 86;
            //s3 = 95;
            //ort = (s1 + s2 + s3) / 3;
            //Console.WriteLine("Sınav1: " + s1);
            //Console.WriteLine("Sınav2: " + s2);
            //Console.WriteLine("Sınav3: " + s3);
            //Console.WriteLine("Ortalamanız: " + ort);

            //Console.WriteLine();
            //Console.WriteLine("***** Öğrenci Bilgi Sistemi *****");


            //Double sayi;
            //sayi = 24.9;
            //Console.WriteLine(sayi);

            //Double s1, s2, ort;
            //s1 = 78;
            //s2 = 65;
            //ort = (s1 + s2) / 2;
            //Console.WriteLine("Ortalamanız: " + ort);


            //String sehir,ilce;
            //Console.Write("Lütfen Şehrinizi Giriniz: ");
            //sehir = Console.ReadLine();
            //Console.Write("Lütfen İlçeyi Giriniz: ");
            //ilce = Console.ReadLine();
            //Console.WriteLine("Girdiğiniz Şehir Ve İlçe: " + sehir + " " + ilce);
            //Console.Read();


            //int sayi;
            //Console.Write("Sayıyı giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());
            //Console.Write(sayi);

            //int s1, s2, s3, toplam;
            //Console.Write("Sayi1: ");
            //s1 =Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sayi2: ");
            //s2 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Sayi3: ");
            //s3 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Toplam: ");
            //toplam = s1 + s2 + s3;
            //Console.Write(toplam);
            //Console.Read();

            //Başlangıç Çalışmaları Notlar
            //string değişken tanımlama
            //int tam sayı tanımlama(in16,int32,int64)

            //***** Değişkenler *****(String Ve İnt Değişkenleri Hariç)
            //1)Console.Write("Merhaba Dünya");

            //Console.Read();


            //2)Klavyeden Girilen Ondalıklı Sayıyı Toplayan Kod Bloğu
            //double sayi1, sayi2, toplam;
            //Console.Write("Sayı1 Giriniz: ");
            //sayi1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Sayı2 Giriniz: ");
            //sayi2 = Convert.ToDouble(Console.ReadLine());
            //toplam = sayi1 + sayi2;
            //Console.Write("Girdiğiniz Değer: " + toplam);
            //Console.Read();

            //3)Char Değişkeni
            //char degisken;
            //degisken = 'a';
            //Console.Write(degisken);
            //Console.Read();

            //char deger;
            //deger = '6';
            //Console.Write(deger);

            //char secim;
            //Console.Write("Lütfen Seçimiminizi Yapınız: ");
            //secim = Convert.ToChar(Console.ReadLine());
            //Console.Write("Seçiminiz: " + secim);

            //4)Byte Değişkeni
            //byte sayi1, sayi2, toplam;
            //sayi1 = 25;
            //sayi2 = 45;
            //toplam =Convert.ToByte( sayi1 + sayi2);
            //Console.Write(toplam);

            //byte s1, s2, carpim;
            //Console.Write("Sayi1: ");
            //s1 =Convert.ToByte( Console.ReadLine());
            //Console.Write("Sayi2: ");
            //s2 = Convert.ToByte(Console.ReadLine());
            //carpim =Convert.ToByte(s1 * s2);
            //Console.Write(carpim);

            //5)Sbyte Değişkeni
            //sbyte s1;
            //s1 = 23;
            //Console.Write(s1);

            //sbyte sayi2;
            //Console.Write("Sayı 2 Giriniz :");
            //sayi2 = Convert.ToSByte(Console.ReadLine());
            //Console.Write(sayi2);

            //sbyte s1, s2, toplam;
            //Console.Write("Sayı 1 : ");
            //s1 = Convert.ToSByte(Console.ReadLine());
            //Console.Write("Sayı 2 : ");
            //s2 = Convert.ToSByte(Console.ReadLine());
            //Console.Write("Toplam : ");
            //toplam =Convert.ToSByte( s1 + s2 );
            //Console.Write(toplam);

            //6)Float Değişkeni
            //float sayi;
            //sayi = 25.5f;
            //Console.Write(sayi);

            //float s1, s2, toplam;
            //Console.Write("Sayı 1 :");
            //s1 = float.Parse(Console.ReadLine());
            //Console.Write("Sayı 2 :");
            //s2 = float.Parse(Console.ReadLine());
            //Console.Write("Toplam :");
            //toplam = s1 + s2;
            //Console.Write(toplam);

            //7)Min-Max Değişkenler
            //Console.WriteLine(byte.MaxValue);
            //Console.WriteLine(byte.MinValue);
            //Console.WriteLine(sbyte.MaxValue);
            //Console.WriteLine(sbyte.MinValue);

            //Short Değişkeni
            //short s1;
            //s1 = 655;
            //Console.Write(s1);

            //short s1, s2, toplam;
            //Console.Write("Sayı 1 :");
            //s1 =short.Parse(Console.ReadLine());
            //Console.Write("Sayı 2 :");
            //s2 = short.Parse(Console.ReadLine());
            //Console.Write("Toplam :");
            //toplam =(short)(s1 + s2);
            //Console.Write(toplam);

            //8)Ushort Değişkeni
            //ushort s1, s2, toplam;
            //Console.Write("Sayı 1 :");
            //s1 =ushort.Parse(Console.ReadLine());
            //Console.Write("Sayı 2 :");
            //s2 = ushort.Parse(Console.ReadLine());
            //Console.Write("Toplam :");
            //toplam =(ushort)(s1 + s2);
            //Console.Write(toplam);

            //9)Decimal Değişkeni
            //decimal s1, s2, Fark;
            //s1 = 67;
            //s2 = 100;
            //Fark = s2 - s1;
            //Console.Write(Fark);

            //decimal kenar, alan, cevre;
            //Console.Write("kenarı giriniz: ");
            //kenar =Convert.ToDecimal (Console.ReadLine());
            //Console.Write("Alan: ");
            //alan = kenar * kenar;
            //Console.Write(alan);
            //Console.Write("Çevre : ");
            //cevre = 4 * kenar;
            //Console.Write(cevre);

            //decimal s1;
            //s1 = 67.98m;
            //Console.Write(s1);

            //10)Bool değişkeni
            //bool durum;
            //durum = true;
            //Console.Write("Sınavı Geçti mi? ");
            //Console.Write(durum);

            //bool uyemi;
            //Console.Write("Kullanıcı Sisteme Üye mi: ");
            //uyemi =Convert.ToBoolean(Console.ReadLine());
            //Console.Write("Sisteme Üye mi: ");
            //Console.Write(uyemi);

            //Console.Read();

            //Değişkenler Not Kısmı:
            //(Int16 Int32 Int64) = int
            //Read = sekmeyi kapatmamak için
            //ReadLine = klavye Girişi(sadece string diğerleri için dönüşüm uygulanır)
            //Char = 1 karakter üzerinde etkilidir(tek tırnak işareti kullanılır şifre çözmede kullanılır)
            //byte = 0 - 255 arasındaki tam sayılar
            //sbyte = -128 - 127 arasındaki tam sayılar
            //float = ondalık sayılar (24.9f)(float.parse)
            //double = ondalıklı sayılar (24.9)
            //decimal = ondalıklı sayılar (24.9m)
            //short = -32768 - 32767 arası tam sayılar(short.parse)(short)
            //ushort = 0 - 65535 arası tam sayılar(ushort.parse)(ushort)
            //bool = true false değişkenleri
            //dönüşüm için anahtar kelime convert
            //decimal>double>float

            //*****Karar Yapıları*****
            //1)İf ve Else Yapısı("Süslü Parentez kullanalır")
            //string sehir;
            //Console.Write("Şehir Adı: ");
            //sehir = Console.ReadLine();
            //if (sehir == "Adana")
            //{
            //    Console.Write("Doğru Şehir");
            //}
            //else
            //{
            //    Console.Write("Yanlış Şehir");
            //}

            //2)Öğrenci Sınav Notu Uygulaması
            //int Sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //Sayi =Convert.ToInt16 (Console.ReadLine());

            //if (Sayi == 23)
            //{
            //    Console.Write("Sayı Doğru Girildi");
            //}
            //else
            //{
            //    Console.Write("Sayı Yanlış Girildi");
            //}

            //Console.WriteLine("Elektrik Devreleri");
            //int s1, s2, ort;
            //Console.Write("1.Sınavı Giriniz : ");
            //s1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("1.Sınav Notunuz : " + s1);
            //Console.Write("2.Sınavı Giriniz : ");
            //s2 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("2.Sınav Notunuz : " + s2);
            //ort = (s1 + s2) / 2;
            //Console.WriteLine("Ortalamanız : " + ort);

            //if (ort >= 50)
            //{
            //    Console.Write("-Dersi Geçtiniz");
            //}
            //else
            //{
            //    Console.Write("-Dersten Kaldınız");
            //}

            //3)Karar Yapıları ile Ve-Veya Operatörlerinin Kullanımı
            //String KullanıcıAdı, Sifre;
            //Console.Write("Kullanıcı Adını Giriniz: ");
            //KullanıcıAdı = Console.ReadLine();
            //Console.Write("Şifreyi Giriniz: ");
            //Sifre = Console.ReadLine();

            //if (KullanıcıAdı == "admin" & Sifre == "123")
            //{
            //    Console.Write("Giriş Yaptınız");
            //}
            //else
            //{
            //    Console.Write("Kullanıcı Adı veya Şifre Hatalı");
            //}

            //4)"Eşit Değilse" Operatörü ile Karar Yapıları
            //Char karakter;
            //Console.Write("Karakteri Giriniz: ");
            //karakter = Convert.ToChar(Console.ReadLine());

            //if (karakter != 'a')
            //{
            //    Console.WriteLine("Tebrikler a harfini girmediniz");
            //}
            //else
            //{
            //    Console.WriteLine("Maalesef a harfini girdiniz");
            //}

            //5)Birden Fazla if Bloğu Kullanımı
            //int s1, s2, ort;
            //Console.Write("1.Sınavı Giriniz: ");
            //s1 =Convert.ToInt16( Console.ReadLine());
            //Console.Write("2.Sınavı Giriniz: ");
            //s2 = Convert.ToInt16(Console.ReadLine());
            //ort = (s1 + s2) / 2;
            //Console.Write("Ortalamanız: " + ort);

            //if (ort <= 49.99)
            //{
            //    Console.Write("-Vasat");
            //}
            //if (ort >= 50 & ort < 65)
            //{
            //    Console.Write("-Orta");
            //}
            //if (ort >= 65 & ort < 75)
            //{
            //    Console.Write("-İyi");
            //}
            //if (ort >= 75 & ort < 85)
            //{
            //    Console.Write("-Çok İyi");
            //}
            //if (ort >= 85 & ort <= 100)
            //{
            //    Console.Write("-Mükemmel");
            //}

            //6)Bilgi Yarışması Projes
            //Toplam 2 soru
            //4 şık olacak
            //diğer soruya geçmek için doğru cevap gerekiyor
            //yanlış cevap verilince yarışma sona erer

            //int soru = 1;
            //string cevap;
            //if(soru == 1)
            //{
            //    Console.WriteLine("Türkiyenin Başkenti Neresidir?");
            //    Console.WriteLine();
            //    Console.WriteLine("A) İstanbul");
            //    Console.WriteLine("B) Ankara");
            //    Console.WriteLine("C) Balıkesir");
            //    Console.WriteLine("D) İzmir");
            //    Console.Write("Cevabınız: ");
            //    cevap = Console.ReadLine();
            //    if (cevap == "B" | cevap == "b")
            //    {
            //        soru = soru + 1;
            //    }
            //    else
            //    {
            //        Console.Write("Cevap Yanlış Toplam Puanınız : 0");
            //    }
            //}
            //if (soru == 2)
            //{
            //    Console.WriteLine("Cumhuriyet Kaç Yılında İlan Edilmiştir?");
            //    Console.WriteLine();
            //    Console.WriteLine("A) 1920");
            //    Console.WriteLine("B) 1921");
            //    Console.WriteLine("C) 1292");
            //    Console.WriteLine("D) 1923");
            //    Console.Write("Cevabınız: ");
            //    cevap = Console.ReadLine();
            //    if (cevap == "D" | cevap == "d")
            //    {
            //        Console.Write("Kazandınız");
            //    }
            //    else
            //    {
            //        Console.Write("Cevap Yanlış Toplam Puanınız : 1");
            //    }
            //}

            //7)Switch Case ile Plaka-Şehir Uygulaması
            //byte plaka;
            //Console.Write("Lütfen Plakayı Giriniz: ");
            //plaka = Convert.ToByte(Console.ReadLine());

            //switch (plaka)
            //{
            //    case 1:Console.Write("Merhaba Adana");
            //        break;
            //    case 2:Console.Write("Merhaba Adıyaman");
            //        break;
            //    case 3:Console.Write("Merhaba Afyon");
            //        break;
            //    default:Console.Write("Henüz Bu Şehir Bilgisi Eklenmedi");
            //        break;
            //}

            //8)Switch Case ile String Değişkenlerin Kullanımı(Mevsim Uygulaması)
            //string mevsim;
            //Console.Write("Lütfen Mevsimi Giriniz: ");
            //mevsim = Console.ReadLine();

            //switch (mevsim)
            //{
            //    case "yaz":Console.WriteLine("Haziran-Temmuz-Ağustos");
            //        break;
            //    case "ilkbahar":Console.WriteLine("Mart-Nisan-Mayıs");
            //        break;
            //    case "sonbahar":Console.WriteLine("Eylül-Ekim-Kasım");
            //        break;
            //    case "kış":Console.WriteLine("Aralık-Ocak-Şubat");
            //        break;
            //    default:Console.WriteLine("Hatalı Mevsim Girişi");
            //        break;
            //}
            //Console.Read();

            //Karar Yapıları Notlar:
            //if(şart) ve else
            //syntax(Yazım Kuralı) yapısı
            //if ve elsede süslü parantez kullanılır
            //Operatörler:
            //= atama
            //== eşit mi
            //> büyük mü
            //< kuçük mü
            //>= büyük veya eşit mi
            //<= küçük veya eşit mi
            //!= eşit değilse
            //& ve
            //| veya
            //% mod
            //switch case(Dallanma Fazla Olursa(Karar Yapısı Alt Başlığı))
            //swicth(deger) case 1:işlemler break; default:işlemler(Süslü Parantez Kullanılır)


            //*****Döngüler*****

            //1)Örnek For Döngüsü Kullanımı
            //int i;

            // for (i=1; i<=10; i++)
            // {
            //     Console.WriteLine("Merhaba Dünya");
            // }
            // Console.Read();

            //int i;

            //for(i=1; i<11; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i;

            //for (i=1;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i;

            //for (i=1;i<=100;i+=1)
            //{
            //    Console.WriteLine(i + " Merhaba Dünya");
            //}

            //2)Döngü İçinde Karar Yapısı Kullanımı
            //int sayi = 24 % 9;
            //Console.WriteLine(sayi);

            //int sayi;
            //Console.WriteLine("Sayıyı Giriniz: ");
            //sayi=int.Parse(Console.ReadLine());

            //if(sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çiftir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir");
            //}

            //for(int i = 1; i <= 20; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //3)Algoritmik Soru Girilen Sayının Pozitif Tam Bölenlerini Bulma
            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi = Convert.ToInt16(Console.ReadLine());

            //for(int i = 1; i <= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //4)Algoritmik Mülakat Sorusu
            //Bir Bakteri var her saatin sonunda ikiye bölünüyor(yani 1 2 4 8 16)

            //int bakteri = 1;
            //for(int i=1; i <= 24; i++)
            //{
            //    bakteri = bakteri * 2;
            //    Console.WriteLine(bakteri);
            //}

            //5)Ardışık Sayılarla İşlemler

            //int toplam = 0;
            //for(int i =1; i <= 5; i++)
            //{
            //    toplam = toplam + i;
            //    Console.WriteLine(toplam); (artış mitarını görürüz)

            //}
            //Console.WriteLine(toplam); (son halini görürüz)

            //5 faktöriyel
            //int faktoriyel = 1;
            //for(int i = 5; i >= 1 ; i--)
            //{
            //    faktoriyel = faktoriyel * i;;
            //}
            //Console.WriteLine(faktoriyel);

            //6)While Döngüsü
            //int sayac = 1;
            //while (sayac <= 10)
            //{
            //    Console.WriteLine("Merhaba");
            //    sayac++;
            //}

            //int sayac = 1;
            //while (sayac <= 20)
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;


            //int sayac = 1;
            //int toplam = 0;
            //while (sayac <= 10)
            //{
            //    toplam = toplam + sayac;
            //    sayac++;

            //}
            //Console.WriteLine(toplam);

            //7)Do While Döngüsü
            //int sayi = 1;
            //do
            //{
            //    sayi++;
            //    Console.WriteLine(sayi);
            //}
            //while (sayi <= 10);
            //Console.Read();

            //Döngüler Not;
            //Döngüler: for while do-while foreach
            //for(baslangıc(i=1);bitiş(i<=10);miktar(i++)){işlemler}
            //while(sart){işlemler(sayi++)} 
            //do{işlemler(sayi++)}while(sart);


        }
    }
}
