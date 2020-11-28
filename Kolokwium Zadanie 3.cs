using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz ilosc liczb ktore chcesz wprowadzic:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] table = new int[n];
            Console.WriteLine("Wprowadz liczby:");
            for (int i = 0; i < n; i++)
            {
                table[i] = Convert.ToInt32(Console.ReadLine());
            }
            int iloscParzystych = 0;
            int iloscNieparzystych = 0;

            for (int i = 0; i < n; i++)
            {
                if (table[i] % 2 == 0) iloscParzystych++;

                else iloscNieparzystych++;
            }
            Console.WriteLine("Ilosc parzystych elementów" + iloscParzystych);
            Console.WriteLine("Ilosc nieparzystych elementow: " + iloscNieparzystych);

            Console.ReadKey();
        }
    }
}

