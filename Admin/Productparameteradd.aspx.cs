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

public partial class Admin_Productparameteradd : System.Web.UI.Page
{
    Int64 prid;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (!IsPostBack)
        {
            if (Request.QueryString["mid"] != null)
            {
                if (Request.QueryString["mid"] != "")
                {
                    FillDdlData();
                }
            }



            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "")
                {
                    FillDdlUPData();
                    FillRegData();
                }
            }
        }
  
    }
    private void FillDdlUPData()
    {
        using (productparameter obj = new productparameter())
        {

            DataSet ds = new DataSet();
            obj._pdid = Convert.ToInt64(Request.QueryString["id"].ToString());
            ds = obj.productparameter_select_up_byproductid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlpdname.DataSource = ds;
                ddlpdname.DataTextField = "Name";
                ddlpdname.DataValueField = "ProductID";
                ddlpdname.DataBind();
                obj._pdid = Convert.ToInt64(ds.Tables[0].Rows[0]["prid"].ToString());
                prid = Convert.ToInt64(ds.Tables[0].Rows[0]["prid"].ToString());
            }
            //ds = obj.productparameter_select_bycategoryid();

            using (parameter objp = new parameter())
            {
                objp._id = prid;
                ds=objp.parameter_selectbyid(); 
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ddlprname.DataSource = ds;
                    ddlprname.DataTextField = "Name";
                    ddlprname.DataValueField = "ParameterID";
                    ddlprname.DataBind();
                }
            }


        }
    }
    private void FillDdlData()
    {
        using (productparameter obj = new productparameter())
        {

            DataSet ds = new DataSet();
            obj._pdid = Convert.ToInt64(Request.QueryString["mid"].ToString());
            ds = obj.productparameter_select_byproductid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlpdname.DataSource = ds;
                ddlpdname.DataTextField = "Name";
                ddlpdname.DataValueField = "ProductID";
                ddlpdname.DataBind();

                using (category objc = new category())
                {
                    DataSet dsc = new DataSet();
                    objc._id = Convert.ToInt64(ds.Tables[0].Rows[0]["CategoryID"].ToString());
                    dsc = objc.category_selectbyid();

                    if (dsc.Tables[0].Rows.Count > 0)
                    {
                        ViewState["prid"] = dsc.Tables[0].Rows[0]["ParentID"].ToString();
                    }
                }
            }
            
            //ds = obj.productparameter_select_bycategoryid();
            if (ViewState["prid"] != null)
            {
                
                    obj._pdid = Convert.ToInt64(ViewState["prid"]);
                    ds = obj.productparameter_select_bycategoryid();  
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ddlprname.DataSource = ds;
                        ddlprname.DataTextField = "Name";
                        ddlprname.DataValueField = "ParameterID";
                        ddlprname.DataBind();
                    }
                
            }


        }
    }
    private void FillRegData()
    {
        using (productparameter obj = new productparameter())
        {

            DataSet ds = new DataSet();
            obj._id = Convert.ToInt64(Request.QueryString["id"]);
            ds = obj.productparameter_select_byid();

            if (ds.Tables[0].Rows.Count > 0)
            {

                txtcredit.Text = ds.Tables[0].Rows[0]["credit"].ToString();
                //txtsize.Text = ds.Tables[0].Rows[0]["size"].ToString();

                btnsubmit.Text = "Update";
            }


        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        using (productparameter obj = new productparameter())
        {
            obj._pdid = Convert.ToInt64(ddlpdname.SelectedValue.ToString());
            obj._prid = Convert.ToInt64(ddlprname.SelectedValue.ToString());
            obj._credit = Convert.ToInt64 (txtcredit.Text.ToString());
            if (fusproduct.HasFile)
            {
                obj._oproduct = fusproduct.FileName.ToString();
                fusproduct.SaveAs(Server.MapPath("upload\\orignal\\") + fusproduct.FileName.ToString());
                String fileloc = Server.MapPath("upload\\orignal\\") + fusproduct.FileName.ToString();
                String siz= fusproduct.FileBytes.ToString();   
                double size = Convert.ToDouble (fileloc.Length );
                if (size < 1024)
                {
                    obj._size = size + "B";   
                }
                else if (size > 1024 && size < 1024000)
                {
                    obj._size = size/1024 + "KB"; 
                }
                else
                {
                    obj._size = size / 1024*1024 + "MB"; 
                }
            }
            //obj._size = txtsize.Text.Trim();

            if (btnsubmit.Text == "Update")
            {


                obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
                obj.productparameter_update();
                Response.Redirect("Productparameterrepeater.aspx?flag=edit");
            }
            else
            {
                obj.productparameter_insert();
                Response.Redirect("Productparameterrepeater.aspx?flag=add");
            }

        }
    }
    protected void btnreset_Click(object sender, EventArgs e)
    {
        txtcredit .Text = "";
        //txtsize .Text = "";
        
    }
}
