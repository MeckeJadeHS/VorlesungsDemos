using System;

namespace Demo
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

    }
}
