﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace JAJ.WinForm.Comm
{
    /// <summary>
    /// EF扩展，支持直接执行sql返回 DataTable
    /// </summary>
    public static class EFExtend
    {
        /// <summary>
        /// EF SQL 语句返回 dataTable
        /// </summary>
        /// <param name="db"></param>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DataTable SqlQueryForDataTatable(this Database db,
                 string sql,
                 params SqlParameter[] parameters)
        {

            SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = db.Connection.ConnectionString;
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;

            if (parameters.Length > 0)
            {
                foreach (var item in parameters)
                {
                    cmd.Parameters.Add(item);
                }
            }


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
