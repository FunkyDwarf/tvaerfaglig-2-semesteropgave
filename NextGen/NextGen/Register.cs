namespace NextGen
{
    public class Register
    {
        private ProductCatalog m_prouctCatalog;
        private CustomerCatalog m_customerCatalog;
        private Sale m_currentsale;

        public Register(ProductCatalog c)
        {
            this.m_prouctCatalog = c;
            this.m_customerCatalog = new CustomerCatalog();
        }

        public void endSale()
        {
            m_currentsale.becomeComplete();
        }

        public void enterItem(int itemID, int quantity)
        {
            ProductDescription desc = m_prouctCatalog.getProductDescription(itemID);
            m_currentsale.makeLineItem(desc, quantity);
        }

        public void makeNewSale(int id)
        {
            m_currentsale = new Sale(m_customerCatalog.getCustomerDescription(id));
        }

        public void makePayment(double cashTendered)
        {
            m_currentsale.makePayment(cashTendered);
        }

        public Sale getSale()
        {
            return m_currentsale;
        }

        public void printSale()
        {
            StoreSingelton myStore = new StoreSingelton();

            string navn = myStore.GetStoreInstance().m_navn;
            string adresse = myStore.GetStoreInstance().m_adresse;
            string postnr = myStore.GetStoreInstance().m_postnr;
            string m_CVR = myStore.GetStoreInstance().m_CVR;

            System.Console.WriteLine("STORE NAVN:" + navn + " ADRESSE: " + adresse + " Postnr: " + postnr + " m_CVR: " + m_CVR);
            System.Console.WriteLine("KUNDE NR: " + m_currentsale.getCustomer().kundeNr + " KUNDE NAVN: " + m_currentsale.getCustomer().navn);
        }

        //public void hjælpemetode(Store st)
        //{
        // printSale()
        //int i = metode()
        //string s = metode2(i)
        //...
        //}
    }
}