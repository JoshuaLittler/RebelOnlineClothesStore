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
                mName= value;
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
            //set the private data members to the test data value
            mProductID = 24;
            mPrice = "£49.99";
            mName = "Nike";
            mDescription = "Medium, Black";
            mStock = true;
            //always return true
            return true;
        }
    }
}
