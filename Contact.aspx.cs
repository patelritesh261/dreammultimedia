using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Contact : System.Web.UI.Page
{
    public string desc = string.Empty;
    public string address = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        mapadds();
        if (Request.QueryString["flag"] == "add")
        {
            lblMsg.Visible = true ;
            lblMsg.Text = "Add Successfully";
        }
        else
        {
            lblMsg.Visible = false;
        }
    }

    private void mapadds()
    {
        //throw new NotImplementedException();
        desc = "23.106936,72.594828";
        address = "VGEC ,Near Visat Three Roads,Visat Gandhinagar Roads,Chandkheda,Ganghinagar-382424";

        desc = desc.Replace("<br/>", ",");
        desc = desc.Replace("\r\n", "");
        address = address.Replace("\r\n", "");

        address = "<div style='height:90px;color:#006EBC;font-size:11px;line-height:15px;font-weight:bold;'><div style='width:100px;'>" + address.Replace("<br/>", "</div><div style='width:100px;'>") + "</div></div>";
        Page.RegisterStartupScript("fun", "<script>initialize();</script>");
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (Contactus obj = new Contactus())
        {
            obj.name = txtname.Text.ToString ();
            obj.email = txtemail.Text.ToString();
            obj.message = txtmsg.Text.ToString();
            obj.phone = Convert.ToInt64(txtpno.Text.ToString());
            obj.contactus_insert();
            //lblMsg.Visible = true;
            Response.Redirect("Contact.aspx?flag=add");  
            
            txtemail.Text = "";
            txtmsg.Text = "";
            txtname.Text = "";
            txtpno.Text = "";  
        }
    }
}
