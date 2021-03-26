using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Clothes_Testing
{
    [TestClass]
    public class tstProductCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllProducts = new clsAddressCollection();
            //test to see that it exists
            Assert.IsNotNull(AllProducts);

        }

        [TestMethod]
        public void ProductListOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllProducts = new clsAddressCollection();
            //create some test data to assign to the property
            List<ClsAddress>
        }
}
    }

