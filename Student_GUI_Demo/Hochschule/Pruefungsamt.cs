using System;
using System.Collections.Generic;

namespace Hochschule
{
    internal class Pruefungsamt
    {
        List<Student> studs = new List<Student>();

        public Pruefungsamt()
        {
        }

        public double getSchnitt()
        {
            int ii = 0;
            double sum = 0;
            foreach(Student s in studs)
            {
                ii++;
                sum += s.getNote();
            }
            return sum / ii;
        }

        internal void Einschreibung(Student s1)
        {
            studs.Add(s1);
        }
    }
}