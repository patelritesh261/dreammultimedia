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

public partial class Category : System.Web.UI.Page
{
    public string bindsub;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["id"] == "")
            {
                Response.Redirect("Default.aspx");  
                
            }
            else if (Request.QueryString["id"] != null)
          
            {
                bindsubcategory();
            }
            else
            {
                Response.Redirect("Default.aspx");

            }

        }
    }
    private void bindsubcategory()
    {
        using (category obj = new category())
        {
            //StringBuilder strsub = new StringBuilder();
            obj._id = Convert.ToInt64(Request.QueryString["id"].ToString());
            DataSet ds = new DataSet();
            ds = obj.category_subcategory();


            if (ds.Tables[0].Rows.Count > 0)
            {
                rptproduct.DataSource = ds;
                rptproduct.DataBind();
            }
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    if (i % 3 == 2)
            //    {
            //        strsub.Append("<div class=\"bit last\"><h4>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</h4><div class=\"photo\"><a href=\"SubCategory.aspx?sid=" + ds.Tables[0].Rows[i]["CategoryID"].ToString() + "\"><img src=\"Admin/upload/category/" + ds.Tables[0].Rows[i]["Image"].ToString() + "\" alt=\"No Image\" height=\"70\" width=\"203\" /></a></div><p>"+ds.Tables[0].Rows[i]["Description"].ToString()+"</p></div><div class=\"line\"></div>");  
            //    }
            //    else {
            //        strsub.Append("<div class=\"bit\"><h4>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</h4><div class=\"photo\"><a href=\"SubCategory.aspx?sid=" + ds.Tables[0].Rows[i]["CategoryID"].ToString() + "\"><img src=\"Admin/upload/category/" + ds.Tables[0].Rows[i]["Image"].ToString() + "\" alt=\"No Image\" height=\"70\" width=\"203\" /></a></div><p>" + ds.Tables[0].Rows[i]["Description"].ToString() + "</p></div>");  
            //    }
            //}
            //bindsub = strsub.ToString();   
        }
    }
}
