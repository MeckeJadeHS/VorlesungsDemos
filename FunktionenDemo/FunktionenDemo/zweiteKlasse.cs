using System;

namespace FunktionenDemo
{
    class ZweiteKlasse
    {
        static int zweiterSummand = 2;

        public static int Plus(int v1, int v2, int v3 = 0)
        {
            return v1 + v2 + v3;
        }

        public static int Plus(int summand1)
        {
            int res = 0;
            res = summand1 + zweiterSummand;
            return res;
        }

        internal static void intAusgabe(string v1, int v2)
        {
            allgemeineAusgabe(v1, v2);
        }

        internal static void intAusgabe(int v1, string v2)
        {
            allgemeineAusgabe(v2, v1);
        }

        private static void allgemeineAusgabe(string v1, int v2)
        {
            Console.WriteLine(v1 + v2);
        }


    }
}
