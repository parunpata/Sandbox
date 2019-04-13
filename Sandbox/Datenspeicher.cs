namespace Sandbox
{
    class Datenspeicher<T> where T: new()
    {
        private T wert { get; set; }

        public void Speichern(T wert)
        {
            this.wert = wert;
        }

        public T Auslesen()
        {
            return wert;
        }

        public void Leeren()
        {
            wert = default(T);
            wert = new T();
        }
    }
}
