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
using System.Net;
using System.Net.Mail;

public partial class signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.QueryString["flag"] != null)
            {
                Session["UserID"] = null;
            }
            if (Request.QueryString["flag"] =="forgot")
            {
                lblError.Text = "Password Sent to Email";
                trError.Visible = true;
            }
            fillmarquee();
        }
    }

    private void fillmarquee()
    {
        //throw new NotImplementedException();
        using (category obj = new category())
        {
            DataSet ds = new DataSet();
            obj.id = Convert.ToInt64("2");   
            ds=obj.category_subcategory() ;

            if (ds.Tables[0].Rows.Count > 0)
            {
                rptimage.DataSource = ds;
                rptimage.DataBind();  
            }
 
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            using (users  obj = new users())
            {
                obj._email  = txtemail .Text;
                obj._password = txtpassword.Text;// objGeneral.MD5Encrypt(txtPwd.Text);
                DataSet ds = new DataSet();
                ds = obj.user_login();

                   

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["Name"] = ds.Tables[0].Rows[0]["Username"].ToString();
                    Session["UserID"] = ds.Tables[0].Rows[0]["UserID"].ToString();
                    Session["Email"] = ds.Tables[0].Rows[0]["Email"].ToString();   
                    Response.Redirect("Myaccount.aspx?flag=login");
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
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Response.Write(txtEmailAdd.Text);
        using (users obj = new users())
        {

            obj.email = txtEmailAdd .Text.ToString();
            DataSet ds = new DataSet();
            ds = obj.user_select_byemail();
            if (ds.Tables[0].Rows.Count > 0)
            {
                WebClient client = new WebClient();
                String htmlcode = client.DownloadString(Server.MapPath("forgetpass.htm"));


                htmlcode = htmlcode.Replace("###username###", ds.Tables[0].Rows[0]["Username"].ToString());
                htmlcode = htmlcode.Replace("###password###", ds.Tables[0].Rows[0]["Password"].ToString());


                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dreammultimediadm@gmail.com", "Dream Multimedia");
                mail.To.Add(txtEmailAdd.Text);
                mail.Subject = "Forgot Password Massage";
                string Body = htmlcode;
                mail.Body = Body;
                mail.IsBodyHtml = true;

                //Attachment ob = new Attachment(Server.MapPath("my_friends_166225.jpg"));
                //mail.Attachments.Add(ob);

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential("dreammultimediadm@gmail.com", "Dream143");
                smtp.EnableSsl = true; // Other then smtp.gmail.com = false;
                smtp.Send(mail);

                mail = null;
                smtp = null;

                Response.Redirect("signin.aspx?flag=forgot");
            }
        }
       
    }
    //protected void lbtnfp_Click(object sender, EventArgs e)
    //{
        
    //    Response.Redirect("forgot.aspx");  
    //}
}
