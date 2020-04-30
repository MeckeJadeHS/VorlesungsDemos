using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreisDemo
{

    class KreisControl
    {
        KreisControl() // Konstruktor
        {
            // Kreise erzeugen
            /// Objekt Instanziieren
            Kreis k1;
            k1 = new Kreis();
            Kreis k2 = new Kreis(1.0d, 2.0d);

            /// Eigenschaften setzen
            k1.setMittelpunkt(10.0d, 20);
            k2.setMittelpunkt(0, 70);
            k1.setRadius(4.0d);
            k2.setRadius(1.0d);

            // Fläche berechnen und ausgeben
            double flaecheK1 = k1.getFlaeche();
            Console.WriteLine("k1 Flaeche: " + flaecheK1);
            Console.WriteLine("k2 Flaeche: " + k2.getFlaeche());
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            new KreisControl();
        }
    }

}
