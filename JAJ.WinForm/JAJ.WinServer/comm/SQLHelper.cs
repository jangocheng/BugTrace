using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// SqlHelper Ϊ SQL Server ���ݿ�Ļ���������    
/// </summary>
public abstract class SqlHelper
{
    /// <summary>
    /// ִ�з����������ڲ��������ݵ�SQL��䣬ͨ�������ַ���������Connection
    /// </summary>
    /// <param name="connectionString">���ݿ������ַ���</param>        
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����Ӱ�������</returns>
    public static int ExecuteNonQuery(String connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            int val = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            return val;
        }
    }

    /// <summary>
    /// ִ�з����������ڲ��������ݵ�SQL��䣬ͨ�����������ݿ�����Connection
    /// </summary>
    /// <param name="conn">���ݿ�����</param>        
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����Ӱ�������</returns>
    public static int ExecuteNonQuery(SqlConnection conn, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {

        SqlCommand cmd = new SqlCommand();

        PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
        int val = cmd.ExecuteNonQuery();
        cmd.Parameters.Clear();
        return val;
    }

    /// <summary>
    /// ִ�з����������ڲ��������ݵ�SQL��䣬ͨ�����������ݿ�����
    /// </summary>
    /// <param name="conn">���ݿ�����</param>        
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����Ӱ�������</returns>
    public static int ExecuteNonQuery(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();
        PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
        int val = cmd.ExecuteNonQuery();
        cmd.Parameters.Clear();
        return val;
    }

    /// <summary>
    /// ��ѯ�����������ڷ���ֻ�����ݵ�SQL��䣬ͨ�������ַ���������Connection
    /// </summary>
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����SqlDataReader���ݼ�</returns>
    public static SqlDataReader ExecuteReader(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn = new SqlConnection(connectionString);
        PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
        SqlDataReader rdr = cmd.ExecuteReader();
        cmd.Parameters.Clear();
        return rdr;

    }

    /// <summary>
    /// ��ѯ�����������ڷ���DataSet���ݵ�SQL��䣬ͨ�������ַ���������Connection
    /// </summary>
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����DataSet���ݼ�</returns>
    public static DataSet FillDataSet(String connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();
        DataSet dataSet = new DataSet();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataSet);
            cmd.Parameters.Clear();
            return dataSet;
        }
    }

    /// <summary>
    /// ִ�з����������ڲ��������ݵ�SQL��䣬ͨ�����������ݿ�����Connection
    /// </summary>
    /// <param name="conn">���ݿ�����</param>        
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����DataSet���ݼ�</returns>
    public static DataSet FillDataSet(SqlConnection conn, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();
        DataSet dataSet = new DataSet();

        PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataSet);
        cmd.Parameters.Clear();
        return dataSet;
    }

    /// <summary>
    /// ִ�з����������ڲ��������ݵ�SQL��䣬ͨ�����������ݿ�����
    /// </summary>
    /// <param name="conn">���ݿ�����</param>        
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>����Ӱ�������</returns>
    public static DataSet FillDataSet(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();
        DataSet dataSet = new DataSet();

        PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
        dataAdapter.Fill(dataSet);
        cmd.Parameters.Clear();
        return dataSet;
    }

    /// <summary>
    /// ִ�з����������ھ���һ������ֵ��SQL��䣬ͨ�������ַ���������Connection
    /// </summary>
    /// <param name="connectionString">���ݿ������ַ���</param>
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>���ض���</returns>
    public static object ExecuteScalar(string connectionString, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
            object val = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            return val;
        }
    }

    /// <summary>
    /// ִ�з����������ھ���һ������ֵ��SQL��䣬ͨ�����������ݿ�����Connection
    /// </summary>
    /// <param name="conn">���ݿ�����</param>
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>���ض���</returns>
    public static object ExecuteScalar(SqlConnection conn, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {

        SqlCommand cmd = new SqlCommand();

        PrepareCommand(cmd, conn, null, cmdType, cmdText, commandParameters);
        object val = cmd.ExecuteScalar();
        cmd.Parameters.Clear();
        return val;
    }

    /// <summary>
    /// ִ�з����������ھ���һ������ֵ��SQL��䣬ͨ�����������ݿ�����
    /// </summary>
    /// <param name="conn">���ݿ�����</param>        
    /// <param name="cmdType">Command����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="commandParameters">SQL��������</param>
    /// <returns>���ض���</returns>
    public static object ExecuteScalar(SqlTransaction trans, CommandType cmdType, string cmdText, params SqlParameter[] commandParameters)
    {
        SqlCommand cmd = new SqlCommand();
        PrepareCommand(cmd, trans.Connection, trans, cmdType, cmdText, commandParameters);
        object val = cmd.ExecuteScalar();
        cmd.Parameters.Clear();
        return val;
    }

    /// <summary>
    /// ��ʼ��SqlCommand
    /// </summary>
    /// <param name="cmd">SqlCommand�������</param>
    /// <param name="conn">SqlConnection�������</param>
    /// <param name="trans">SqlTransaction�������</param>
    /// <param name="cmdType">CommandType����</param>
    /// <param name="cmdText">SQL�ű�</param>
    /// <param name="cmdParms">SQL��������</param>
    private static void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, CommandType cmdType, string cmdText, SqlParameter[] cmdParms)
    {

        if (conn.State != ConnectionState.Open)
            conn.Open();

        cmd.Connection = conn;
        cmd.CommandText = cmdText;
        cmd.CommandTimeout = 6000;

        if (trans != null)
            cmd.Transaction = trans;

        cmd.CommandType = cmdType;

        if (cmdParms != null)
        {
            foreach (SqlParameter parm in cmdParms)
                cmd.Parameters.Add(parm);
        }
    }

    /// <summary>
    /// ��������ִ�ж���SQL���ķ���
    /// </summary>
    /// <param name="connectionString">���ݿ������ַ���</param>
    /// <param name="strSql">��������</param>
    /// <returns>ִ�н��</returns>
    public static bool ExecuteTransaction(string connectionString, string[] strSql, SqlParameter[] cmdParms)
    {
        bool flag = false;
        SqlConnection con = new SqlConnection(connectionString);
        if (con.State != ConnectionState.Open)
            con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;//�������
        SqlTransaction myTransaction;��//����һ��SQL��������
        myTransaction = con.BeginTransaction();//����һ�����ӳ�ʼ������

        try
        {

            for (int i = 0; i < strSql.Length; i++)
            {
                cmd.Transaction = myTransaction;//ָ��SQL������䡡������
                cmd.CommandText = strSql[i];//�����������
                if (i == 1)
                {
                    foreach (SqlParameter parm in cmdParms)
                        cmd.Parameters.Add(parm);
                }
                cmd.ExecuteNonQuery();//ִ��SQL���
            }
            myTransaction.Commit();
            flag = true;
        }
        catch //(Exception e)
        {
            myTransaction.Rollback();
            flag = false;
        }

        finally
        {
            con.Close();
            cmd.Dispose();
        }
        return flag;
    }
}

public static class CommJAJ
{
    public static string GetConnectionString()
    {
        string strServer = ConfigurationManager.AppSettings["server"];
        string strUid = ConfigurationManager.AppSettings["uid"];
        string strPwd = ConfigurationManager.AppSettings["pwd"];
        string strDb = ConfigurationManager.AppSettings["db"];
        string strcon = string.Format("Initial Catalog={0};Server={1};User ID={2};Password={3};Integrated Security=false;",
                                strDb, strServer, strUid, strPwd);
        return strcon;
    }
}
