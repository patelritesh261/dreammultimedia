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

public partial class test_adminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtUsername.Focus();
    }
    
    protected void txtUsename_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            using (adminlogin objAdmin = new adminlogin())
            {
                objAdmin._username = txtUsername.Text;
                objAdmin._password = txtPassword.Text;// objGeneral.MD5Encrypt(txtPwd.Text);
                DataSet ds = new DataSet();
                ds = objAdmin.selectadmin();
                
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["AdminID"] = ds.Tables[0].Rows[0]["Username"].ToString();
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    trError.Visible = true;
                    //imgErrorMsg.Src = "images/wrong_icon.jpg";
                    // tr_admin.Visible = true;
                    //trError.Attributes.Add("class", "ErrorClass");
                    lblError.Text = "Invalid Username or Password";
                    //lblError.CssClass = generalMethods.MessageClassName.ErrorClass;
                }
            }
        }
        else
        {
            trError.Visible = true;
            // tr_admin.Visible = true;
            lblError.Text = "Please enter valid data.";
            // lblError.CssClass = generalMethods.MessageClassName.ErrorClass;
        }
    }
}
