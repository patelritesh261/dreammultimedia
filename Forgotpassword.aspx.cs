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

public partial class Forgotpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bindddlhint();
    }
    private void bindddlhint()
    {
        using (users obj = new users())
        {
            DataSet ds = new DataSet();
            obj._email = Session["email"].ToString();  
            ds = obj.user_select_byforgotpassword();

            if (ds.Tables[0].Rows.Count > 0)
            {
                ddlhint.DataSource = ds;
                ddlhint.DataTextField = "que";
                ddlhint.DataValueField = "HintQuestion";
                ddlhint.DataBind();  
            }

        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            using (users obj = new users())
            {

                obj._email = Session["email"].ToString();
                obj._ans = txtans.Text;  
                DataSet ds = new DataSet();
                ds = obj.user_select_byemailans ();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblfpassword.Text = "Your Password:"+ds.Tables[0].Rows[0]["Password"].ToString();     
                }
                else
                {
                   
                }
            }
        }
    }
    protected void txtemail_TextChanged(object sender, EventArgs e)
    {
        
    }
}
