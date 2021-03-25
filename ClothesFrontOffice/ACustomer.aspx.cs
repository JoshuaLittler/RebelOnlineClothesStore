using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ACustomer : System.Web.UI.Page
{
    

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        
    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        CustomerNo = Convert.ToInt32( txtCustomerNo.Text);
        //find the record
        Found = ACustomer.Find(CustomerNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = ACustomer.FirstName;
            txtSurname.Text = ACustomer.Surname;
            txtEmail.Text = ACustomer.Email;
            txtHouseNo.Text = ACustomer.HouseNo;
            txtStreet.Text = ACustomer.Street;
            txtTown.Text = ACustomer.Town;
            txtPostCode.Text = ACustomer.PostCode;
            txtDateOfBirth.Text = ACustomer.DateOfBirth.ToString();



        }


    }
        
}