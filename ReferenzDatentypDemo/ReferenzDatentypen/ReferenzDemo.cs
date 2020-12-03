using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenzDatentypen
{
    class ReferenzDemo
    {
		ReferenzDemo()
		{
			// Variablen initialisieren
			int zahl = 1;
			int[] zahlArray = new int[] { 1 };

			// Addiere 10 
			addiere10zuInt(zahl);
			addiere10zuIntArray(zahlArray);

			Console.WriteLine("Zahl:                 " + zahl);
			Console.WriteLine("Array mit einer Zahl: " + zahlArray[0]);
			Console.ReadKey();
        }

        private static void addiere10zuIntArray(int[] zahlArray)
        {
                zahlArray[0] += 10; 
        }

        private static void addiere10zuInt(int zahl)
        {
            zahl += 10;
        }

        static void Main(string[] args)
		{
			ReferenzDemo demo = new ReferenzDemo();
		}

	}
}
