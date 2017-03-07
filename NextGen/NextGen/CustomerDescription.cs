namespace NextGen
{
    public class CustomerDescription
    {
        public int kundeNr { get; }
        public string navn { get; }
        public int rabatSats { get; }

        public CustomerDescription(int knr, string n, int rabat)
        {
            this.kundeNr = knr;
            this.navn = n;
            this.rabatSats = rabat;
        }
    }
}