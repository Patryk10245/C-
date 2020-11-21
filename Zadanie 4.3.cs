﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Ile miejsc ma miec tabela?");
            int x = int.Parse(Console.ReadLine());
            int[] tab = new int[x];
            int i = 0;
            while (i < x)
            {
                Console.WriteLine("Podaj wartość {0} miejsca w tablicy", i + 1);
                tab[i] = int.Parse(Console.ReadLine());
                i++;
            }
            int najmniejsza = tab[0];
            int najwieksza = tab[0];

            for (var y = 0; y < tab.Length; y++)
            {
                if (najmniejsza > tab[y]) { najmniejsza = tab[y]; }
                if (najwieksza < tab[y]) { najwieksza = tab[y]; }
                total += tab[y];
            }
            Console.WriteLine("Najmniejsza wartość to {0}", najmniejsza);
            Console.WriteLine("Najwieksza wartość to {0}", najwieksza);
            Console.WriteLine("Średnia wartość jest równa {0}", total / tab.Length);
            Console.ReadKey();
        }
       
    }
}
