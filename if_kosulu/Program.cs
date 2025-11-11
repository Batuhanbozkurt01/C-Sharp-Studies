using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_kosulu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not = 70;

            if (not > 60)
            {
                Console.WriteLine("Geçtiniz");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Kaldınız");
                Console.ReadLine();
            }
        }
    }
}
