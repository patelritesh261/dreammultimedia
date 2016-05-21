using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;   
/// <summary>
/// Summary description for cart
/// </summary>
public class cart :IDisposable 
{
    SqlConnection objconn;
	public cart()
	{
		//
		// TODO: Add constructor logic here
		//
        String str = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        objconn = new SqlConnection(str);
        objconn.Open();    
	}

    public Int64 _id;
    public Int64 id
    {
        get {
            return _id;
        }
        set {
            _id = value;  
        }
    }

    public Int64 _userid;
    public Int64 userid
    {
        get
        {
            return _userid;
        }
        set
        {
            _userid = value;
        }
    }

    public String  _sessionid;
    public String  sessionid
    {
        get
        {
            return _sessionid;
        }
        set
        {
            _sessionid = value;
        }
    }

    public Int64 _productid;
    public Int64 productid
    {
        get
        {
            return _productid;
        }
        set
        {
            _productid = value;
        }
    }

    public Int64 _orderid;
    public Int64 orderid
    {
        get
        {
            return _orderid;
        }
        set
        {
            _orderid = value;
        }
    }
    public Int64 _ppid;
    public Int64 ppid
    {
        get
        {
            return _ppid;
        }
        set
        {
            _ppid = value;
        }
    }
    public Int64 _prid;
    public Int64 prid
    {
        get
        {
            return _prid;
        }
        set
        {
            _prid = value;
        }
    }
    public Int64   _credit;
    public Int64   credit
    {
        get
        {
            return _credit;
        }
        set
        {
            _credit = value;
        }
    }

    public void cart_insert()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_insert";
        obj.Connection=objconn;

        obj.Parameters.Add(new SqlParameter("@userid", _userid));
        obj.Parameters.Add(new SqlParameter("@sessionid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@productid", _productid));
        obj.Parameters.Add(new SqlParameter("@orderid", _orderid));
        obj.Parameters.Add(new SqlParameter("@ppid", _ppid));
        obj.Parameters.Add(new SqlParameter("@prid", _prid));
        obj.Parameters.Add(new SqlParameter("@credit", _credit));

        int i = obj.ExecuteNonQuery(); 
    }
    public DataSet  cart_selectbyusoid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_selectbyuosid ";
        obj.Connection = objconn;

         

        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));
    

        DataSet ds=new DataSet();
        SqlDataAdapter adp=new SqlDataAdapter(obj); 
        adp.Fill(ds);

        return ds;
    }
    public DataSet cart_total()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_total ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));


        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(obj);
        adp.Fill(ds);

        return ds;
    }
    public void cart_deletebyid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_deletebyid ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@id", _id));

        int i = obj.ExecuteNonQuery(); 
    }
    public void cart_clear()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_clear ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));

        int i=obj.ExecuteNonQuery(); 
    }
    public void cart_updateuserid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_updateuserid ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));

        int i = obj.ExecuteNonQuery();
    }
    public void cart_updatesessionid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_updatesessionid ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));

        int i = obj.ExecuteNonQuery();
    }
    public void cart_updateorderid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_updateorderid ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));

        int i = obj.ExecuteNonQuery();
    }


    public DataSet cart_details()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_details ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));
       


        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(obj);
        adp.Fill(ds);

        return ds;
    }

    public DataSet cart_selectbyuoid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_cart_selectbyuoid ";
        obj.Connection = objconn;



        obj.Parameters.Add(new SqlParameter("@uid", _userid));
        //obj.Parameters.Add(new SqlParameter("@sid", _sessionid));
        obj.Parameters.Add(new SqlParameter("@oid", _orderid));



        DataSet ds = new DataSet();
        SqlDataAdapter adp = new SqlDataAdapter(obj);
        adp.Fill(ds);

        return ds;
    }
   
    #region IDisposable Members

    public void Dispose()
    {
        if (objconn.State == ConnectionState.Open)
        {
            objconn.Close();
        }
        System.GC.SuppressFinalize(this);
    }

    #endregion
}
