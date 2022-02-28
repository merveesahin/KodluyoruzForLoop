using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir

            //Console.Write("Lutfen sayi giriniz");
            //int sayac= int.Parse(Console.ReadLine());
            //for (int i = 1; i <= sayac; i++)
            {
                 //if (i%2 == 1)
                  //Console.WriteLine(i);
            }

            // 1 ile 1000 arasindaki tek ve cift sayilarin toplami
            //int TekToplam = 0;
            //int CiftToplam = 0;

            //for (int i = 0; i <= 1000; i++)
            {
                //if (i %2 == 1)
                 // TekToplam += i; // TekToplam = TekToplam + i 
                //else
                  // CiftToplam += i;

            }
            //Console.WriteLine("Tek Toplam = " + TekToplam);
            //Console.WriteLine("Cift Toplam = " + CiftToplam);

            // break- continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                  break; 
                Console.WriteLine(i);
            }
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                  continue; 
                Console.WriteLine(i);
            }
        }
    }
}
