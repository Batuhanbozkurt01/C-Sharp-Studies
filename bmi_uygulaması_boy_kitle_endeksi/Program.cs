using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi_uygulaması_boy_kitle_endeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan kilo ve boy bilgilerini alarak BMI hesaplayan ve kategorisini belirten uygulama.

            Console.WriteLine("Kilonuzu giriniz (örneğin 72,0 veya 57,4): ");
            double kilo = double.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("tr-TR"));

            Console.WriteLine("Boyunuzu metre cinsinden giriniz (örneğin 1,75): ");
            double boy = double.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("tr-TR"));

            double bmi = kilo / (boy * boy);

            if(bmi < 18.5)
            {
                Console.WriteLine("Zayıf");
            }
            else if(bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Normal kilolu");
                
            }
            else if(bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Fazla kilolu");
                
            }
            else
            {
                Console.WriteLine("Obez - Aşırı kilolu");
                
            }
        }
    }
}
