using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    internal class SalesLineItem
    {
        private int quantity;
        private ProductDescription description;

        public SalesLineItem(ProductDescription desc, int q)
        {
            this.description = desc;
            this.quantity = q;
        }

        public double getSubtotal()
        {
            return description.price * quantity;
        }
    }
}