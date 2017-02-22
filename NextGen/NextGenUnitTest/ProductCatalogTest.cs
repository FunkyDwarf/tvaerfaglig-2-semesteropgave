using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NextGenUnitTest
{
    [TestClass]
    public class ProductCatalogTest
    {
        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void getProductDescription_ThrowKeyNotFoundException()
        {
            //Arrange
            NextGen.ProductCatalog catalog = new NextGen.ProductCatalog();

            //Act
            NextGen.ProductDescription desc = catalog.getProductDescription(300);
        }
    }
}