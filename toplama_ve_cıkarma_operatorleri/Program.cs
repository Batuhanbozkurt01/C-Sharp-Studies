using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplama_ve_cıkarma_operatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 48;
            int y = 62;
            int z = 39;
            int t = 75;

            int toplam = (x + y + z) - t;

            Console.WriteLine(toplam);
            Console.ReadLine();
        }
    }
}
