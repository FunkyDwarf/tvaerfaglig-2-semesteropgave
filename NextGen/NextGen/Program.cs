using System;

namespace NextGen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Store myStore = new Store("BIGMAMA", "min-adresse", "7100", "0202029312308");

            StoreSingelton myStore = new StoreSingelton();

            myStore.GetStoreInstance().getRegister().makeNewSale(0);

            // print the catalog

            ProductCatalog catalog = myStore.GetStoreInstance().getCatalog();

            foreach (ProductDescription product in catalog.getAllProductsDescription())
            {
                Console.WriteLine("itemID: " + product.itemID + " Product: " + product.desctription + " price: " + product.price);
            }

            Console.Write("Enter itemID: ");
            int chosenProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            myStore.GetStoreInstance().getRegister().enterItem(chosenProduct, quantity);

            Console.WriteLine("Total: " + myStore.GetStoreInstance().getRegister().getSale().getTotal());

            //myStore.getRegister().endSale();
            myStore.GetStoreInstance().getRegister().printSale();

            Console.ReadKey();
        }
    }
}