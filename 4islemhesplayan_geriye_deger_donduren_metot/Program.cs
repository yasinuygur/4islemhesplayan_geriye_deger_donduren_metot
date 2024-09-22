using _4islemhesplayan_geriye_deger_donduren_metot;

internal class Program
{
    private static void Main(string[] args)
    {
        dort_islem islem = new dort_islem();
        Console.WriteLine("1. Sayıyı giriniz: ");
        int s1 = int.Parse(Console.ReadLine());
        Console.WriteLine("2. Sayıyı giriniz: ");
        int s2 = int.Parse(Console.ReadLine());
        islem.topla(s1, s2);
        islem.cikar(s1, s2);
        islem.bol(s2, s1);
        islem.carp(s1, s2);


    }
}