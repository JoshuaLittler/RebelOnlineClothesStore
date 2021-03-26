using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AProduct = new clsProduct();
        // get the data from the session object
        AProduct = (clsProduct)Session["AProduct"];
        //display the Product name for this entry
        Response.Write(AProduct.Name);
        //display the product price for this entry
        Response.Write(AProduct.Price);
        //display the product description for this entry
        Response.Write(AProduct.Description);
    }
}