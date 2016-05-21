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
/// Summary description for Contactus
/// </summary>
public class Contactus : IDisposable 
{
    SqlConnection objconn;
	public Contactus()
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
        get
        {
            return _id;
        }
        set
        {
            _id = value;
        }
    }
    public string _name;
    public string name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }
    public string _email;
    public string email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;
        }
    }
    public Int64 _phone;
    public Int64 phone
    {
        get
        {
            return _phone;
        }
        set
        {
            _phone = value;
        }
    }
    public string _message;
    public string message
    {
        get
        {
            return _message;
        }
        set
        {
            _message = value;
        }
    }
    public String _serch;
    public String serch
    {
        get
        {
            return _serch;
        }
        set
        {
            _serch = value;
        }
    }
    public void contactus_insert()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblContactus_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;


        objcmd.Parameters.Add(new SqlParameter("@name", _name));
        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        objcmd.Parameters.Add(new SqlParameter("@phone", _phone));
        objcmd.Parameters.Add(new SqlParameter("@message", _message));

        int i = objcmd.ExecuteNonQuery();
    }
    public void contactus_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblContactus_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@cid", _id));
        int i = objcmd.ExecuteNonQuery();
    }
    public void contactus_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblContactus_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@cid", _id));
        objcmd.Parameters.Add(new SqlParameter("@name", _name));
        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        objcmd.Parameters.Add(new SqlParameter("@phone", _phone));
        objcmd.Parameters.Add(new SqlParameter("@message", _message));

        int i = objcmd.ExecuteNonQuery();

    }
    public DataSet contactus_selectall()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblContactus_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet contactus_select_byid()
    {
        DataSet ds = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_tblContactus_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        objcmd.Parameters.Add(new SqlParameter("@cid", _id));
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(ds);
        return ds;
    }
    public DataSet Contactus_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_contactus_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

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
