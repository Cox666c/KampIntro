using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "java";
            string kurs4 = "python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine();

            //array - dizi

            string[] kurslar = new string[] { "yazılım geliştirici yetiştirme kampı" ,
                "programlamaya başlangıç için temel kurs","java","python" };

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            Console.WriteLine();

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadLine();
        }
    }
}
