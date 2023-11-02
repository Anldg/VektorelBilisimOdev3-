using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    internal class Fonksiyonlar
    {
        public double Hipotenüs(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public double UcgeninAlani(double taban, double yukseklik)
        {
            return (taban * yukseklik) / 2;
        }

        public double DaireninAlani(double yarıçap)
        {
            return Math.PI * Math.Pow(yarıçap, 2);
        }

        public double DikdortgeninAlani(double taban, double yukseklik)
        {
            return taban * yukseklik;
        }

        public int AsalSayiMi(int sayi)
        {
            int i;
            for (i = 2; i <= sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    Console.WriteLine("{0} sayısı asal değildir.", sayi);
                    return 0;
                }
            }
            if (i == sayi)
            {
                Console.WriteLine("{0} sayısı asaldır.", sayi);
                return 1;

            }
            return 0;
        }

        public int Faktoryel(int sayi)
        {
            int sonuc = 1;
            for (int i = 1; i <= sayi; i++)
            {
                sonuc = sonuc * i;
            }
            return sonuc;
        }

        public void PozitifMiNegatifMi(int sayi)
        {
            if (sayi < 0)
            {
                Console.WriteLine("{0} sayısı negatiftir", sayi);
            }
            else
            {
                Console.WriteLine("{0} sayısı pozitiftir", sayi);
            }
        }
    }
}
