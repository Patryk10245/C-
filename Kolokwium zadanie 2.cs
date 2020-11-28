using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zadanie2
    {
        static void Main(string[] args)
        {
            bool poprawna = false;
            string x;
            int y = 0;
            bool b;
            Console.WriteLine("Prosze podać liczbe nieujemną mniejszą lub równą 10");


            while (poprawna != true)
            {
                x = Console.ReadLine();

                int.TryParse(x, out y);

                if (x != null && y <= 10 && y > 0)
                {
                    poprawna = true;
                }
                else
                {
                    Console.WriteLine("Prosze podać liczbe nieujemną mniejszą lub równą 10");
                }
            }

            Sumuj(y);
            Console.ReadKey();
        }


        static void Sumuj(int a)
        {
            int[,] tab = new int[a, a];
            string l;

            for (int i = 0; i < a; i++)
            {
                for (int k = 0; k < a; k++)
                {
                    Console.WriteLine("Podaj [{0},{1}] element tablicy 1", i, k);
                    l = Console.ReadLine();
                    tab[i, k] = int.Parse(l);
                }
                

            Console.ReadKey();
        }
    }
}