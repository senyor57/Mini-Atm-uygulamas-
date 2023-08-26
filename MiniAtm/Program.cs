using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAtm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;

            // kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            // 1 bakiye görüntüleme
            // 2 para cekme
            // 3 para yatırma 
            // q ya basarak cıkış yapma

            Console.WriteLine("ATM ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi secin");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Bakiyeniz " + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Cekmek istediğiniz tuttarı giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan bakiyeniz " + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("bakiyeniz yetersizdir");
                    Console.ReadLine();
                }

            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı girin");
                int yatıralacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Şuanki bakiyeniz " + (bakiye + yatıralacak_tutar));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("Atm den cıkış yapılıyor...");
                Console.WriteLine("iyi günler..");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("lütfen bir işlem seciniz..");
                Console.ReadLine();
            }

        }
    }
}
