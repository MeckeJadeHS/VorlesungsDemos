using System;

namespace KreisDemo
{
    /// <summary>Formal description of a Kreis</summary>
    class Kreis
    {
        private double x;
        private double y;
        private double r;

        /// <summary>Constructor of Kreis - 
        /// this method is called as soon as the "Kreis".
        /// </summary>
        public Kreis()
        {
            x = 0;
            y = 0;
            r = 1;
        }

        /// <summary>Constructor of Kreis - 
        /// this method is called as soon as the "Kreis" object gets 
        /// created with te given parameters.</summary>
        /// <param name="v">the new x-coordinate.</param>
        /// <param name="w">the new y-coordinate.</param>
        public Kreis(double v, double w)
        {
            x = v;
            y = w;
        }

        /// <summary>This method changes the point's location to
        ///    the given coordinates.</summary>
        /// <param name="local_x">the new x-coordinate.</param>
        /// <param name="local_y">the new y-coordinate.</param>
        public void setMittelpunkt(double local_x, double local_y)
        {
            x = local_x;
            y = local_y;
        }

        /// <summary>This method changes the Kreis's radius.</summary>
        /// <param name="local_r">the new radius.</param>
        internal void setRadius(double local_r)
        {
            r = local_r;
        }

        /// <summary>This method returns the surface area of a Kreis.</summary>
        public double getFlaeche()
        {
            double res;
            res = (Math.PI * Math.Pow(r, 2));
            return res;
        }

    }
}
