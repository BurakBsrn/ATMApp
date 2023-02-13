using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 400000000;

            Console.WriteLine("Bakiyeniz = " + bakiye);
            Console.WriteLine("\n****İŞLEMLER****\n");
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Kart İade");

            Console.Write("\nİşlemlerinizi Seçiniz : ");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Çekmek İstediğiniz Tutarı Giriniz : ");
                    int tutar = Convert.ToInt32(Console.ReadLine());
                    if (tutar > bakiye)
                    {
                        Console.Write("Yetersiz Bakiye. Tekrar Giriniz : ");
                        tutar = Convert.ToInt32(Console.ReadLine());
                    }
                    bakiye -= tutar;
                    Console.WriteLine("Yeni Bakiyeniz = " + bakiye);
                    break;
                case 2:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    Console.Write("Yatırmak İstediğiniz Tutarı Giriniz : ");
                    tutar = Convert.ToInt32(Console.ReadLine());
                    bakiye += tutar;
                    Console.WriteLine("Yeni Bakiyeniz = " + bakiye);
                    break;
                case 3:
                    Console.WriteLine("Bakiyeniz = " + bakiye);
                    break;
                case 4:
                    Console.WriteLine("Kartınızı Almayı Unutmayınız.!!");
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem Seçtiniz. Tekrar Giriniz. ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
