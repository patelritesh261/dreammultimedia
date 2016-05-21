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

public partial class Admin_cmspage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {


                    Fillregdata();
                }
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (cms obj = new cms())
        {
            obj._title = txttitle.Text.Trim();
            obj._desc = txtdesc.Text.Trim();
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
                obj._cid = Convert.ToInt64(Request.QueryString["id"].ToString());
                obj.cms_update();
                Response.Redirect("cmspagerepeater.aspx?flag=edit");
            }
            else
            {
                obj.cms_insert();
                Response.Redirect("cmspagerepeater.aspx?flag=add");
            }

        }
    }
    private void Fillregdata()
    {
        using (cms obj = new cms())
        {
            DataSet ds = new DataSet();
            obj._cid = Convert.ToInt64(Request.QueryString["id"].ToString());
            ds = obj.cms_selectbyid();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txttitle.Text = ds.Tables[0].Rows[0]["Title"].ToString();
                txtdesc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
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

}
