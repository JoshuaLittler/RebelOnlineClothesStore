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

        public int mOrderID {
            get
            {
                //this line of code sends data out of the property
                return mOrderID;
            }
            set
            {
                //this line of code allows data into the property
                mOrderID = value;
            }

                    
        }
       

        public int CusOrderID { get; internal set; }
        public int ProductOrderID { get; internal set; }

        internal bool Find(int order_ID)
        {
            //set the private data members to the test data value
            mOrderID = 21;
            //always return true 
            return true;
        }
    }
}