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

public partial class Admin_banneradd : System.Web.UI.Page
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
    private void FillBannerData()
    {
        using (banner badd = new banner())
        {

            DataSet ds = new DataSet();
            badd._id = Convert.ToInt64(Request.QueryString["id"]);
            ds = badd.Banner_Select_byid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txttitle.Text = ds.Tables[0].Rows[0]["title"].ToString();
                txtrank.Text = ds.Tables[0].Rows[0]["rank"].ToString();
                ViewState["image"] = ds.Tables[0].Rows[0]["image"].ToString();
                imageup.ImageUrl +=ds.Tables[0].Rows[0]["image"].ToString();
                imageup.Visible = true;
                fuimage.Visible = false;   
                Boolean b = Convert.ToBoolean(ds.Tables[0].Rows[0]["active"].ToString());
                if (b == true)
                {
                    ckbactive.Checked = true;
                }
                else
                {
                    ckbactive.Checked = false;
                }
                //ViewState["funame"] = ds.Tables[0].Rows[0]["image"].ToString();
                title.Text = "Upadate Banner";  
                btnsubmit.Text = "Update";
            }

        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txttitle.Text = "";
        txtrank.Text = "";
        ckbactive.Checked = false;   
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        
        using (banner badd = new banner())
        {
            badd._title = txttitle.Text.Trim();
            badd._rank = Convert.ToInt64(txtrank.Text.Trim());

            if (fuimage.Visible == true)
            {
                if (fuimage.HasFile)
                {
                    //string strss = System.DateTime.Today.ToString();
                    //string[] strs = new string[10];
                    //strs = strss.Split(' ');
                    string imagename = fuimage.FileName;

                    fuimage.SaveAs(Server.MapPath("upload\\banner\\") + imagename);
                    badd._imagename = imagename.Trim();
                }

                else
                {

                }
            }
            else
            {
                badd._imagename = ViewState["image"].ToString();   
            }
            if (ckbactive.Checked == true)
            {
                badd._active = true;
            }
            else
            {
                badd._active = false;
            }
            if (btnsubmit.Text == "Update")
            {
                //if (!fuimage.HasFile)
                //{
                //    badd._imagename = ViewState["funame"].ToString();
                //}

                badd._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                badd.img_update();
                Response.Redirect("Bannerrepeter.aspx?flag=edit");
            }
            else
            {
                badd.img_insert();
                Response.Redirect("Bannerrepeter.aspx?flag=add");
            }

        }
    }
    protected void imageup_Click(object sender, ImageClickEventArgs e)
    {
        imageup.Visible = false;
        fuimage.Visible = true;  
    }
}
