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

public partial class Orderconfirmation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblerror.Visible = false;
        if (!IsPostBack)
        {
            if (Session["UserID"] != null)
            { 
                if(Session["UserID"]!="")
                {
                    FillRepeater();
                    
                    
                }
            }
            else
            {
                Response.Redirect("signin.aspx");  
            }
        }
    }
    public void FillRepeater()
    {

        using (cart obj = new cart())
        {

          
            obj._userid = Convert.ToInt64(Session["UserID"].ToString());  
            obj._sessionid = Session["Current"].ToString();
            obj._orderid = Convert.ToInt64("0");

            DataSet ds = new DataSet();
            ds = obj.cart_details();

            if (ds.Tables[0].Rows.Count > 0)
            {

                rptcart.DataSource = ds;
                rptcart.DataBind();

            }
            else
            {
                lblerror.Text = "No Item In Cart";
                lblerror.Visible = true;   
                rptcart.Visible = false;
                totaldiv.Visible = false;
                btnconfirm.Visible = false;
            }
            ds = obj.cart_total();
            lbltotals.Text = ds.Tables[0].Rows[0]["total"].ToString();
             
        }
    }
    protected void btnconfirm_Click(object sender, EventArgs e)
    {
        double currentcredit=0;
        double total=Convert.ToDouble(lbltotals.Text.ToString());     
        if (Session["UserID"] != null)
        {
            using (users objo = new users())
            { 
                objo.uid=Convert.ToInt64(Session["UserID"].ToString());
                DataSet dsr = new DataSet();
 
                dsr=objo.user_select_byid();

                if (dsr.Tables[0].Rows.Count > 0)
                { 
                    currentcredit =Convert.ToDouble(dsr.Tables[0].Rows[0]["Balance"].ToString());  
 
                }
                if (currentcredit > total)
                {
                    currentcredit = currentcredit - total;
                    objo.balanceid = currentcredit;
                    objo.user_updatebalance();

                    using (cart obj = new cart())
                    {


                        obj._userid = Convert.ToInt64(Session["UserID"].ToString());
                        obj._sessionid = Session["Current"].ToString();
                        obj._orderid = Convert.ToInt64("0");

                        DataSet ds = new DataSet();
                        ds = obj.cart_details();
                        using (order objc = new order())
                        {
                            WebClient client = new WebClient();
                            String htmlcode = client.DownloadString(Server.MapPath("Order.htm"));


                            htmlcode = htmlcode.Replace("###username###", Session["Name"].ToString() );
                            htmlcode = htmlcode.Replace("###credit###", lbltotals.Text.ToString());


                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("dreammultimediadm@gmail.com", "Dream Multimedia");
                            mail.To.Add(Session["Email"].ToString());
                            mail.Subject = "Order Massage";
                            string Body = htmlcode;
                            mail.Body = Body;
                            mail.IsBodyHtml = true;

                            Attachment ob ;
                            //ob= new Attachment(Server.MapPath("my_friends_166225.jpg"));
                            //mail.Attachments.Add(ob);

                           



                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                objc._uid = Convert.ToInt64(Session["UserID"].ToString());
                                objc._date = Convert.ToDateTime(System.DateTime.Now);
                                objc._cname = ds.Tables[0].Rows[i]["cname"].ToString();
                                objc._pname = ds.Tables[0].Rows[i]["pdname"].ToString();
                                objc._pcode = ds.Tables[0].Rows[i]["pcode"].ToString();
                                objc._image = ds.Tables[0].Rows[i]["image"].ToString();
                                objc._res = ds.Tables[0].Rows[i]["res"].ToString();
                                objc._size = ds.Tables[0].Rows[i]["size"].ToString();
                                objc._credit = Convert.ToInt64(   ds.Tables[0].Rows[i]["credit"].ToString());
                                objc._prname = ds.Tables[0].Rows[i]["prname"].ToString();
                                Int64 ppid = Convert.ToInt64(ds.Tables[0].Rows[i]["PPID"].ToString()); 
                                objc._ppid = Convert.ToInt64(ds.Tables[0].Rows[i]["PPID"].ToString()); 
                                objc.order_insert();
                                using(productparameter obcpp=new productparameter())
                                {
                                    DataSet pp = new DataSet();
                                    obcpp.id = ppid;   
                                    pp = obcpp.productparameter_select_byid();
                                    ob = new Attachment(Server.MapPath("Admin\\upload\\orignal\\") + pp.Tables[0].Rows[0]["OProduct"].ToString());
                                    mail.Attachments.Add(ob);
                                }
                                
                            }
                            SmtpClient smtp = new SmtpClient();
                            smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                            smtp.Credentials = new System.Net.NetworkCredential("dreammultimediadm@gmail.com", "Dream143");
                            smtp.EnableSsl = true; // Other then smtp.gmail.com = false;
                            smtp.Send(mail);

                            mail = null;
                            smtp = null;
                        }

                        obj._orderid = Convert.ToInt64("1");
                        obj.cart_updateorderid();

                    }
  
                }
                else
                {
                    Response.Redirect("Packagesub.aspx");  
                }

            }
            
            Response.Redirect("Currentorder.aspx");  
            
        }
    }
}
