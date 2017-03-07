namespace NextGen
{
    public class Store
    {
        static private ProductCatalog catalog = new ProductCatalog();
        static private Register register = new Register(catalog);

        public string m_navn { set; get; }
        public string m_adresse { set; get; }
        public string m_postnr { set; get; }
        public string m_CVR { set; get; }

        public Store()
        {
        }

        //public Store(string n, string adr, string pnr, string cvr)
        //{
        //    this.m_navn = n;
        //    this.m_adresse = adr;
        //    this.m_postnr = pnr;
        //    this.m_CVR = cvr;
        //}

        public Register getRegister()
        {
            return register;
        }

        public ProductCatalog getCatalog()
        {
            return catalog;
        }
    }
}