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

public partial class forgot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        //Session["email"] = txtemail.Text.ToString();
        using (users obj = new users())
        {

            obj.email = txtemail.Text.ToString();
            DataSet ds = new DataSet();
            ds = obj.user_select_byemail(); 
            if (ds.Tables[0].Rows.Count > 0)
            {
                WebClient client = new WebClient();
                String htmlcode = client.DownloadString(Server.MapPath("forgetpass.htm"));


                htmlcode = htmlcode.Replace("###username###", ds.Tables[0].Rows[0]["Username"].ToString()   );
                htmlcode = htmlcode.Replace("###password###", ds.Tables[0].Rows[0]["Password"].ToString());
               

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("dreammultimediadm@gmail.com", "Dream Multimedia");
                mail.To.Add(txtemail.Text);
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
}
