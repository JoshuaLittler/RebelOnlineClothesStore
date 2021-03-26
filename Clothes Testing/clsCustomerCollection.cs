using System;
using System.Collections.Generic;

namespace Clothes_Testing
{
    public class clsCustomerCollection
    {
        //var for the index
        Int32 Index = 0;
        //var to store the record count
        Int32 RecordCount = 0;
        //object for data connection
        clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure
        DB.Execute("sproc_tblCustomer_SelectAll");
            

    }
         

    

    {
        public int Count { get; internal set; }
        internal List<clsCustomer> CustomerList { get; set; }
    }
}