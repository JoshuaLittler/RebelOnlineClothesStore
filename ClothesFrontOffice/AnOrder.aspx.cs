using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    

    protected void ButtonOK_Click(object sender, EventArgs e)
    {
        //creatr instance new Orderclass
        clsOrder AnOrder = new clsOrder();

        //capture the orderType
        AnOrder.Order_Type = txtOrderType.Text;

        //store the order in the session object
        Session["AnOrder"] = AnOrder;

        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }
}