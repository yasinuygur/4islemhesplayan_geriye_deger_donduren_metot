using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4islemhesplayan_geriye_deger_donduren_metot
{
    internal class dort_islem
    {
        public int topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam :"+sonuc);
            return sonuc;
        }

        public int carp(int sayi1, int sayi2)
        {
            int carp = sayi1*sayi2;
            Console.WriteLine("Çarpım :" + carp);
            return carp;
        }
        public double bol(double sayi1, double sayi2)
        {
            double bol = sayi1/sayi2;
            Console.WriteLine("Bölüm :"+bol);
            return bol;
        }

        public int cikar(int sayi1, int sayi2) { 
            int cikar= sayi1-sayi2;
            Console.WriteLine("Çıkar :"+cikar);
            return cikar;
        }
    }
}
