using System;
using System.Collections.Generic;

namespace Sandbox
{
    class Person : IPerson
    {
        private double kontostand;
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public double Kontostand
        {
            get { return kontostand; }
            set
            {
                if (value <= 1000 || value <= -1000)
                    kontostand = value;
            }
        }
        public IEnumerable<string> Geräte { get; set; }
        public IEnumerable<int> Ziffern { get; set; }
        public Person()
        {

        }
        public Person(string vorname, string nachname, double kontostand)
        {
            this.Vorname = vorname;
            this.Nachname = nachname;
            this.Kontostand = kontostand;
        }

        public IEnumerable<int> ErstelleZiffern(int z)
        {
            for(int i = 0; i < z; i++)
            {
                yield return i;
            }
        }

        public void ZeigeGeräte()
        {
            Console.WriteLine("Liste der Geräte:");
            foreach (var item in Geräte)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
            return String.Format($"{Vorname} {Nachname}");
        }
    }
}
