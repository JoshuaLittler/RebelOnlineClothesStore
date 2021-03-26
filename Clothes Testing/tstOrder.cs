using System;
using ClothesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothes_Testing
{
    [TestClass]
    public class tstOrder
    {
        //good test data
            //create some test data to pass to the method
        string Order_Cus_ID = "1";
        string Order_Product_ID = "1";
        string Order_Type = "Nike Jacket";
        string Order_Date = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void DatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.Date = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Date, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Order_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_ID, TestData);
        }

        [TestMethod]
        public void CusOrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Order_Cus_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_Cus_ID, TestData);
        }

        [TestMethod]
        public void ProductOrderIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.Order_Product_ID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_Product_ID, TestData);
        }

        [TestMethod]
        public void OrderTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string type = "Tshirt";
            //assign the data to the property
            AnOrder.Order_Type = type;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Order_Type, type);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Order_ID = 111;
            //invoke the method
            Found = AnOrder.Find(Order_ID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_ID = 111;
            //invoke the method
            Found = AnOrder.Find(Order_ID);
            //check the address no
            if (AnOrder.Order_ID != 111)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_ID = 111;
            //invoke the method
            Found = AnOrder.Find(Order_ID);
            //check the property
            if (AnOrder.Date != Convert.ToDateTime("13/09/2020"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderProIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_Product_ID = 1;
            //invoke the method
            Found = AnOrder.Find(Order_Product_ID);
            //check the address no
            if (AnOrder.Order_Product_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderCusIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_Cus_ID = 1;
            //invoke the method
            Found = AnOrder.Find(Order_Cus_ID);
            //check the address no
            if (AnOrder.Order_Cus_ID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderTypeFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_ID = 111;
            //invoke the method
            Found = AnOrder.Find(Order_ID);
            //check the property
            if (AnOrder.Order_Type != "Nike Tshirt")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_ID = 1;
            //invoke the method
            Found = AnOrder.Find(Order_ID);
            //check the property
            if (AnOrder.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMetodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the results is correct
            Assert.AreEqual(Error, "");

        }

        public void Order_TypeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String Order_Type = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Order_TypeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order_Type = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Order_TypeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order_Type = "aaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Order_TypeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order_Type = "aaaaaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Order_TypeMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Order_Type = "aaa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void DateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
           
            //set the Date to non date value
            string Order_Date = "this is not a date";
            //invoke the method
            Error = AnOrder.Valid(Order_Cus_ID, Order_Product_ID, Order_Type, Order_Date);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
