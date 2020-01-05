using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityPackages;
using System.Data.SqlClient;

namespace RepositoryPackages
{
    public class LoginInfoRepo
    {
        DatabaseConnectionClass dbc;
        public LoginInfoRepo()
        {
            dbc = new DatabaseConnectionClass();
        }
        public void InsertPersonLoginInfo(LoginInfo lf)
        {
            String query = "INSERT INTO LoginInfo(UserName,Password,VerificationCode) VALUES('"+lf.UserName+"','"+lf.Password+"',"+lf.VerificationCode+");";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                dbc.cmd.ExecuteNonQuery();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public LoginInfo GetLoginInfo(String UserName)
        {
            LoginInfo lf = null;
            String query = "SELECT UserName,Password,VerificationCode FROM LoginInfo WHERE UserName='" + UserName + "';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    lf = new LoginInfo();
                    lf.UserName = reader.GetString(0);
                    lf.Password = reader.GetString(1);
                    lf.VerificationCode = reader.GetInt32(2);
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lf;
        }
        public LoginInfo GetLoginInfo(String UserName,int VerificationCode)
        {
            LoginInfo lf = null;
            String query = "SELECT UserName,Password,VerificationCode FROM LoginInfo WHERE UserName='" + UserName + "', AND VerificationCode="+VerificationCode+";";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    lf = new LoginInfo();
                    lf.UserName = reader.GetString(0);
                    lf.Password = reader.GetString(1);
                    lf.VerificationCode = reader.GetInt32(2);
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lf;
        }

        public void RemoveLoginInfo(String UserName)
        {
            String query = "DELETE FROM LoginInfo WHERE UserName='" + UserName + "'";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                dbc.cmd.ExecuteNonQuery();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void UpdateLoginInfo(LoginInfo lf)
        {
            String query = "UPDATE LoginInfo SET UserName='" + lf.UserName + "',Password='" + lf.Password+ "',VerificationCode=" + lf.VerificationCode+" WHERE UserName='" + lf.UserName + "';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                dbc.cmd.ExecuteNonQuery();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
