using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._2
{
    class Program
    {
        static int Przedzial(int a, int b, int x)
        {

            if (a < x && x < b) return 1;
            else return 0;
        }

        static void Main(string[] args)
        {
            int a, b, x;

            Console.WriteLine("Podaj 'a': ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 'b': ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj 'x': ");
            x = int.Parse(Console.ReadLine());
            if (Przedzial(a, b, x) == 0)
                Console.WriteLine("x nie nalezy do przedzialu otwartego");
            else Console.WriteLine("x NALEZY do przedzialu");
            Console.ReadKey();
        }
    }
}

