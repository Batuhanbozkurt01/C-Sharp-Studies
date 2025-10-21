using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // long veri tipi 9223372036854775807 ile -9223372036854775808 arasındaki değerleri alır.
            long x = 53686537645533;
            long y = -9876543210;
            long maxDeger = long.MaxValue;
            long minDeger = long.MinValue;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
