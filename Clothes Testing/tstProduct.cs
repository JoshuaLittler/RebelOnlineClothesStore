using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothes_Testing
{
    [TestClass]
    public class tstProduct
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //test to see that it exists
            Assert.IsNotNull(AProduct);
        }

        [TestMethod]
        public void StockProductOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            Boolean TestData = true;
            //assign the data to the product
            AProduct.Stock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Stock, TestData);
        }

        [TestMethod]
        public void ProductNameOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "Nike sweatpants";
            //assign the data to the product
            AProduct.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Name, TestData);
        }

        [TestMethod]
        public void ProductDescriptionOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "Medium, black";
            //assign the data to the product
            AProduct.Description = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Description, TestData);
        }

        [TestMethod]
        public void ProductPriceOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //create some test data to assign to the product
            string TestData = "£40.00";
            //assign the data to the product
            AProduct.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AProduct.Price, TestData);
        }


    }
}
