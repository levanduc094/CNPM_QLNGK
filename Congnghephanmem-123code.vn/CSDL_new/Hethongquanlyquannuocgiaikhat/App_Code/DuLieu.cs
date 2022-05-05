using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

public class DuLieu
{
    public SqlConnection connect;
    public DuLieu()
    {
        connect = new SqlConnection(@"Data Source=DESKTOP-INJ9EQU\SQLEXPRESS;Initial Catalog=QuanLyNuocGiaKhat;Integrated Security=True");
    }
    public void OpenConnect()
    {
        if (connect.State == ConnectionState.Closed || connect.State == ConnectionState.Broken)
        {
            connect.Open();
        }
    }
    public void CloseConnect()
    {
        if (connect.State == ConnectionState.Connecting || connect.State == ConnectionState.Open)
        {
            connect.Close();
            connect.Dispose();
        }
    }
    public DataTable Select(string sql, SqlParameter[] sqlParams)
    {
        DataTable dt = new DataTable();
        try
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddRange(sqlParams);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            da.Fill(dt);
            return dt;
        }
        catch (Exception)
        {
            return null;
        }
        finally
        {
            CloseConnect();
        }
    }
    public int SaveChanges(string sql, SqlParameter[] sqlParams)
    {
        int result;
        try
        {
            OpenConnect();
            SqlCommand cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddRange(sqlParams);
            result = cmd.ExecuteNonQuery();
            CloseConnect();
        }
        catch (Exception)
        {
            result = -1;
        }
        finally
        {
            CloseConnect();
        }
        return result;
    }
}
