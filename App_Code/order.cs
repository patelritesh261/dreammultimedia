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
/// Summary description for order
/// </summary>
public class order : IDisposable 
{
    SqlConnection objconn;
	public order()
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
    public Int64 _uid;
    public Int64 uid
    {
        get
        {
            return _uid;
        }
        set
        {
            _uid = value;
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
    public DateTime _date;
    public DateTime date
    {
        get {
            return _date; 
        }
        set {
            _date = value;  
        }
    }
    public String _cname;
    public String cname
    {
        get {
            return _cname; 
        }
        set {
            _cname = value;  
        }
    }
    public String _pname;
    public String pname
    {
        get
        {
            return _pname;
        }
        set
        {
            _pname = value;
        }
    }
    public String _pcode;
    public String pcode
    {
        get
        {
            return _pcode;
        }
        set
        {
            _pcode = value;
        }
    }
    public String _image;
    public String image
    {
        get
        {
            return _image;
        }
        set
        {
            _image = value;
        }
    }
    public String _prname;
    public String prname
    {
        get
        {
            return _prname;
        }
        set
        {
            _prname = value;
        }
    }
    public String _res;
    public String res
    {
        get
        {
            return _res;
        }
        set
        {
            _res = value;
        }
    }
    public Int64  _credit;
    public Int64  credit
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
    public String _size;
    public String size
    {
        get
        {
            return _size;
        }
        set
        {
            _size = value;
        }
    }
    public void order_insert()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_order_insert";
        obj.Connection = objconn;

        obj.Parameters.Add(new SqlParameter("@date", _date));
        obj.Parameters.Add(new SqlParameter("@pname", _pname));
        obj.Parameters.Add(new SqlParameter("@cname", _cname));
        obj.Parameters.Add(new SqlParameter("@pcode", _pcode));
        obj.Parameters.Add(new SqlParameter("@prname", _prname));
        obj.Parameters.Add(new SqlParameter("@res", _res));
        obj.Parameters.Add(new SqlParameter("@size", _size));
        obj.Parameters.Add(new SqlParameter("@credit", _credit));
        obj.Parameters.Add(new SqlParameter("@image", _image));
        obj.Parameters.Add(new SqlParameter("@uid", _uid));
        obj.Parameters.Add(new SqlParameter("@ppid", _ppid));

        int i=obj.ExecuteNonQuery(); 
    }
    public void order_delete()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandType = CommandType.StoredProcedure;
        obj.CommandText = "sp_order_delete";
        obj.Connection = objconn;

      
        obj.Parameters.Add(new SqlParameter("@oid", _id ));
        

        int i = obj.ExecuteNonQuery();
    }
    public DataSet top_order()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandText = "sp_order_top ";
        obj.CommandType=CommandType.StoredProcedure;
        obj.Connection = objconn;

        SqlDataAdapter adp = new SqlDataAdapter(obj);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        return ds;
    }
    public DataSet order_byuserid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandText = "sp_order_list ";
        obj.CommandType = CommandType.StoredProcedure;
        obj.Connection = objconn;

        obj.Parameters.Add(new SqlParameter("@uid", _uid));    
        SqlDataAdapter adp = new SqlDataAdapter(obj);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        return ds;
    }
    public DataSet order_selectall()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandText = "sp_order_manage ";
        obj.CommandType = CommandType.StoredProcedure;
        obj.Connection = objconn;

       
        SqlDataAdapter adp = new SqlDataAdapter(obj);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        return ds;
    }
    public DataSet order_byid()
    {
        SqlCommand obj = new SqlCommand();
        obj.CommandText = "sp_order_selectbyid ";
        obj.CommandType = CommandType.StoredProcedure;
        obj.Connection = objconn;

        obj.Parameters.Add(new SqlParameter("@id", _id));
        SqlDataAdapter adp = new SqlDataAdapter(obj);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        return ds;
    }
    public DataSet order_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_order_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _id));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
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
