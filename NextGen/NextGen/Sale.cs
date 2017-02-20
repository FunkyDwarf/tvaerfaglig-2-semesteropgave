using System.Collections.Generic;

namespace NextGen
{
    internal class Sale
    {
        private List<SalesLineItem> lineItems =
            new List<SalesLineItem>();

        private string date;
        public bool isComplete { get; private set; }
        private Payment payment;

        public double getTotal()
        {
            double total = 0;
            double subTotal = 0;

            foreach (SalesLineItem item in lineItems)
            {
                subTotal = item.getSubtotal();
                total += subTotal;
            }
            return subTotal;
        }

        public void becomeComplete()
        {
            isComplete = true;
        }

        public void makeLineItem(ProductDescription desc, int q)
        {
            lineItems.Add(new SalesLineItem(desc, q));
        }

        public void makePayment(double cashTendered)
        {
            payment = new Payment(cashTendered);
        }
    }
}