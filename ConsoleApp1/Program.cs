using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 tane not alınır. Bu notların ortalamasını hesaplayıp ekrana yazdıran bir program yazdırır. Eğerki not 80 - 100 arasında ise A+, 60-80 arasındaysa A, 40-60 arasındaysa A-, 0-40 arasındaysa F yazdırır.
            Console.WriteLine("Lütfen 3 tane not giriniz:");
            int birinciNot = Convert.ToInt32(Console.ReadLine());
            int ikinciNot = Convert.ToInt32(Console.ReadLine());
            int ucuncuNot = Convert.ToInt32(Console.ReadLine());
            int ortalama = (birinciNot + ikinciNot + ucuncuNot) / 3;
            Console.WriteLine("Ortalamanız: " + ortalama);
            if (ortalama >= 80 && ortalama <= 100)
            {
                Console.WriteLine("Harf Notunuz: A+");
            }
            else if (ortalama >= 60 && ortalama < 80)
            {
                Console.WriteLine("Harf Notunuz: A");
            }
            else if (ortalama >= 40 && ortalama < 60)
            {
                Console.WriteLine("Harf Notunuz: A-");
            }
            else if (ortalama >= 0 && ortalama < 40)
            {
                Console.WriteLine("Harf Notunuz: F");
            }
            else
            {
                Console.WriteLine("Geçersiz not girdiniz.");
            }
        }
    }
}
