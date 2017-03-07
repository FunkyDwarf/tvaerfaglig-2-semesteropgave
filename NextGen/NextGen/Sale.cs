using System.Collections.Generic;

namespace NextGen
{
    public class Sale
    {
        private List<SalesLineItem> lineItems =
            new List<SalesLineItem>();

        public bool m_isComplete { get; private set; }
        private Payment m_payment;

        private CustomerDescription m_customerdescription;

        public Sale(CustomerDescription c)
        {
            m_customerdescription = new CustomerDescription(c.kundeNr, c.navn, c.rabatSats);
        }

        public double getTotal()
        {
            double total = 0;
            double subTotal = 0;

            foreach (SalesLineItem item in lineItems)
            {
                subTotal = item.getSubtotal();
                total += subTotal;
            }
            return total;
        }

        public void becomeComplete()
        {
            m_isComplete = true;
        }

        public void makeLineItem(ProductDescription desc, int q)
        {
            lineItems.Add(new SalesLineItem(desc, q));
        }

        public void makePayment(double cashTendered)
        {
            m_payment = new Payment(cashTendered);
        }

        public CustomerDescription getCustomer()
        {
            return m_customerdescription;
        }
    }
}