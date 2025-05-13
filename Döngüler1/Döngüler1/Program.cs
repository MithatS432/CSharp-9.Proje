using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç sayı girmek istiyorsunuz? ");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];

            // for döngüsü: kullanıcıdan veri alma
            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nTek sayılar (continue ile atlandı):");
            foreach (int sayi in sayilar)
            {
                if (sayi % 2 == 0)
                    Console.WriteLine($"Çift: {sayi}");
                else
                    continue; // tekleri atla
            }

            Console.WriteLine("\nİlk 3 sayıyı yazdır (break ile sınırlı):");
            int sayac = 0;
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
                sayac++;
                if (sayac == 3)
                    break;
            }
        }
    }
}
