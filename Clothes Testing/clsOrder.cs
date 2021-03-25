﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Clothes_Testing
{
    public class clsOrder
    {
        public clsOrder()
        {
        }
        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        //private date added data member
        private DateTime mDate;
        //public property for date added
        public DateTime Date
        {
            get
            {
                //return the private data
                return mDate;
            }
            set
            {
                //set the private data
                mDate = value;
            }
        }

        //private data member for Order
        private Int32 mOrderID;
        //public property for Order
        public Int32 Order_ID {
            get
            {
                //this line of code sends data out of the property
                return Order_ID;
            }
            set
            {
                //this line of code allows data into the property
                Order_ID = value;
            }

                    
        }

        //private data member for Order_Cus_ID
        private Int32 mOrder_CUS_ID;
        //public property for Order_Cus_ID
        public Int32 Order_Cus_ID
        {
            get
            {
                //this line of code sends data out of the property
                return Order_Cus_ID;
            }
            set
            {
                //this line of code allows data into the property
                Order_Cus_ID = value;
            }

        }

        //private data member for Order_Product_ID
        private Int32 mOrder_Product_ID;
        //public property for Order_Product_ID
        public Int32 Order_Product_ID
        {
            get
            {
                //this line of code sends data out of the property
                return Order_Product_ID;
            }
            set
            {
                //this line of code allows data into the property
                Order_Product_ID = value;
            }


        }

        //private data member for Order_Type
        private string mOrder_Type;
        //public property for Order_Type
        public string Order_Type
        {
            get
            {
                //this line of code sends data out of the property
                return Order_Type;
            }
            set
            {
                //this line of code allows data into the property
                Order_Type = value;
            }


        }

        public bool Find(int Order_ID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the address on to search for
            DB.AddParamater("@Order_ID", Order_ID);

            //execute the store procedur
            DB.Execute("sproc_tblOrder_FilterByOrder_ID");

            //if one record is found (there should be wither one or Zero!)
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                Order_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                Order_Cus_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Cus_ID"]);
                Order_Type = Convert.ToString(DB.DataTable.Rows[0]["Order_Type"]);
                Order_Product_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Product_ID"]);
                Date = Convert.ToDateTime(DB.DataTable.Rows[0]("13/09/2021"));
                Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            else
            {
                //return false indicating a problem
                return false;
            }

        }

    }
}

