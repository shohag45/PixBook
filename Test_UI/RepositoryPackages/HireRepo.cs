using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityPackages;
using System.Data.SqlClient;
using System.Data;

namespace RepositoryPackages
{
    public class HireRepo
    {

        DatabaseConnectionClass dbc;
        public HireRepo()
        {
            dbc = new DatabaseConnectionClass();
        }
        public void InsertHireInfo(Hire h)
        {
            String query = "INSERT INTO HireDB(HireIdDB,UserNameDB,PhotographerNameDB,HireFromDB,HireToDB,PlaceDB,RequestStatusDB) VALUES("+h.HireId+",'"+h.UserName+"','"+h.PhotographerName+"','"+h.HireFrom+"','"+h.HireTo+"','"+h.Place+"',"+h.RequestStatus+");";
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

        public Hire GetHireInfo(int hireid)
        {
            Hire h = null;
            String query = "SELECT HireIdDB,UserNameDB,PhotographerNameDB,HireFromDB,HireToDB,PlaceDB,RequestStatusDB FROM HireDB WHERE HireIdDB=" + hireid+ ";";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    h = new Hire();
                    h.HireId = reader.GetInt32(0);
                    h.UserName = reader.GetString(1);
                    h.PhotographerName = reader.GetString(2);
                    h.HireFrom = reader.GetDateTime(3);
                    h.HireTo = reader.GetDateTime(4);
                    h.Place = reader.GetString(5);
                    h.RequestStatus = reader.GetInt32(6);
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return h;
        }

        public Hire GetHireInfo(String PhotographerName)
        {
            Hire h = null;
            String query = "SELECT HireIdDB,UserNameDB,PhotographerNameDB,HireFromDB,HireToDB,PlaceDB,RequestStatusDB FROM HireDB WHERE PhotographerNameDB='"+PhotographerName+"';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    h = new Hire();
                    h.HireId = reader.GetInt32(0);
                    h.UserName = reader.GetString(1);
                    h.PhotographerName = reader.GetString(2);
                    h.HireFrom = reader.GetDateTime(3);
                    h.HireTo = reader.GetDateTime(4);
                    h.Place = reader.GetString(5);
                    h.RequestStatus = reader.GetInt32(6);
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return h;
        }
        public DataTable ShowAllData()
        {
            String query = "SELECT HireIdDB,UserNameDB,PhotographerNameDB,HireFromDB,HireToDB,PlaceDB,RequestStatusDB FROM HireDB";
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter(query, dbc.con);
                dt = new DataTable();
                DataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            return dt;
        }
        public DataTable ShowAllData(String UserName)
        {
            String query = "SELECT HireIdDB,UserNameDB,PhotographerNameDB,HireFromDB,HireToDB,PlaceDB,RequestStatusDB FROM HireDB WHERE UserNameDB='"+UserName+"';";
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter(query, dbc.con);
                dt = new DataTable();
                DataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            return dt;
        }
        public DataTable ShowAllPhotographerData(String PhotographerName)
        {
            String query = "SELECT HireIdDB,UserNameDB,PhotographerNameDB,HireFromDB,HireToDB,PlaceDB,RequestStatusDB FROM HireDB WHERE PhotographerNameDB='" +PhotographerName+ "';";
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter DataAdapter = new SqlDataAdapter(query, dbc.con);
                dt = new DataTable();
                DataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }
            return dt;
        }

        public void UpdateHireInfo(Hire h)
        {
            String query = "UPDATE HireDB SET HireIdDB=" +h.HireId+ ",UserNameDB='" + h.UserName+ "',PhotographerNameDB='" + h.PhotographerName+ "',HireFromDB='" + h.HireFrom+ "',HireToDB='" + h.HireTo+ "',PlaceDB='" + h.Place+ "',RequestStatusDB=" + h.RequestStatus+ " WHERE HireIdDB=" + h.HireId+ ";";
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

        public void RemoveHireInfo(int hireId)
        {
            try
            {
                String query = "DELETE FROM HireDB WHERE HireIdDB=" + hireId + ";";
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
        public void RemoveHireInfo(String UserName)
        {
            try
            {
                String query = "DELETE FROM HireDB WHERE UserNameDB='"+UserName+"';";
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

        public int GetHireCount()
        {
            int result = 0;
            String query = "SELECT COUNT(*) FROM HireDB;";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                result = Convert.ToInt32(dbc.cmd.ExecuteScalar());
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }

        public void GetHireInfoCount(out int Pending, out int Accepted, out int Rejected)
        {
            Pending  = 0;
            Accepted = 0;
            Rejected = 0;
            String query1 = "SELECT COUNT(HireIdDB) FROM HireDB WHERE RequestStatusDB=0;";
            String query2 = "SELECT COUNT(HireIdDB) FROM HireDB WHERE RequestStatusDB=1;";
            String query3 = "SELECT COUNT(HireIdDB) FROM HireDB WHERE RequestStatusDB=2;";
            try
            {
                dbc.cmd = new SqlCommand(query1, dbc.con);
                dbc.con.Open();
                Pending= Convert.ToInt32(dbc.cmd.ExecuteScalar()); 
                dbc.con.Close();

                dbc.cmd = new SqlCommand(query2, dbc.con);
                dbc.con.Open();
                Accepted = Convert.ToInt32(dbc.cmd.ExecuteScalar());
                dbc.con.Close();

                dbc.cmd = new SqlCommand(query3, dbc.con);
                dbc.con.Open();
                Rejected = Convert.ToInt32(dbc.cmd.ExecuteScalar());
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
