using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothes_Testing
{
    [TestClass]
    public class tstCustomer
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public string DateOfBirth { get; private set; }
        public string PostCode { get; private set; }
        public string HouseNo { get; private set; }
        public string Street { get; private set; }
        public string Town { get; private set; }
        public string Email { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data
            Int32 CustomerNo = 1;
            //Create some test data to use with the method
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Customer_No = 1;
            //invoke the method
            Found = ACustomer.Find(Customer_No);
            //check the cust no
            if (ACustomer.Customer_No != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.First_Name != "Joshua")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Surname != "Littler")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnOrder = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Order_ID = 111;
            //invoke the method
            Found = AnOrder.Find(Order_ID);
            //check the customer
            if (AnOrder.Date_Of_Birth != Convert.ToDateTime("07/05/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = aCustomer.Find(CustomerNo);
            //check the customer
            if (aCustomer.Post_Code != "WA5 1UN")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Street != "Hood Lane North")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Town != "Warrington")
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 21;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the Customer
            if (ACustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Customer
            string TestData = "21b";
            //assign the data to the Property
            ACustomer.House_No = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.House_No, TestData);
        }


        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "WA5 1UN";
            //assign the data to the Property
            ACustomer.Post_Code = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Post_Code, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "Joshua";
            //assign the data to the Property
            ACustomer.First_Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.First_Name, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "Littler";
            //assign the data to the Property
            ACustomer.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Surname, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "Hood Lane North";
            //assign the data to the Property
            ACustomer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            string TestData = "Leicester";
            //assign the data to the Property
            ACustomer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Town, TestData);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the customer
            Boolean TestData = true;
            //assign the data to the Property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the Property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the Property
            ACustomer.Date_Of_Birth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Date_Of_Birth, TestData);

        }


        public void HouseNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "a"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void HouseNoMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaaaaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = "aaa"; //this should be ok
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void HouseNoExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string HouseNo = ""; //this should fail
            HouseNo = HouseNo.PadRight(500, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateOfBirthMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOfBirth = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfBirthInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateOfBirth to a non date value
            string DateOfBirth = "This is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PostCode = "aaaaaaaaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostCodeMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StreetMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StreetMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Street = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void StreetMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Street = "";
            Street = Street.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Town = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TownMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Town = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TownMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Town = "";
            Town = Town.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Surname = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "";
            Surname = Surname.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "";
            Surname = Surname.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Surname = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SurnameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Surname = "";
            Surname = Surname.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "a";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "aa";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Email = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Email = "";
            Email = Email.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



    }

}

