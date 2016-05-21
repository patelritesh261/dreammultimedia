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

public partial class Admin_Parameteradd : System.Web.UI.Page
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
    private void FillRegData()
    {
        using (parameter obj = new parameter())
        {
            obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
            DataSet ds = new DataSet();
            ds = obj.parameter_selectbyid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtpname.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txtres.Text = ds.Tables[0].Rows[0]["Resolution"].ToString();

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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (parameter obj = new parameter())
        {
            obj._name = txtpname.Text.ToString();
            obj._res = txtres.Text.ToString();

            //if (fusproduct.HasFile)
            //{
            //    obj._sproduct = fusproduct.FileName.ToString();
            //    fusproduct.SaveAs(Server.MapPath("upload\\sample\\") + fusproduct.FileName.ToString());       
            //}

            if (ckbactive.Checked == true)
            {
                obj._active = true;
            }
            else
            {
                obj._active = false;
            }
            obj._cid = Convert.ToInt64(ddlcategory.SelectedValue);
            if (btnsubmit.Text == "Update")
            {
                obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                obj.parameter_update();
                Response.Redirect("Parameterrepeater.aspx?flag=edit");
            }
            else
            {
                obj.parameter_insert();
                Response.Redirect("Parameterrepeater.aspx?flag=add");
            }


        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtpname .Text = "";
        txtres .Text = "";
        
        ckbactive.Checked = false;
    }
}
