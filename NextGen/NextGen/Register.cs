using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    internal class Register
    {
        private ProductCatalog catalog;
        private Sale currentsale;

        public Register(ProductCatalog c)
        {
            this.catalog = c;
        }

        public void endSale()
        {
            currentsale.becomeComplete();
        }

        public void enterItem(int itemID, int quantity)
        {
            ProductDescription desc = catalog.getProductDescription(itemID);
            currentsale.makeLineItem(desc, quantity);
        }

        public void makeNewSale()
        {
            currentsale = new Sale();
        }

        public void makePayment(double cashTendered)
        {
            currentsale.makePayment(cashTendered);
        }
    }
}