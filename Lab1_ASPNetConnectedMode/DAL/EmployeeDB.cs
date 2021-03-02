using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Lab1_ASPNetConnectedMode.BLL;

namespace Lab1_ASPNetConnectedMode.DAL
{
    public static class EmployeeDB
    {
        public static bool IsDuplicateId(int id)
        {
            int flag = 0;
            SqlConnection conn = UtilityDB.ConnectDB();

            SqlCommand cmdValidate = new SqlCommand();
            cmdValidate.CommandText = "SELECT EmployeeId FROM Employees WHERE EmployeeId = @EmployeeId";
            cmdValidate.Parameters.AddWithValue("@EmployeeId", id);

            cmdValidate.Connection = conn;
            SqlDataReader reader = cmdValidate.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToInt32(id) == Convert.ToInt32(reader["EmployeeId"]))
                {
                    flag = 1;
                }
            }
            conn.Close();
            conn.Dispose();
            if (flag == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //version 1
        //public static void SaveRecord(Employee emp)
        //{
        //    //1 connect to databse 
        //    SqlConnection conn = UtilityDB.ConnectDB();

        //    //2 create and customize a sqlcommand object
        //    SqlCommand cmdInsert = new SqlCommand();
        //    cmdInsert.CommandText = "INSERT INTO Employees VALUES(" 
        //        + emp.EmployeeId + ",'" 
        //        + emp.FirstName + "','" 
        //        + emp.LastName + "','" 
        //        + emp.JobTitle + "');";
        //    cmdInsert.Connection = conn;

        //    //3 perform the insert operation
        //    cmdInsert.ExecuteNonQuery();

        //    //4 close the connection
        //    conn.Close();

        //}

        public static void SaveRecord(Employee emp)
        {
            // version 2  : using parameterized query :  Easy to write, less error, no sql injection
            //1 connect to databse 
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.CommandText = "INSERT INTO Employees(EmployeeId,FirstName,LastName,JobTitle) VALUES (@EmployeeId,@FirstName,@LastName,@JobTitle)"; //parameterized query
                cmdInsert.Connection = conn;
                cmdInsert.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmdInsert.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmdInsert.Parameters.AddWithValue("@LastName", emp.LastName);
                cmdInsert.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
                cmdInsert.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                //4 close the connection
                conn.Close();
                conn.Dispose(); // //return memory back to system  
            }
        }

        public static List<Employee> GetListRecords()
        {

            List<Employee> listEmp = new List<Employee>();
            SqlConnection conn = UtilityDB.ConnectDB();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conn;
            cmdSelect.CommandText = "Select * from  Employees";
            SqlDataReader reader = cmdSelect.ExecuteReader();
            Employee emp;
            while (reader.Read())
            {
                emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(reader["EmployeeId"]);
                emp.FirstName = reader["FirstName"].ToString();
                emp.LastName = reader["LastName"].ToString();
                emp.JobTitle = reader["JobTitle"].ToString();
                listEmp.Add(emp);
            }

            return listEmp;
        }

        public static void UpdateRecord(Employee emp)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.CommandText = "UPDATE Employees SET EmployeeId = @EmployeeId,FirstName = @FirstName, LastName = @LastName , JobTitle = @JobTitle WHERE EmployeeId = @EmployeeId";
                cmdUpdate.Connection = conn;
                cmdUpdate.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmdUpdate.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmdUpdate.Parameters.AddWithValue("@LastName", emp.LastName);
                cmdUpdate.Parameters.AddWithValue("@JobTitle", emp.JobTitle);

                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static void DeleteRecord(Employee emp)
        {
            SqlConnection conn = UtilityDB.ConnectDB();
            try
            {
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.CommandText = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";
                cmdDelete.Connection = conn;
                cmdDelete.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}