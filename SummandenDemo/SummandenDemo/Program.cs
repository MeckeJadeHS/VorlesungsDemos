using System;

namespace SummandenDemo
{
    public class Program
    {
        int zweiterSummand = 2;     // Globale Variable

        public Program()
        {
            int ersterSummand = 3;                      // Lokale Variable
            Console.Write("Summand eingeben: ");        // Eingabeaufforderung
            String inputStr = Console.ReadLine();       // Einlesen der Zeichenkette
            ersterSummand = Convert.ToInt32(inputStr);  // Konvertieren Zeichenkette in GanzZahl

            int summe = Plus(ersterSummand, zweiterSummand); // Funktionsaufruf mit den zwei Summanden
            Console.WriteLine("Ergebnis: " + summe);    // Ausgabe
        }

        public int Plus(int x, int y, int z = 0)        // Methode mit Signatur: 2 Paramerer + 1 optionaler Parameter
        {
            return x + y + z;                           // Operationen und Rückgabe
        }

        public int Plus(int x, int y)                   // Methode mit Signatur: 2 Paramerer
        {
            return Plus(x, y, 0);                       // Operationen und Rückgabe

        }

        static void Main(string[] args)
        {
            new Program();      // Erzeugen eines Objektes von der Klasse "Program"
            Console.ReadKey();  // Taste drücken um die Anwendung zu beenden
        }
    }
}
