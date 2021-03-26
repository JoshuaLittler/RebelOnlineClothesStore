using System;
using System.Collections.Generic;

namespace Clothes_Testing
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }
            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the databased based on the values of thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection;
            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.First_Name);
            DB.AddParameter("@Surname", mThisCustomer.Surname);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@HouseNo", mThisCustomer.House_No);
            DB.AddParameter("@Street", mThisCustomer.Street);
            DB.AddParameter("@Town", mThisCustomer.Town);
            DB.AddParameter("@PostCode", mThisCustomer.Post_Code);
            DB.AddParameter("@DateOfBirth", mThisCustomer.Date_Of_Birth);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }
        public int Count { get; internal set; }
        internal clsCustomer ThisCustomer { get; set; }
        internal List<clsCustomer> CustomerList { get; set; }
    }
         

    

    
}