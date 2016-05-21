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
  

public partial class signup : System.Web.UI.Page
{
    Boolean b;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlbindhint();
            if (Request.QueryString["id"] != null)
            {
                filldata();
            }
        }
    }

    private void filldata()
    {
        //throw new NotImplementedException();
        using (users obj = new users())
        {
            obj.uid = Convert.ToInt64(Request.QueryString["id"].ToString());
            DataSet ds = new DataSet(); 
            ds=obj.user_select_byid();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtaddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                txtans.Text = ds.Tables[0].Rows[0]["Answer"].ToString();
                txtcno.Text = ds.Tables[0].Rows[0]["Contactno"].ToString();
                txtdate.Text = ds.Tables[0].Rows[0]["dd"].ToString();
                txtemail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                txtfirstname.Text = ds.Tables[0].Rows[0]["Firstname"].ToString();
                txtlastname.Text = ds.Tables[0].Rows[0]["Lastname"].ToString();
                txtusername.Text = ds.Tables[0].Rows[0]["Username"].ToString();
                ddlhint.SelectedValue = ds.Tables[0].Rows[0]["HintQuestion"].ToString();
                Boolean b=Convert.ToBoolean(ds.Tables[0].Rows[0]["Gender"].ToString());
                if (b)
                {
                    RadioButtonList1.SelectedItem.Value = "1";   
                }
                else
                {
                    RadioButtonList1.SelectedItem.Value = "2";    
                }
                btnsubmit.ToolTip  = "Update";  
            }
 
        }
    }
    private void ddlbindhint()
    {
        using (users obj = new users())
        {
            DataSet ds = new DataSet();
            ds = obj.user_hin_selectall();

            if (ds.Tables[0].Rows.Count > 0)
            {

                ddlhint.DataSource = ds;
                ddlhint.DataTextField = "Question";
                ddlhint.DataValueField = "HintID";
                ddlhint.DataBind();  
            }
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if(Page.IsValid)
        {
            if (lbl.Text == "Email Address Available")
            {
                using (users obj = new users())
                {


                    obj._fname = txtfirstname.Text.Trim();
                    obj._lname = txtlastname.Text.Trim();
                    obj._dbo = Convert.ToDateTime(txtdate.Text.Trim());
                    obj._email = txtemail.Text.Trim();
                    obj._uname = txtusername.Text.Trim();

                    obj._address = txtaddress.Text.Trim();
                    obj._hint = Convert.ToInt64(ddlhint.SelectedValue.ToString());
                    obj._ans = txtans.Text.Trim();
                    obj._password = txtpassword.Text.Trim();
                    obj._balanceid = Convert.ToInt64("0");
                    obj._cno = Convert.ToInt64(txtcno.Text.Trim());

                    if (RadioButtonList1.SelectedValue == "1")
                    {
                        obj._gender = true;
                    }
                    else
                    {
                        obj._gender = false;
                    }

                    if (btnsubmit.ToolTip == "Update")
                    {
                        obj.user_update();
                        Response.Redirect("Myaccount.aspx?flag=edit");
                    }
                    else
                    {
                        WebClient client = new WebClient();
                        String htmlcode = client.DownloadString(Server.MapPath("Welcome.htm"));

                        htmlcode = htmlcode.Replace("###username###", txtusername.Text);
                        htmlcode = htmlcode.Replace("###email###", txtemail.Text);
                        htmlcode = htmlcode.Replace("###password###", txtpassword.Text);

                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("dreammultimediadm@gmail.com", "Dream Multimedia");
                        mail.To.Add(txtemail.Text);
                        mail.Subject = "Registration Massage";
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




                        obj.user_insert();
                        using (users obu = new users())
                        {
                            DataSet ds = new DataSet();
                            obj.email = txtemail.Text.ToString();
                            ds = obj.user_select_byemail();
                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                Session["name"] = ds.Tables[0].Rows[0]["Username"].ToString();
                                Session["UserID"] = ds.Tables[0].Rows[0]["UserID"].ToString();
                                Response.Redirect("Myaccount.aspx?flag=signup");
                            }
                            else
                            {
                                Response.Redirect("signup.aspx");
                            }
                        }
                    }


                }
            }
            else
            {
                
                txtemail.Focus();  
            }
        }
    }
    protected void txtemail_Changed(object sender, EventArgs e)
    {
        // Write your code to check from DB
        using (users obj = new users())
        {
            obj.email = txtemail.Text.ToString();
            DataSet ds = new DataSet();
            ds = obj.user_select_byemail();

            if (ds.Tables[0].Rows.Count > 0)
            {
                lbl.Text = "Please Change Email Address";
                lbl.CssClass = "lblfalse";
                b = true;      

            }
            else
            {
                lbl.Text = "Email Address Available";
                lbl.CssClass = "lbltrue";
                b = false; 
            }

        }
    }
}
