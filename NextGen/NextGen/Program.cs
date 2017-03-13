using System;

namespace NextGen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Store myStore = StoreSingelton.GetStoreInstance();

            myStore.m_adresse = "min-adresse";
            myStore.m_CVR = "0202029312308";
            myStore.m_navn = "BIGMAMA";
            myStore.m_postnr = "7100";

            myStore.getRegister().makeNewSale(0);

            // print the catalog

            ProductCatalog catalog = myStore.getCatalog();

            foreach (ProductDescription product in catalog.getAllProductsDescription())
            {
                Console.WriteLine("itemID: " + product.itemID + " Product: " + product.desctription + " price: " + product.price);
            }

            Console.Write("Enter itemID: ");
            int chosenProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            myStore.getRegister().enterItem(chosenProduct, quantity);

            Console.WriteLine("Total: " + myStore.getRegister().getSale().getTotal());

            //myStore.getRegister().endSale();
            myStore.getRegister().printSale();

            Console.ReadKey();
        }
    }
}