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

public partial class Admin_newsadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["AdminID"] == null)
        {
            Response.Redirect("adminlogin.aspx");
        }
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    FillRegData();
                }
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (news obj = new news())
        {


            obj._title = txttitle.Text.Trim();
            obj._sdesc = txtsdesc.Text.Trim();
            obj._fdesc = txtfdesc.Text.Trim();
            obj._rank = Convert.ToInt64(txtrank.Text.ToString());
            String str = System.DateTime.Now.ToString();
            str = str.Substring(0, 9);
            obj._date = txtdate.Text;

            if (ckbactive.Checked == true)
            {
                obj._active = true;
            }
            else
            {
                obj._active = false;
            }
            if (btnsubmit.Text == "Update")
            {
                obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                obj.news_update();
                Response.Redirect("Newsrepeter.aspx?flag=edit");
            }
            else
            {
                obj.news_insert();
                Response.Redirect("Newsrepeter.aspx?flag=add");
            }
        }

    }
    private void FillRegData()
    {

        using (news obj = new news())
        {
            DataSet ds = new DataSet();
            obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
            ds = obj.news_select_byid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txttitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                txtsdesc.Text = ds.Tables[0].Rows[0]["SDescription"].ToString();
                txtfdesc.Text = ds.Tables[0].Rows[0]["FDescription"].ToString();
                txtrank.Text = ds.Tables[0].Rows[0]["Rank"].ToString();
                txtdate.Text = ds.Tables[0].Rows[0]["mmddyyyy"].ToString();   
                Boolean b = Convert.ToBoolean(ds.Tables[0].Rows[0]["Active"].ToString());

                if (b == true)
                {
                    ckbactive.Checked = true;
                }
                else
                {
                    ckbactive.Checked = false;
                }
            }

            btnsubmit.Text = "Update";
        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txttitle .Text = "";
        txtrank.Text = "";
        txtsdesc .Text = "";
        txtfdesc.Text = "";  
        ckbactive.Checked = false;
    }
}
