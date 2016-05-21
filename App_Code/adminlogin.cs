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
/// Summary description for adminlogin
/// </summary>
public class adminlogin:IDisposable 
{
    SqlConnection objconn;
    public adminlogin()
    {
        //
        // TODO: Add constructor logic here
        //
        String str = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        objconn = new SqlConnection(str);
        objconn.Open();
    }
    public String _username;//variable
    public String username
    {
        get
        {
            return _username;
        }
        set
        {
            _username = value;
        }

    }//property

    public String _password;//variable
    public String password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
        }

    }//property

    public DataSet selectadmin()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_selectadmin";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@username", _username));
        objcmd.Parameters.Add(new SqlParameter("@password", _password));

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
