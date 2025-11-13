using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("ATM'ye Hoşgeldiniz!");
            Console.WriteLine("İşlem Türü: 1- Bakiyenizi Görüntüleyin. 2- Para çekme işleminizi gerçekleştirin. 3- Para yatırma işleminizi gerçekleştirin. 0- Sistemden çıkış yapınız. ");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:");
            string secim = Console.ReadLine();

            if(secim == "1")
            {
                Console.WriteLine("Bakiyeniz: " + bakiye + " TL");
                Console.ReadLine();
            }
            else if(secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                int cekilenTutar = Convert.ToInt32(Console.ReadLine());
                if(cekilenTutar <= bakiye)
                {
                    Console.WriteLine("Yeni bakiyeniz: " + (bakiye - cekilenTutar) + " TL");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Bakiyeden fazla para çekilemez!");
                    Console.ReadLine();
                }
            }
            else if(secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                int yatirilanTutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz: " + (bakiye + yatirilanTutar) + " TL");
                Console.ReadLine();
            }
            else if(secim == "0")
            {
                Console.WriteLine("Sistemden çıkış yapılıyor. İyi günler!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Geçersiz işlem seçimi!");
                Console.ReadLine();
            }
        }
    }
}
