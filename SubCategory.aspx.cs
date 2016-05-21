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
using System.Text;
using System.Data.SqlClient;   

public partial class SubCategory : System.Web.UI.Page
{
    public string bindsub;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bindsubcategory();
        }
    }
    private void bindsubcategory()
    {
        using (product  obj = new product())
        {
           // StringBuilder strsub = new StringBuilder();
            //Session["cid"] = Request.QueryString["sid"].ToString(); 
            DataSet ds = new DataSet();
            if (Request.QueryString["sid"] == "")
            {
                Response.Redirect("Default.aspx");
            }
            else if (Request.QueryString["sid"] != null)
            {
                obj._id = Convert.ToInt64(Request.QueryString["sid"].ToString());

                ds = obj.product_bindbyid();
            }
            else {
                Response.Redirect("Default.aspx");
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptproduct.DataSource = ds;
                rptproduct.DataBind();  
            }
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    if (i % 4 == 3)
            //    {
            //        strsub.Append("<div class=\"bit last\"><h4>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</h4><div class=\"photo\"><a href=\"Productdetails.aspx?sid=" + ds.Tables[0].Rows[i]["ProductID"].ToString() + "\"><img src=\"Admin/upload/category/" + ds.Tables[0].Rows[i]["Image"].ToString() + "\" alt=\"No Image\" height=\"70\" width=\"203\" /></a></div><p>" + ds.Tables[0].Rows[i]["Description"].ToString() + "</p></div><div class=\"line\"></div>");
            //    }
            //    else
            //    {
            //        strsub.Append("<div class=\"bit\"><h4>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</h4><div class=\"photo\"><a href=\"Productdetails.aspx?sid=" + ds.Tables[0].Rows[i]["ProductID"].ToString() + "\"><img src=\"Admin/upload/category/" + ds.Tables[0].Rows[i]["Image"].ToString() + "\" alt=\"No Image\" height=\"70\" width=\"203\" /></a></div><p>" + ds.Tables[0].Rows[i]["Description"].ToString() + "</p></div>");
            //    }
            //}
            //bindsub = strsub.ToString();
        }
    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {

        

       

    }
}
