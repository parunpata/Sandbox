namespace Sandbox
{
    class GeschlechtPerson : Person
    {
        public Geschlecht Geschlecht { get; set; }

        public GeschlechtPerson() {}
        public GeschlechtPerson(string vorname, string nachname, double kontostand, Geschlecht geschlecht) 
            : base(vorname, nachname, kontostand)
        {
            this.Geschlecht = geschlecht;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
