using System;

namespace KreisDemo
{
    /// <summary>Formale Beschreibung eines Kreises</summary>
    class Kreis
    {
        private double x;
        private double y;
        private double r;

        /// <summary>Konstruktor von einem Kreis - 
        /// diese Methode wird aufgerufen sowie ein Objekt vom Typ Kreis erzeugt wird.
        /// Ohne Parameter werden alle Eigenschaften (Position mit 0 und Radius mit 1) initialisiert.
        /// </summary>
        public Kreis()
        {
            x = 0;
            y = 0;
            r = 1;
        }

        /// <summary>Konstruktor von einem Kreis - 
        /// diese Methode wird aufgerufen sowie ein Objekt vom Typ Kreis erzeugt wird.
        /// Mit den Parametern x und y wird die Position mit den Werten initialisiert.
        /// <param name="x">the new x-coordinate.</param>
        /// <param name="y">the new y-coordinate.</param>
        public Kreis(double x, double y)
        {
            this.x = x;
            this.y = y;
            r = 1;
        }

        /// <summary>Diese Metghode setzt den Mittelpunkt mit den gegebenen Koordinaten.</summary>
        /// <param name="local_x">the new x-coordinate.</param>
        /// <param name="local_y">the new y-coordinate.</param>
        public void setMittelpunkt(double local_x, double local_y)
        {
            x = local_x;
            y = local_y;
        }

        /// <summary>Ändern des Radius eines Kreises.</summary>
        /// <param name="local_r">Neuer Wert für den Radius</param>
        internal void setRadius(double local_r)
        {
            r = local_r;
        }

        /// <summary>Diese Methode liefert die Fläche des Kreises.</summary>
        public double getFlaeche()
        {
            double res;
            res = (Math.PI * Math.Pow(r, 2));
            return res;
        }

    }
}
