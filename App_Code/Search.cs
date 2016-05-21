using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data; 
using System.Data.SqlClient;   

/// <summary>
/// Summary description for Search
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
 [System.Web.Script.Services.ScriptService]
public class Search : System.Web.Services.WebService {
    
    public Search () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
       
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public string[] searchdata(string prefixText , int count)
    { 
        
         if (count == 0)
        {
            count = 10;
        }
         List<string> items = new List<string>(count);
        
        using(product obj=new product())
        {
            DataSet ds=new DataSet(); 
            obj._serch=prefixText.ToString();
            ds=obj.product_Select_Searchdata();
            for(int i=0;i<ds.Tables[0].Rows.Count;i++)
            {
                items.Add(ds.Tables[0].Rows[i]["Name"].ToString());     
            }

        }
        return   items.ToArray();  
    }
    
}

