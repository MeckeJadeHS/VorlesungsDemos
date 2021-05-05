using System;

namespace Hochschule
{
    internal class Student
    {
        private string Vorname;
        private string Nachname;
        private string MatNr;
        private double Note;
        private double Schuhgroesse;

        public Student(string v1, string v2, string v3, double note)
        {
            this.Vorname = v1;
            this.Nachname = v2;
            this.MatNr = v3;
            this.Note = note;
        }

        internal void setzeSchuhgroesse(double v)
        {
            Schuhgroesse = v;
        }

        internal double getNote()
        {
            return Note;
        }

        public new String ToString()
        {
            return Vorname + " " + Nachname + " " + MatNr;
        }

    }
}