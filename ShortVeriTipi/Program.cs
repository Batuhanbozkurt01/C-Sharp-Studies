using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortVeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // short değişkeni -32768 ile 32767 arasındaki değerleri depolayabilmektedir. Depolanan yer: RAM -> Random Access Memory

            short birinci_degisken = -55;
            short ikinci_degisken = 6655;
            short max_deger = short.MaxValue;
            short min_deger = short.MinValue;

            Console.WriteLine(birinci_degisken);
            Console.WriteLine(ikinci_degisken);
            Console.WriteLine(max_deger);
            Console.WriteLine(min_deger);
            Console.ReadLine();
        }
    }
}
