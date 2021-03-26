using System;
using System.Collections.Generic;

namespace ClothesClasses
{
    public class clsOrderCollection
    {
        //public property for the address list
        public List<clsOrder> mOrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        public string mCount
        {
            get
            {
                //return the private data
                return mCount;

            }
            set
            {
                //set the private data
                mCount = value;
            }
        }

        public List<clsOrder> mThisOrder_Type
        {
            get
            {
                //return the private data
                return mThisOrder_Type;

            }
            set
            {
                //set the private data
                mThisOrder_Type = value;
            }


        }

        public clsOrderCollection()
        {

            //var for index
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //objection for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //get the count for records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index<RecordCount)
            {
                //create the items for test data
                clsOrder AnOrder = new clsOrder();
                //set this properties 
                AnOrder.Order_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                AnOrder.Order_Cus_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Cus_ID"]);
                AnOrder.Order_Product_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Product_ID"]);
                AnOrder.Order_Type = Convert.ToString(DB.DataTable.Rows[0]["Order_Type"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_Date"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //add the records to the private data mamber
                mOrderList.Add(AnOrder);
                //point at the next record 
                Index++;
            }
                                   
        }

        public int Add()
        {
            mThisOrder_Type.Order_ID = 100;
            return mThisOrder_Type.Order_ID;
        }


    }
}