using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             int veri tipi -2147483648 ile 2147483647 arasındaki değerleri alabilmektedir.

            8 bit = 1 byte
            1024 byte = 1KB
            1024 KB = 1MB
            1024MB = 1GB
            1024GB = 1TB
            1024TB = 1PB
             */
            int birinciDegisken = 55555555;
            int ikinciDegisken = -60606060;
            int maxDeger = int.MaxValue;
            int minDeger = int.MinValue;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
                
        }
    }
}
