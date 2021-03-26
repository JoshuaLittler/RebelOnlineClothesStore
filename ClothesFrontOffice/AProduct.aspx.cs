using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsProduct
        clsProduct AProduct = new clsProduct();
        //capture the Product Name
        AProduct.Name = txtName.Text;
        //capture the Product Price
        AProduct.Price = txtPrice.Text;
        //capture the product description
        AProduct.Description = txtDescription.Text;
        //store the product name in the session object
        Session["AProduct"] = AProduct;
        //redirect to the viewer page
        Response.Redirect("ProductViewer.aspx");
    }
}