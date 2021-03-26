using System;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //get the data form the session object
        AnOrder = (clsOrder)Session["AnOrder"];

        //display the order Type 
        Response.Write(AnOrder.Order_Type);
    }
}

public class clsOrder
{
}