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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //bollean variable to store the results of the validation
            Boolean found = false;
            //create some text data to use with method

            Int32 ProductID = 1;

            Int32 ProductID = 1;

            //invoke the mehtod
            found = AProduct.Find(ProductID);
            //test to see if the results is true
            Assert.IsTrue(found);

        }

        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ProductID = 1;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the ProductID
            if (AProduct.ProudctID != 1)
            Int32 ProductID = 1;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the address no
            if (AProduct.ProudctID !=1 )

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ProductID = 3;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the Product
            if (AProduct.Price != "£40.00")

            Int32 ProductID = 3;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the address no
            if (AProduct.Price != "£40.00")

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ProductID = 1;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the Product  name
            if (AProduct.Name != "Nike shirt")

            Int32 ProductID = 1;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the address no
            if (AProduct.Name != "Nike shirt")

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDescriptionFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ProductID = 2;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the Product Description
            if (AProduct.Description != "Grey, Medium")

            Int32 ProductID = 2;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the address no
            if (AProduct.Description != "Grey, Medium")

            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockFound()
        {
            //create an instance of the class we want to create
            clsProduct AProduct = new clsProduct();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method

            Int32 ProductID = 1;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the ProductStock

            Int32 ProductID = 1;
            //invoke the mehtod
            Found = AProduct.Find(ProductID);
            //check the address no

            if (AProduct.Stock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
