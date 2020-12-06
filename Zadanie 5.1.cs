using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5._1
{
    class Program
    {
        static double stopnie(double F)
        {
            Console.WriteLine("Temperatura wynosi:  " + (F - 32) / (1.8));
            return F;
        }

        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Podaj Temperature w stopniach Fahrenheita");
            x = double.Parse(Console.ReadLine());
            stopnie(x);
            Console.ReadKey();

        }
    }
}

