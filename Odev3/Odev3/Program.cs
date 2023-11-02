using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    internal class Program : Fonksiyonlar
    {
        static void Main(string[] args)
        {
            Fonksiyonlar fonksiyonlar = new Fonksiyonlar();            
           
            bool cikis = false;

            while (cikis == false)
            {
                liste();
                int islem = Convert.ToInt32(Console.ReadLine());

                if (islem == 1)
                {
                    Console.Write("Tabanı giriniz:");
                    double taban = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Yüksekliği giriniz:");
                    double yukseklik = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hipotenüs:{0}", fonksiyonlar.Hipotenüs(taban, yukseklik));                    
                }
                else if (islem == 2)
                {
                    Console.Write("Tabanı giriniz:");
                    double taban1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Yüksekliği giriniz:");
                    double yukseklik1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Üçgenin Alanı :{0}", fonksiyonlar.UcgeninAlani(taban1, yukseklik1));
                }
                else if (islem == 3)
                {
                    Console.Write("Dairenin yarıçapını giriniz:");
                    double daire = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dairenin Alanı:{0}", fonksiyonlar.DaireninAlani(daire));
                }
                else if (islem == 4)
                {
                    Console.Write("Tabanı giriniz:");
                    double taban2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Yüksekliği giriniz:");
                    double yukseklik2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dikdörtgenin Alanı:{0}", fonksiyonlar.DikdortgeninAlani(taban2, yukseklik2));
                }
                else if (islem == 5)
                {
                    Console.Write("Asal olup olmadığını kontrol etmek istediğiniz sayıyı giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    fonksiyonlar.AsalSayiMi(sayi);
                }
                else if (islem == 6)
                {
                    Console.Write("Faktöryelini bulmak istediğiniz sayıyı giriniz:");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} sayısının faktöryeli:{1}", sayi2, fonksiyonlar.Faktoryel(sayi2));
                }
                else if (islem == 7)
                {
                    Console.Write("Pozitif  ya da negatif  olduğunu öğrenmek istediğiniz sayıyı giriniz:");
                    int sayi3 = Convert.ToInt32(Console.ReadLine());
                    fonksiyonlar.PozitifMiNegatifMi(sayi3);
                }
                else if (islem == 8)
                {
                    Console.WriteLine("Çıkmak istediğinize emin misiniz y/n");
                    char durum = Convert.ToChar(Console.ReadLine());
                    if (durum == 'y' || durum == 'Y')
                    {
                        cikis = true;
                    }
                    else if (durum == 'n')
                    {
                        cikis = false;
                    }
                    else
                    {
                        Console.WriteLine("Hatalı bir seçim yaptınız lütfen tekrar seçiniz.");
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı seçim yaptınız lütfen tekrar seçiniz !!");
                }
            }
                    
        }

        static void liste()
        {
            Console.WriteLine("\n1.Hipotenüs Bulma\n2.Üçgenin Alanı\n3.Dairenin Alanı\n4.Dikdörtgenin Alanı\n5.Asal Sayı Kontrol\n6.Faktöryel Hesaplama\n7.Pozitif Mi - Negatif Min\n8.Çıkış");
            Console.Write("\nİsleminizi seciniz: ");
        }
    }
}
