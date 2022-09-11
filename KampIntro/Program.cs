using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "utku";
            int sayi = 7;

            Console.WriteLine(isim);
            Console.WriteLine(sayi);

            double dolardun = 17.55;
            double dolarbugun = 18.25;

            if (dolarbugun<dolardun)
            {
                Console.WriteLine("azalış butonu");
            }

            else if (dolarbugun>dolardun)
            {
                Console.WriteLine("artış butonu");
            }

            else
            {
                Console.WriteLine("eşit butonu");
            }

            bool sistemgiriskontrol = true;

            if (sistemgiriskontrol == true)
            {
                Console.WriteLine("ayarlar arayüz butonu");
            }
            else
            {
                Console.WriteLine("çıkış yap butonu");
            }

            Console.ReadLine();
        }
    }
}
