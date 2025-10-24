using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buyuk_kucuk_esittir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yas = 21;
            int year = 1997;
            int country_code = 90;
            int user_id = 9954;

            bool kontrol_islemi_1 = yas > 18;
            bool kontrol_islemi_2 = year <= 2000;
            bool kontrol_islemi_3 = country_code < 500;
            bool kontrol_islemi_4 = user_id >= 4800;

            Console.WriteLine("Yaşınız 18 den büyük mü? : " + kontrol_islemi_1);
            Console.WriteLine("Doğum yılınız 2000 den küçük veya eşit mi? : " + kontrol_islemi_2);
            Console.WriteLine("Ülke kodunuz 500 den küçük mü? : " + kontrol_islemi_3);
            Console.WriteLine("Kullanıcı ID niz 4800 den büyük veya eşit mi? : " + kontrol_islemi_4);
            Console.ReadLine();
        }
    }
}
