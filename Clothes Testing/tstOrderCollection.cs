using System;
using ClothesClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Clothes_Testing
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //test to see that it exixts
            Assert.IsNotNull(AllOrder);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create the item to the list
            clsOrder TestItem = new clsOrder();
            //set this properties 
            TestItem.Active = true;
            TestItem.Order_ID = 111;
            TestItem.Order_Cus_ID = 1;
            TestItem.Order_Product_ID = 1;
            TestItem.Order_Type = "Nike Tshirt";
            TestItem.Date = DateTime.Now.Date;
            //add the item to the property
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrder.mOrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.mOrderList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            String SomeCount = "adidas Jacket";
            //assign the data to the property
            AllOrder.mCount = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.mCount, SomeCount);
        }

        [TestMethod]
        public void OrderTypePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //create the item to the list
            clsOrder TestOrder_Type = new clsOrder();
            //set this properties
            
            TestOrder_Type.Active = true;
            TestOrder_Type.Order_ID = 111;
            TestOrder_Type.Order_Cus_ID = 1;
            TestOrder_Type.Order_Product_ID = 1;
            TestOrder_Type.Order_Type = "Nike Tshirt";
            TestOrder_Type.Date = DateTime.Now.Date;
            //add the item to the property
            TestList.Add(TestOrder_Type);
            //assign the data to the property
            AllOrder.mThisOrder_Type = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.mThisOrder_Type, TestList);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrder = new clsOrderCollection();
           
            //create the item to the list
            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;
            //set this properties

            TestItem.Active = true;
            TestItem.Order_ID = 111;
            TestItem.Order_Cus_ID = 1;
            TestItem.Order_Product_ID = 1;
            TestItem.Order_Type = "Nike Tshirt";
            TestItem.Date = DateTime.Now.Date;
            AllOrder.mThisOrder_Type = TestItem;            
            PrimaryKey = AllOrder.Add();
            TestItem.Order_ID = PrimaryKey;
            AllOrder.mThisOrder_Type.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllOrder.mThisOrder_Type, TestItem);
        }

    }
}
