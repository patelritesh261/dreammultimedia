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

public partial class Admin_Packageadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminID"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
        imageup.Visible = false; 
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    FillBannerData();
                }
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (Package obj = new Package())
        {
            obj._name = txtname.Text.Trim();
            obj._credit = Convert.ToInt64(txtcredit.Text.Trim());
            obj._rupees=Convert.ToInt64 (txtrupees.Text.Trim());
            if (fuimage.Visible == true)
            {
            if (fuimage.HasFile)
            {
                fuimage.SaveAs(Server.MapPath("upload\\package\\") + fuimage.FileName);
                obj._image = fuimage.FileName.ToString().Trim();
            }
            }
            else
            {
                     obj._image = ViewState["image"].ToString();
            }
            

            if (btnsubmit.Text == "Update")
            {
                
                if (!fuimage.HasFile)
                {
                   // obj._image = ViewState["funame"].ToString();
                }
                
                obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                obj.package_update();
                Response.Redirect("Packagerepeater.aspx?flag=edit");
            }
            else
            {
                obj.package_insert();
                Response.Redirect("Packagerepeater.aspx?flag=edit");
            }

        }

    }
    private void FillBannerData()
    {
        using (Package obj = new Package())
        {

            DataSet ds = new DataSet();
            obj._id = Convert.ToInt64(Request.QueryString["id"]);
            ds = obj.package_Select_byid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtname.Text = ds.Tables[0].Rows[0]["name"].ToString();
                txtcredit.Text = ds.Tables[0].Rows[0]["credit"].ToString();
                txtrupees.Text = ds.Tables[0].Rows[0]["price"].ToString() ;     
                ViewState["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                imageup.ImageUrl += ds.Tables[0].Rows[0]["image"].ToString();
                imageup.Visible = true;
                fuimage.Visible = false; 
                //ViewState["funame"] = ds.Tables[0].Rows[0]["image"].ToString();
                btnsubmit.Text = "Update";
            }

        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtcredit.Text = "";
        txtname.Text = "";
        
    }
    protected void imageup_Click(object sender, ImageClickEventArgs e)
    {
        imageup.Visible = false;
        fuimage.Visible = true;
    }
}
