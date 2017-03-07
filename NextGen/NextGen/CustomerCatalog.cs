using System.Collections.Generic;

namespace NextGen
{
    public class CustomerCatalog
    {
        private Dictionary<int, CustomerDescription>
            descriptions = new Dictionary<int, CustomerDescription>();

        public CustomerCatalog()
        {
            int kndnr1 = 0;
            int kndnr2 = 1;

            string navn1 = "navn1";
            string navn2 = "navn2";

            //kunde1

            CustomerDescription desc;
            desc = new CustomerDescription(kndnr1, navn1, 25);
            descriptions.Add(kndnr1, desc);

            //Kunde2
            desc = new CustomerDescription(kndnr2, navn2, 10);
            descriptions.Add(kndnr2, desc);
        }

        public CustomerDescription getCustomerDescription(int id)
        {
            if (descriptions[id] == null)
                throw new KeyNotFoundException();

            return descriptions[id];
        }
    }
}