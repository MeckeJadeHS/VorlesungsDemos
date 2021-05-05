using System;

namespace Hochschule
{
    public class Hochschule
    {
        // Konstruktor
        public Hochschule()
        {
            Pruefungsamt PA = new Pruefungsamt();

            // Input
            Student S1 = new Student("Heiner", "Schreiner", "9876564", 2.7d);
            S1.setzeSchuhgroesse(42d);
            PA.Einschreibung(S1);

            Student S2 = new Student("Babsi", "Fest", "9876564", 1.0d);
            PA.Einschreibung(S2);

            Prof P1 = new Prof("Susi", "Sonnenschein", "9575");


            // Output
            Console.WriteLine("Student " + S1.ToString());
            Console.WriteLine("Note    " + S1.getNote());
            Console.WriteLine("JahrgangsSchnitt: " +  PA.getSchnitt());
            Console.ReadKey();
        }

        // Main Methode
        static void Main(string[] args)
        {
            new Hochschule();
        }

    }
}
