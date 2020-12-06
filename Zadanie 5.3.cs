using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._3
{
    class Program
    {
        static void Przesun(ref double[,] tabA, double[,] wek1)
        {

            int x, y;
            for (x = 0; x < 1; x++)
            {
                for (y = 0; y < 2; y++)
                {
                    tabA[x, y] = tabA[x, y] + wek1[x, y];
                }
            }
        }
        static void Main(string[] args)
        {
            double[,] A = new double[1, 2];
            Console.WriteLine("Podaj dwie początkowe współrzędne punktu A: ");
            for (int a = 0; a < 1; a++)
            {
                for (int b = 0; b < 2; b++)
                {
                    A[a, b] = double.Parse(Console.ReadLine());
                }
            }

            double[,] wek = new double[1, 2] { { 3, 2 } };
            double[,] A1 = new double[1, 2];

            int i, j;
            Console.WriteLine("Podane współrzędne: ");
            for (i = 0; i < A.GetLength(0); i++)
            {
                for (j = 0; j < A.GetLength(1); j++)
                {
                    Console.WriteLine(A[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("Współrzędne po przesunięciu:");
            Przesun(ref A, wek);
            foreach (int x in A)
                Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
