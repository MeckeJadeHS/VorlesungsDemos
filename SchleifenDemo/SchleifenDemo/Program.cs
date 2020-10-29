using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchleifenDemo
{
    class Program
    {
        static Boolean debugging = false;

        /// <summary>
        /// Implementerung der Summe der natürlichen Zahlen bis N durch eine while Schleife
        /// </summary>
        /// <param name="n">die natürliche Zahl, bis zu welcher die Summe gebildet werden soll</param>
        /// <returns></returns>
        static int Sum_A_while(int n)
        {
            int res = 0;
            int ii = 0;

            while (ii <= n)
            {
                // res = res + ii;
                res += ii;
                ii++;
                // ii += 2;

                if (debugging) Console.WriteLine("> " + res + " + " + ii );
            }

            return res;
        }

        /// <summary>
        /// Implementerung der Summe der natürlichen Zahlen bis N durch eine for Schleife
        /// </summary>
        /// <param name="n">die natürliche Zahl, bis zu welcher die Summe gebildet werden soll</param>
        /// <returns></returns>
        static int Sum_C_for(int n)
        {
            int res = 0;

            for (int ii = 0; ii <= n; ii++)
            {
                res += ii;
                if (debugging) Console.WriteLine("> " + res + " + " + (ii +1));
            }

            return res;
        }

        /// <summary>
        /// Implementerung der Summe der natürlichen Zahlen bis N durch eine while Schleife - eine weitere Variante
        /// </summary>
        /// <param name="n">die natürliche Zahl, bis zu welcher die Summe gebildet werden soll</param>
        /// <returns></returns>
        static int Sum_B_while2(int m)
        {
            int res = 0;

            while (m > 0)
            {
                res += m;
                if (debugging) Console.WriteLine("> " + res + " + " + (m-1) );
                m--;
            }

            return res;
        }

        /// <summary>
        /// Implementerung der Summe der natürlichen Zahlen bis N durch eine Rekursion
        /// </summary>
        /// <param name="n">die natürliche Zahl, bis zu welcher die Summe gebildet werden soll</param>
        /// <returns></returns>
        static int Sum_D_rek(int m)
        {
            int res = 0;

            if (m > 0)
            {
                if (debugging) Console.WriteLine("Pre > " + res + "   m: " + m);
                res = m + Sum_D_rek(m - 1);
                if (debugging) Console.WriteLine("Post> " + res + "   m: " + m );
            }

            return res;
        }

        /// <summary>
        /// Implementerung der Summe der natürlichen Zahlen bis N durch eine do-while Schleife
        /// </summary>
        /// <param name="n">die natürliche Zahl, bis zu welcher die Summe gebildet werden soll</param>
        /// <returns></returns>
        static int Sum_E_doWhile(int m)
        {
            int res = 0;
            int ii = 0;
            do
            {
                ii++;
                if (debugging) Console.WriteLine("> " + res + " + " + ii);
                res += ii;

            } while (ii < m);

            return res;
        }

        static int Sum_X(int m)
        {
            int res = 0;

            return res;
        }


        #region Spickzettel
        /*
        static int Summe_while1_(int n)
        {
            int sum = 0;
            int ii = 1;

            while (ii <= n)
            {
                sum = sum + ii;
                ii++;  // ii = ii + 1;
            }
            return sum;
        }

        static int Summe_while2_(int n)
        {
            int sum = 0;

            while (n > 0)
            {
                sum = sum + n;
                n = n - 1;
            }
            return sum;
        }

        static int Summe_for_(int n)
        {
            int sum = 0;

            for (int ii = 0; ii <= n; ii++)
            {
                sum += ii; // sum = sum + ii;
            }
            return sum;
        }

        static int Summe_rekursiv_(int n)
        {
            if (n > 0)
            {
                return n + Summe_rekursiv_(n - 1);

            }
            return 0;
        }
        */
        #endregion

        private static void SchleifenDemo()
        {
            // Eingabe 
            Console.Write("Eingabe N: ");
            int zahl_n = Convert.ToInt32(Console.ReadLine());


            // Ausgabe
            Console.WriteLine("Ergebnis A: " + Sum_A_while(zahl_n) );
            Console.WriteLine("Ergebnis B: " + Sum_B_while2(zahl_n) );
            Console.WriteLine("Ergebnis C: " + Sum_C_for(zahl_n) );
            Console.WriteLine("Ergebnis D: " + Sum_D_rek(zahl_n));
            Console.WriteLine("Ergebnis E: " + Sum_E_doWhile(zahl_n) );

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            SchleifenDemo();
        }


    }
}
