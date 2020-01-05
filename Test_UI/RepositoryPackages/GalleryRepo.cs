using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityPackages;
using System.Data.SqlClient;

namespace RepositoryPackages
{
    public class GalleryRepo
    {
        DatabaseConnectionClass dbc;
        public GalleryRepo()
        {
            dbc = new DatabaseConnectionClass();
        }

        public void InsertIntoGallery(Gallery g)
        {
            String query = "INSERT INTO Gallery(UserName,pic1,pic2,pic3,pic4,pic5,pic6,pic7,pic8,pic9,pic10) VALUES('" + g.UserName + "','" + g.Pic1 + "','" + g.Pic2 + "','" + g.Pic3 + "','" + g.Pic4 + "','" + g.Pic5 + "','" + g.Pic6 + "','" + g.Pic7 + "','" + g.Pic8 + "','" + g.Pic9 + "','" + g.Pic10 + "');";
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

        public void UpdateGallery(Gallery g)
        {
            String query = "UPDATE Gallery SET UserName='" + g.UserName + "',pic1='" + g.Pic1+ "',pic2='" + g.Pic2+ "',pic3='" + g.Pic3+"',pic4='" + g.Pic4+ "',pic5='" + g.Pic5+"',pic6='" + g.Pic6+ "',pic7='" + g.Pic7+ "',pic8='" + g.Pic8+ "',pic9='"+g.Pic9+"',pic10='"+g.Pic10+"' WHERE UserName='" + g.UserName + "';";
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

        public void RemoveFromGallery(String UserName)
        {
            try
            {
                String query = "DELETE FROM Gallery WHERE UserName='" + UserName + "'";
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

        public Gallery GetGalleryInfo(String UserName)
        {
            Gallery g  = null;
            String query = "SELECT UserName,pic1,pic2,pic3,pic4,pic5,pic6,pic7,pic8,pic9,pic10 FROM Gallery WHERE UserName='" + UserName + "';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    g = new Gallery();
                    g.UserName = reader.GetString(0);
                    g.Pic1 = reader.GetString(1);
                    g.Pic2 = reader.GetString(2);
                    g.Pic3 = reader.GetString(3);
                    g.Pic4 = reader.GetString(4);
                    g.Pic5 = reader.GetString(5);
                    g.Pic6 = reader.GetString(6);
                    g.Pic7 = reader.GetString(7);
                    g.Pic8 = reader.GetString(8);
                    g.Pic9 = reader.GetString(9);
                    g.Pic10 = reader.GetString(10);
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return g;
        }

        public int GetHireCount()
        {
            int result = 0;
            String query = "SELECT COUNT(*) FROM HireDB;";
            try
            {
                dbc.cmd = new SqlCommand(query,dbc.con);
                dbc.con.Open();
                result = dbc.cmd.ExecuteNonQuery();
                dbc.con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
