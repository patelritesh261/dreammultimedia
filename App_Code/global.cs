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
/// Summary description for global
/// </summary>
public class global : IDisposable
{
    SqlConnection objconn;
	public global()
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
    public String _sitename;
    public String sitename
    {
        get
        {
            return _sitename;
        }
        set
        {
            _sitename = value;
        }
    }
    public String _surl;
    public String surl
    {
        get
        {
            return _surl;
        }
        set
        {
            _surl = value;
        }
    }
    public String _durl;
    public String durl
    {
        get
        {
            return _durl;
        }
        set
        {
            _durl = value;
        }
    }
    public String _email;
    public String email
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
    public String _pass;
    public String pass
    {
        get
        {
            return _pass;
        }
        set
        {
            _pass = value;
        }
    }
    public String _infoemail;
    public String infoemail
    {
        get
        {
            return _infoemail;
        }
        set
        {
            _infoemail = value;
        }
    }
    public String _mapadd;
    public String mapadd
    {
        get
        {
            return _mapadd;
        }
        set
        {
            _mapadd = value;
        }
    }
    public String _add;
    public String add
    {
        get
        {
            return _add;
        }
        set
        {
            _add = value;
        }
    }
    public String _hostname;
    public String hostname
    {
        get
        {
            return _hostname;
        }
        set
        {
            _hostname = value;
        }
    }
    public String _footer;
    public String footer
    {
        get
        {
            return _footer;
        }
        set
        {
            _footer = value;
        }
    }
    public String _paypal;
    public String paypal
    {
        get
        {
            return _paypal;
        }
        set
        {
            _paypal = value;
        }
    }
    public void global_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_global_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        objcmd.Parameters.Add(new SqlParameter("@sitename", _sitename ));
        objcmd.Parameters.Add(new SqlParameter("@surl", _surl ));
        objcmd.Parameters.Add(new SqlParameter("@durl", _durl));
        objcmd.Parameters.Add(new SqlParameter("@email", _email));
        objcmd.Parameters.Add(new SqlParameter("@pass", _pass ));
        objcmd.Parameters.Add(new SqlParameter("@infoemail", _infoemail ));
        objcmd.Parameters.Add(new SqlParameter("@mapad", _mapadd));
        objcmd.Parameters.Add(new SqlParameter("@add", _add ));
        objcmd.Parameters.Add(new SqlParameter("@hostname", _hostname));
        objcmd.Parameters.Add(new SqlParameter("@footer", _footer));
        objcmd.Parameters.Add(new SqlParameter("@paypal", _paypal ));


        int i = objcmd.ExecuteNonQuery();

    }
    public DataSet global_Select_byid()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_global_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

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
