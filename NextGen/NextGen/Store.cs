using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextGen
{
    internal class Store
    {
        static private ProductCatalog catalog = new ProductCatalog();
        static private Register register = new Register(catalog);

        public Register getRegister()
        {
            return register;
        }
    }
}