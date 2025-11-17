using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_yapisi_ile_olusturulan_mini_atm_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basit bir ATM uygulaması. Kullanıcı para yatırma, çekme ve bakiye sorgulama işlemlerini yapabilir.
            double bakiye = 1000.0;
            Console.WriteLine("Mini ATM Uygulamasına Hoşgeldiniz!");
            Console.WriteLine("1 - Para Yatırma");
            Console.WriteLine("2 - Para Çekme");
            Console.WriteLine("3 - Bakiye Sorgulama");
            Console.WriteLine("4 - Çıkış");
            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz (1-4): ");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                    double yatirilanTutar = double.Parse(Console.ReadLine());
                    bakiye += yatirilanTutar;
                    Console.WriteLine($"Başarıyla {yatirilanTutar} TL yatırıldı. Yeni bakiye: {bakiye} TL");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                    double cekilenTutar = double.Parse(Console.ReadLine());
                    if (cekilenTutar > bakiye)
                    {
                        Console.WriteLine("Yetersiz bakiye!");
                        Console.ReadLine();
                    }
                    else
                    {
                        bakiye -= cekilenTutar;
                        Console.WriteLine($"Başarıyla {cekilenTutar} TL çekildi. Yeni bakiye: {bakiye} TL");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    Console.WriteLine($"Mevcut bakiyeniz: {bakiye} TL");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Çıkış yapılıyor. İyi günler!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim! Lütfen 1-4 arasında bir sayı giriniz.");
                    Console.ReadLine();
                    break;
            }   
        }
    }
}
