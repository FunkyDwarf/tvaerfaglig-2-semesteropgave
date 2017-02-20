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