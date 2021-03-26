using System;


namespace ClothesClasses
{
    public class clsOrder
    {
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
        //private  member for Order

        private int mOrder_ID;
        //public property for Order
        public Int32 Order_ID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrder_ID;
            }
            set
            {
                //this line of code allows data into the property
                mOrder_ID = value;
            }


        }

        //private data member for Order_Cus_ID
        private Int32 mOrder_Cus_ID;
        //public property for Order_Cus_ID
        public Int32 Order_Cus_ID
        {
            get
            {
                //this line of code sends data out of the property
                return mOrder_Cus_ID;
            }
            set
            {
                //this line of code allows data into the property
                mOrder_Cus_ID = value;
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
                return mOrder_Type;
            }
            set
            {
                //this line of code allows data into the property
                mOrder_Type = value;
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
                return mOrder_Product_ID;
            }
            set
            {
                //this line of code allows data into the property
                mOrder_Product_ID = value;
            }


        }

        public bool Find(int Order_ID)
        {
            //creats an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@Order_ID", mOrder_ID);
            //exexute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrder_ID");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrder_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_ID"]);
                mOrder_Cus_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Cus_ID"]);
                mOrder_Product_ID = Convert.ToInt32(DB.DataTable.Rows[0]["Order_Product_ID"]);
                mOrder_Type = Convert.ToString(DB.DataTable.Rows[0]["Order_Type"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Order_Date"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string order_Cus_ID, string order_Product_ID, string order_Type, string order_Date)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (Order_Type.Length == 0)
            {
                //record the error
                Error = Error + "The Order Type may not be blank : ";
            }
            //if the house no is greater than 6 characters
            if (Order_Type.Length > 6)
            {
                //record the error
                Error = Error + "The Order type must be less than 6 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(Date);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The Date was not a valid Date";
            }
            //return any error messages
            return Error;

        }


    }
}