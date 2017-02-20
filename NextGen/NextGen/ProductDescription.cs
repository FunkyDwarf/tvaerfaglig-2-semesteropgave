using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    internal class ProductDescription
    {
        public int itemID { get; }
        public double price { get; }
        public string desctription { get; }

        public ProductDescription(int id, int p, string desc)
        {
            this.itemID = id;
            this.price = p;
            this.desctription = desc;
        }
    }
}