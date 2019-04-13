using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox
{
    class Program
    {
        delegate void Unifunc();
        
        static void Main(string[] args)
        {
            try
            {
                List<string> geräte = new List<string>() { "Laptop", "Smartphone", "Tablet", "TV" };
                var emre = new GeschlechtPerson("Emre", "Ögretmen", 1500, Geschlecht.Männlich);
                emre.Geräte = geräte;
                //emre.ZeigeGeräte();
                Unifunc unifunc = emre.ZeigeGeräte;
                unifunc();
                emre.Kontostand = 600;
                Console.WriteLine(emre.Nachname.SquareOfLength());
                emre.Ziffern = emre.ErstelleZiffern(4);
                Console.WriteLine(emre);

                emre.Geräte = from g in emre.Geräte
                                where g.StartsWith("T")
                                select g;

                Func<string, int> delLength = (str) => str.Length;
                Func<string, int> delLength2 = (str) =>
                {
                    return str.SquareOfLength();
                };
                var text = delLength(emre.Nachname);
                Console.WriteLine(text);
                Console.WriteLine(delLength2(emre.Nachname));
                emre.ZeigeGeräte();
                foreach(var z in emre.Ziffern)
                {
                    Console.WriteLine(z);
                }

                #region Datenspeicher
                Datenspeicher < double > ds = new Datenspeicher<double>();
                ds.Speichern(emre.Kontostand);
                double kontostand = ds.Auslesen();
                Console.WriteLine($"Speicher enthält Wert {kontostand}");
                #endregion
                    
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
