using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clothes_Testing
{
    
    [TestClass]
    public class tstCustomerCollection
    {
           
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to assign to the property
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.Customer_No = 1;
            TestItem.First_Name = "Joshua";
            TestItem.Surname = "Littler";
            TestItem.Email = "joshlittler10@yahoo.co.uk";
            TestItem.House_No = "31b";
            TestItem.Street = "Hood Lane North";
            TestItem.Town = "Warrington";
            TestItem.Post_Code = "WA5 1UN";
            TestItem.Date_Of_Birth = DateTime.Now.Date;
            //add the item to trhe test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to a property
            AllCustomers.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to assign to the property
            List<clsCustomer> TestCustomer = new List<clsCustomer>();
            //set its properties
            TestCustomer.Active = true;
            TestCustomer.Customer_No = 1;
            TestCustomer.First_Name = "Joshua";
            TestCustomer.Surname = "Littler";
            TestCustomer.Email = "joshlittler10@yahoo.co.uk";
            TestCustomer.House_No = "31b";
            TestCustomer.Street = "Hood Lane North";
            TestCustomer.Town = "Warrington";
            TestCustomer.Post_Code = "WA5 1UN";
            TestCustomer.Date_Of_Birth = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.CustomerList = TestCustomer;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestCustomer);
        }
    }
}
