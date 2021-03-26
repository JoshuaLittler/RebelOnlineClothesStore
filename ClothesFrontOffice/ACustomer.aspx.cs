using System;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //capture the first name
        string FirstName = txtFirstName.Text;
        //capture the surname
        string Surname = txtSurname.Text;
        //capture the email
        string Email = txtEmail.Text;
        //capture the house no
        string HouseNo = txtHouseNo.Text;
        //capture the street
        string Street = txtStreet.Text;
        //capture the town 
        string Town = txtTown.Text;
        //capture the post code
        string PostCode = txtPostCode.Text;
        //capture date of birth
        string DateOfBirth = txtDateOfBirth.Text;
        //variable to store any messages
        string Error = "";
        //validate the data
        Error = ACustomer.Valid(FirstName, Surname, Email, HouseNo, Street, Town, PostCode, DateOfBirth);
        if (Error == "")
        {
            //capture the first name
            ACustomer.FirstName = FirstName;
            //capture the surname
            ACustomer.Surname = Surname;
            //capture the email
            ACustomer.Email = Email;
            //capture the house no
            ACustomer.HouseNo = HouseNo;
            //capture the street
            ACustomer.Street = Street;
            //capture the town 
            ACustomer.Town = Town;
            //capture the post code
            ACustomer.PostCode = PostCode;
            //capture date of birth
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //store the customer in the session object
            Session["ACustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Write("CustomerViewer.aspx");
        }
        else
        {
            //display error message
            lblError.Text = Error;
        }
   
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerNo;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
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