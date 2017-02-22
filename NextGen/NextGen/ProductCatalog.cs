using System.Collections.Generic;

namespace NextGen
{
    public class ProductCatalog
    {
        private Dictionary<int, ProductDescription>
            descriptions = new Dictionary<int, ProductDescription>();

        public ProductCatalog()
        {
            int itemID1 = 100;
            int itemID2 = 200;
            int price = 3;

            // product 1
            ProductDescription desc;
            desc = new ProductDescription(itemID1, price, "product 1");
            descriptions.Add(itemID1, desc);

            // Product 2
            desc = new ProductDescription(itemID2, price, "product 2");
            descriptions.Add(itemID2, desc);
        }

        public ProductDescription getProductDescription(int id)
        {
            if (descriptions[id] == null)
                throw new KeyNotFoundException();

            return descriptions[id];
        }

        // my function

        public Dictionary<int, ProductDescription> getAllProducts()
        {
            return descriptions;
        }
    }
}