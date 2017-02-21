using System;

namespace NextGen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Store myStore = new Store();
            myStore.getRegister().makeNewSale();

            // print the catalog

            ProductCatalog catalog = myStore.getCatalog();

            foreach (ProductDescription product in catalog.getAllProducts().Values)
            {
                Console.WriteLine("itemID: " + product.itemID + " Product: " + product.desctription + " price: " + product.price);
            }

            Console.Write("Enter itemID: ");
            int chosenProduct = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            myStore.getRegister().enterItem(chosenProduct, quantity);

            Console.WriteLine("Total: " + myStore.getRegister().getSale().getTotal());

            myStore.getRegister().endSale();

            Console.ReadKey();
        }
    }
}