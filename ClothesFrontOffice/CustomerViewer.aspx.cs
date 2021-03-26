using System;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        //get the data form the session object
        ACustomer = (clsCustomer)Session["ACustomer"];

        //display the Customer name
        Response.Write(ACustomer.First_Name);
    }
}