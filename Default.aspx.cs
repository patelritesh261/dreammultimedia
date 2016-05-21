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

public partial class _Default : System.Web.UI.Page
{
    public string bindbanner,bindcategory;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindbannerforhome();
            Bindcategoryforhome();

        }
    }
    private void  Bindbannerforhome()
    {
        using (banner obj = new banner())
        {
            StringBuilder strbanner = new StringBuilder();
            DataSet ds = new DataSet();
            ds = obj.Banner_Select_Bind();

            

           
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (i == 0)
                {
                    strbanner.AppendFormat("<div class=\"active\"><img src=\"Admin/upload/banner/"+ds.Tables[0].Rows[i]["image"].ToString()+"\" alt=\"\" height=\"279\" width=\"960\"/><p class=\"arrow\"><a href=\"#\"></a></p></div>");
                }
                else
                {
                    strbanner.AppendFormat("<div><img src=\"Admin/upload/banner/" + ds.Tables[0].Rows[i]["image"].ToString() + "\" alt=\"\" height=\"279\" width=\"960\"/><p class=\"arrow\"><a href=\"#\"></a></p></div>");
                }
            }
            
           bindbanner = strbanner.ToString();
           
        }
        
    }
    private void Bindcategoryforhome()
    { 
        using(category obj=new category() )
        {
            StringBuilder strcategory = new StringBuilder();
            DataSet ds = new DataSet();
            ds = obj.category_maincategory();

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptcategoty.DataSource = ds;
                rptcategoty.DataBind();  
            }

            //for (int i = 0; i <ds.Tables[0].Rows.Count; i++)
            //{
            //    if (i%3!= 2)
            //    {
            //        strcategory.Append("<div class=\"bit\"><h4>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</h4><div class=\"photo\"><a href=\"Category.aspx?id="+ds.Tables[0].Rows[i]["CategoryID"].ToString()+"\"><img src=\"Admin/upload/category/" + ds.Tables[0].Rows[i]["Image"].ToString() + "\" alt=\"Thumb\" height=\"70\" width=\"203\"/></a></div><p>" + ds.Tables[0].Rows[i]["Description"].ToString() + "</p><p class=\"more\"><a href=\"#\">Read More</a></p></div>	");  
            //    }
            //    else
            //    {
            //        strcategory.Append("<div class=\"bit last\"><h4>" + ds.Tables[0].Rows[i]["Name"].ToString() + "</h4><div class=\"photo\"><a href=\"Category.aspx?id="+ds.Tables[0].Rows[i]["CategoryID"].ToString()+"\"><img src=\"Admin/upload/category/" + ds.Tables[0].Rows[i]["Image"].ToString() + "\"alt=\"Thumb\" height=\"70\" width=\"203\"/></a></div><p>" + ds.Tables[0].Rows[i]["Description"].ToString() + "</p><p class=\"more\"><a href=\"#\">Read More</a></p></div><div class=\"clear\"></div>");  
            //    }
            //}
            //bindcategory = strcategory.ToString();   
        }
    }
}
