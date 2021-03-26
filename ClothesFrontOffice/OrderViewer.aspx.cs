using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();

        //get the data form the session object
        AnOrder = (clsOrder)Session["AnOrder"];

        //display the order Type 
        Response.Write(AnOrder.Order_ID);
    }
}

public class clsOrder
{
    internal string Order_ID;
}