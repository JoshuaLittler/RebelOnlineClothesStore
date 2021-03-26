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
        private string mHouse_No;
        //public property for HouseNo
        public string House_No
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

        public string Valid(string FirstName, string Surname, string Email, string HouseNo, string Street, string Town, string PostCode, string DateOfBirth)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the FirstName is blank
            if (FirstName.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            if (FirstName.Length > 50)
            {
                //record the error
                Error = Error + "The first name may more than 50 characters : ";
            }

            //if the Surname is blank
            if (Surname.Length == 0)
            {
                //record the error
                Error = Error + "The surname may not be blank : ";
            }
            if (Surname.Length > 50)
            {
                //record the error
                Error = Error + "The surname may more than 50 characters : ";
            }

            //if the Email is blank
            if (Email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            if (Email.Length > 50)
            {
                //record the error
                Error = Error + "The email may more than 50 characters : ";
            }

            //is the post code blank
            if (PostCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (PostCode.Length > 9)
            {
                //record the error
                Error = Error + "The post code must be less than 9 characters : ";
            }
            //is the street blank
            if (Street.Length == 0)
            {
                //record the error
                Error = Error + "The street may not be blank : ";
            }
            //if the street is too long
            if (Street.Length > 50)
            {
                //record the error
                Error = Error + "The street must be less than 50 characters : ";
            }
            //is the town blank
            if (Town.Length == 0)
            {
                //record the error
                Error = Error + "The town may not be blank : ";
            }
            //if the town is too long
            if (Town.Length > 50)
            {
                //record the error
                Error = Error + "The town must be less than 50 characters : ";
            }

            try
            {
                //copy the dateOfBirth value to the DateTemp variable
                DateTemp = Convert.ToDateTime(DateOfBirth);
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
                //record the error
                Error = Error + "The date can't be in the future";
            }
            

            //return any error messages
            return Error;
        }








        public bool Find(int Customer_No)
        {
            //set the private data members to the test data value
            mCustomer_No = 1;
            mFirst_Name = "Joshua";
            mSurname = "Littler";
            mEmail = "joshlittler10@yahoo.co.uk";
            mHouse_No = "310";
            mStreet = "Hood Lane North";
            mTown = "Warrington";
            mPost_Code = "WA5 1UN";
            mDate_Of_Birth = Convert.ToDateTime("07/05/2000");
            mActive = true;
            //always return true
            return true;
        }
    }
}
