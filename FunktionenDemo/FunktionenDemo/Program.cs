using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunktionenDemo
{
    class Program
    {
        static int zweiterSummand = 2; // unschoen

        public static void FunktionenDemo()
        {
            int ersterSummand = 3;
            Console.Write("Summand eingeben: ");
            ersterSummand = Convert.ToInt32(Console.ReadLine());

            int summe;
            summe = ZweiteKlasse.Plus(ersterSummand, zweiterSummand);
            summe = ZweiteKlasse.Plus(3, 4, 5);
            summe = ZweiteKlasse.Plus(3);

            Console.WriteLine("Ergebnis: " + summe);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            FunktionenDemo();
        }
    }
}
