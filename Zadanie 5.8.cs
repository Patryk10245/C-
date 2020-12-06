using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._8
{
    class Program
    {
        static int Metoda(int x, int wynik)
        {
            while (x != 0)
            {
                wynik = wynik + (x % 10);
                x = x / 10;
            }
            return wynik;
        }

        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Podaj x: ");
            x = int.Parse(Console.ReadLine());
            int wynik1 = 0;
            Console.WriteLine();
            Console.WriteLine("Suma cyfr podanej liczby wynosi: {0}", Metoda(x, wynik1));
            Console.ReadKey();
        }
    }
}
