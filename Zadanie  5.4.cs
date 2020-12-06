using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._4
{
    class Program
    {
        static int[] PoMnozeniu(int mnoznik1, int[] tab)
        {

            int[] tab1 = { 1, 4, 6, 8, 2 };

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = tab1[i] * mnoznik1;
                Console.WriteLine(tab1[i]);
            }
            return tab1;
        }

        static void Main(string[] args)
        {
            int[] tab2 = new int[4];
            Console.WriteLine("Podaj mnoznik");
            int mnoznik;
            mnoznik = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Po pomnozeniu: ");
            int[] tab = PoMnozeniu(mnoznik, tab2);

            Console.ReadKey();
        }

    }
}
