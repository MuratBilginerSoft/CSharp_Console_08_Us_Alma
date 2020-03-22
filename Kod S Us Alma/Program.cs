using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Us_Alma
{
    class Program
    {
        static int ad(int x, int y)
        {
            int carpim = 1;
            for (int i = 1; i <= y; i++)
            {
                carpim *= x;
            }
            return carpim;
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Taban Değerini Giriniz:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Üs Değerini Giriniz:");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int sonuc = ad(x, y);
            Console.WriteLine("Sonuç:" + sonuc);

            Console.ReadKey();
        }
    }
}
