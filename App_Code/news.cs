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
/// Summary description for news
/// </summary>
public class news :IDisposable 
{
    SqlConnection objconn;
	public news()
	{
		//
		// TODO: Add constructor logic here
		//
        String str = ConfigurationManager.ConnectionStrings["myconn"].ToString();
        objconn =new SqlConnection(str);
        objconn.Open();
	}
    public Int64 _id;
    public Int64 id
    {
        get {
            return _id;
        }
        set
        {
            _id = value; 
        }
    }
    public String _title;
    public String title
    {
        get {
            return _title; 
        }
        set {
            _title = value; 
        }
    }
    public String _sdesc;
    public String sdesc
    {
        get {
            return _sdesc; 
        }
        set {
            _sdesc = value;
        }
    }
    public String _fdesc;
    public String fdesc
    {
        get
        {
            return _fdesc;
        }
        set
        {
            _fdesc = value;
        }
    }
    public Int64 _rank;
    public Int64 rank
    {
        get { 
            return _rank ;
        }
        set {
            _rank = value; 
        }
    }
    public String  _date;
    public String  date
    {
        get {
            return _date;
        }
        set {
            _date = value; 
        }
    }
    public Boolean _active;
    public Boolean active
    {
        get {
            return _active; 
        }
        set {
            _active = value;
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


    public void news_insert()
    {
        SqlCommand objcmd=new SqlCommand() ;
        objcmd.CommandText = "sp_news_insert";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
  
        objcmd.Parameters.Add(new SqlParameter ("@title",_title));
        objcmd .Parameters.Add(new SqlParameter ("@sdesc",_sdesc));
        objcmd.Parameters .Add (new SqlParameter ("@fdesc",_fdesc));
        objcmd .Parameters.Add (new SqlParameter("@rank",_rank));
        objcmd.Parameters.Add(new SqlParameter ("@date",_date ));
        objcmd.Parameters.Add(new SqlParameter ("@active",_active));

        int i=objcmd.ExecuteNonQuery();  
    }

    public void news_update()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_news_update";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));
        objcmd.Parameters.Add(new SqlParameter("@title", _title));
        objcmd.Parameters.Add(new SqlParameter("@sdesc", _sdesc));
        objcmd.Parameters.Add(new SqlParameter("@fdesc", _fdesc));
        objcmd.Parameters.Add(new SqlParameter("@rank", _rank));
        objcmd.Parameters.Add(new SqlParameter("@date", _date));
        objcmd.Parameters.Add(new SqlParameter("@active", _active));

        int i = objcmd.ExecuteNonQuery();
     }

    public void news_delete()
    {
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_news_delete";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id", _id));

        int i = objcmd.ExecuteNonQuery();  

  
    }
    public DataSet news_selectall()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_news_selectall";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
   
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);
 
        return dsg;
    }

    public DataSet news_select_byid()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_news_selectbyid";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        objcmd.Parameters.Add(new SqlParameter("@id",_id));
     
        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
    }
    public DataSet news_Select_Searchdata()
    {
        ///command
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_news_selectserch";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;
        //end of command

        objcmd.Parameters.Add(new SqlParameter("@name", _serch));

        DataSet dsReg = new DataSet();
        SqlDataAdapter objA = new SqlDataAdapter(objcmd);
        objA.Fill(dsReg);

        return dsReg;
    }
    public DataSet news_selectbind()
    {
        DataSet dsg = new DataSet();
        SqlCommand objcmd = new SqlCommand();
        objcmd.CommandText = "sp_news_selectbind";
        objcmd.CommandType = CommandType.StoredProcedure;
        objcmd.Connection = objconn;

        SqlDataAdapter sda = new SqlDataAdapter(objcmd);
        sda.Fill(dsg);

        return dsg;
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
