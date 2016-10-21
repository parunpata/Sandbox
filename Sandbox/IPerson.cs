using System.Collections.Generic;

namespace Sandbox
{
    interface IPerson
    {
        IEnumerable<string> Geräte { get; set; }
        double Kontostand { get; set; }
        string Nachname { get; set; }
        string Vorname { get; set; }

        void ZeigeGeräte();
    }
}