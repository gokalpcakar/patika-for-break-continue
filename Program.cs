using System;

namespace patika_for_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            // ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 1; i <= sayac; i++)
            {
                
                if(i % 2 == 1){
                    Console.WriteLine(i);
                }
            }

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if(i % 2 == 1){
                    tekToplam += 1; // tekToplam = tekToplam + 1;
                }else{
                    ciftToplam += 1; // ciftToplam = ciftToplam + 1;
                }
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            // break, continue

            for (int i = 1; i < 10; i++)
            {
                if(i == 4){
                    break;
                }

                Console.WriteLine(i);
            }

            for (int i = 1; i < 10; i++)
            {
                if(i == 4){
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
