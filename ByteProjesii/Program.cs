
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProjesii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // byte 0 ile 255 arasındaki değerleri alır.
            byte x = 5;
            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;
            Console.WriteLine(x);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
        }
    }
}
