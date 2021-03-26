using ClothesClasses;
using System;

namespace Clothes_Testing
{
    public class clsProduct
    {
        //private data member for the address no property
        private Int32 mProductID;
        private string mPrice;
        private string mName;
        private string mDescription;
        private bool mStock;

        public bool Stock
        {
            get
            {
                //return the private data
                return mStock;
            }
            set
            {
                //set the private data
                mStock = value;
            }

        }
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }

        }
        public string Description
        {
            get
            {
                //return the private data
                return mDescription;
            }
            set
            {
                //set the private data
                mDescription = value;
            }
        }
        public string Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }

        }
        public Int32 ProudctID

        {
            get
            {
                //this line of code sends data out of the property
                return mProductID;
            }
            set
            {
                //this line of the code allows data into the property
                mProductID = value;
            }

        }





        public bool Find(int productID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the product no to search for
            DB.AddParameter("@ProductID", productID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductID");
            //If one record is found(there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["ProductPrice"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mStock = Convert.ToBoolean(DB.DataTable.Rows[0]["ProductStock"]);

                //return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;


            }
        }

        internal string Valid(object productID, object name, object price, object description, object stock)
        {
            throw new NotImplementedException();
        }

        internal string Valid(string name, string price, string description)
        {
            return "";
        }
    }
}
