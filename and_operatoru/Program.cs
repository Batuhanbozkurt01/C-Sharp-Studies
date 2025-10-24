using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 10;
            int z = 15;

            bool islem = (x == y) && (y < z);
            Console.WriteLine("İşlem sonucu: " + islem);
            Console.ReadLine();
        }
    }
}
