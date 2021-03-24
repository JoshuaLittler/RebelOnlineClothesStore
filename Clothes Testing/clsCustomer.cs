using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clothes_Testing
{
    class clsCustomer
    {
        public clsCustomer()
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
        private DateTime mDate_Of_Birth;
        //public property for date added
        public DateTime Date_Of_Birth
        {
            get
            {
                //return the private data
                return mDate_Of_Birth;
            }
            set
            {
                //set the private data
                mDate_Of_Birth = value;
            }
        }

        //private data member for Customer
        private Int32 mCustomer_No;
        //public property for Customer
        public Int32 Customer_No
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomer_No;
            }
            set
            {
                //this line of code allows data into the property
                mCustomer_No = value;
            }


        }

        //private data member for FirstName
        private string mFirst_Name;
        //public property for FirstName
        public string First_Name
        {
            get
            {
                //this line of code sends data out of the property
                return mFirst_Name;
            }
            set
            {
                //this line of code allows data into the property
                mFirst_Name = value;
            }

        }

        //private data member for Surname
        private string mSurname;
        //public property for Surname
        public string Surname
        {
            get
            {
                //this line of code sends data out of the property
                return mSurname;
            }
            set
            {
                //this line of code allows data into the property
                mSurname = value;
            }


        }

        //private data member for Email
        private string mEmail;
        //public property for Email
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }


        }

        //private data member for HouseNo
        private Int32 mHouse_No;
        //public property for HouseNo
        public Int32 House_No
        {
            get
            {
                //this line of code sends data out of the property
                return mHouse_No;
            }
            set
            {
                //this line of code allows data into the property
                mHouse_No = value;
            }


        }

        //private data member for Street
        private string mStreet;
        //public property for Street
        public string Street
        {
            get
            {
                //this line of code sends data out of the property
                return mStreet;
            }
            set
            {
                //this line of code allows data into the property
                mStreet = value;
            }


        }

        //private data member for Town
        private string mTown;
        //public property for Town
        public string Town
        {
            get
            {
                //this line of code sends data out of the property
                return mTown;
            }
            set
            {
                //this line of code allows data into the property
                mTown = value;
            }


        }

        //private data member for PostCode
        private string mPost_Code;
        //public property for PostCode
        public string Post_Code
        {
            get
            {
                //this line of code sends data out of the property
                return mPost_Code;
            }
            set
            {
                //this line of code allows data into the property
                mPost_Code = value;
            }


        }




        public bool Find(int Customer_No)
        {
            //set the private data members to the test data value
            Customer_No = 1;
            First_Name = "Joshua";
            Surname = "Littler";
            Email = "joshlittler10@yahoo.co.uk";
            House_No = 310;
            Street = "Hood Lane North";
            Post_Code = "WA5 1UN";
            Date_Of_Birth = Convert.ToDateTime("07/05/2000");
            Active = true;
            //always return true
            return true;
        }
    }
}
