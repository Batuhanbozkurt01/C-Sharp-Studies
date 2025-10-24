using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace or_operatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 5;

            bool islem = (x == y) || (y > z);
            Console.WriteLine("işlem sonucu: " + islem);
            Console.ReadLine();
        }
    }
}
