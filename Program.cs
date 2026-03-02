using System;
using System.Collections.Generic;
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








        }
    }
}
