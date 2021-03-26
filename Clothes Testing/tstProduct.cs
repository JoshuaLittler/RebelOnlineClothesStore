using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothes_Testing
{
    [TestClass]
    public class tstProduct
    {
        //good test data
        //create some test data to pass the method
        string Name = "Nike";
        string Price = "£20.00";
        string Description = "Medium, Grey";

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
            if (AProduct.Stock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethod()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AProduct.Valid( Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Name = "";
            Name = Name.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Name = "";
            Name = Name.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Name = "";
            Name = Name.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void NameMaxMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Name = "";
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "a";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "aa";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Price = "";
            Price = Price.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Price = "";
            Price = Price.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Price = "";
            Price = Price.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PriceMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Price = "";
            Price = Price.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMinLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMin()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "a";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMinPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Description = "aa";
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMaxLessOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Description = "";
            Description = Description.PadRight(49, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMax()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Description = "";
            Description = Description.PadRight(50, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Description = "";
            Description = Description.PadRight(51, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void DescriptionMid()
        {
            //create an instance of the class we want to create 
            clsProduct AProduct = new clsProduct();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //this should pass
            string Description = "";
            Description = Description.PadRight(25, 'a');
            //invoke the method
            Error = AProduct.Valid(Name, Price, Description);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
