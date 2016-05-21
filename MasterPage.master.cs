using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string strusername = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["itemtotal"] != null && Session["itemcount"] != null)
        {
            ltrcountcartitems.Text = Session["itemcount"].ToString();
            ltrtotalprice.Text = Session["itemtotal"].ToString();
        }
        if (Session["UserID"] != null)
        {
            strusername = Session["Name"].ToString();
            login.Visible = true;
            lbluname.Text = Session["Name"].ToString();    
            reg.Visible = false;   

        }
        else
        {
            login.Visible = false ;
           
            reg.Visible = true ; 
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {
        using (product obj = new product())
        {
            Response.Redirect("Searchpage.aspx?name=" + txtsearch.Text);
        }
    }
}
