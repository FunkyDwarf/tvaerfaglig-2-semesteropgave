using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NextGenUnitTest
{
    [TestClass]
    public class SalesTest
    {
        [TestMethod]
        public void getTotal_Check()
        {
            NextGen.Store mystore = new NextGen.Store();
            mystore.getRegister().makeNewSale();
            mystore.getRegister().enterItem(100, 10);

            Assert.AreEqual(30, mystore.getRegister().getSale().getTotal());
        }
    }
}