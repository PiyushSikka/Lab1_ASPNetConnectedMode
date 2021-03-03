 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Configuration; // required for configuration manager
using System.Data.SqlClient; // required for ADO.net object  model 

namespace Lab1_ASPNetConnectedMode.DAL
{
    public static class UtilityDB
    {
        // # version 1

        //public static SqlConnection ConnectDB()
        //{
        //    SqlConnection conn = new SqlConnection();
        //    conn.ConnectionString = @"server=LAPTOP-F61TLNAB\SQLSERVEREXPRESS;database=EmployeeDB;user=sa;password=12345";
        //    conn.Open();
        //    return conn;
        //}

        // # Version 2
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB_Connection"].ConnectionString;
            conn.Open();
            return conn;
        }
    }
}