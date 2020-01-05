using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityPackages;
using System.Data.SqlClient;
using System.Data;

namespace RepositoryPackages
{
    public class PhotographerRepo
    {
        DatabaseConnectionClass dbc;
        public PhotographerRepo()
        {
            dbc = new DatabaseConnectionClass();
        }

        public void InsertPhotographer(Photographers p)
        {
            String query = "INSERT INTO Photographer(UserNameDB,ExperienceDB,GenresDB,FeesDB) VALUES('" + p.UserName + "'," +p.Experience+",'"+p.Genres+"',"+p.Fees+");";
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

        public Photographers GetPhotographer(String UserName)
        {
            Photographers pg = null;
            String query = "SELECT UserNameDB,ExperienceDB,GenresDB,FeesDB FROM Photographer WHERE UserNameDB='" + UserName+"';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    pg = new Photographers();
                    pg.UserName = reader.GetString(0);
                    pg.Experience = Convert.ToInt32(reader.GetString(1));
                    pg.Genres = reader.GetString(2);
                    pg.Fees = Convert.ToDouble(reader.GetString(3));
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return pg;
        }


        public Photographers GetPhotographerInfo(String UserName)
        {
            Photographers p = null;
            String query = "SELECT UserNameDB,ExperienceDB,GenresDB,FeesDB FROM Photographer WHERE UserNameDB='" + UserName + "';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    p = new Photographers();
                    p.UserName = reader.GetString(0);
                    p.Experience = reader.GetInt32(1);
                    p.Genres = reader.GetString(2);
                    p.Fees = reader.GetDouble(3);
                }
                reader.Close();
                dbc.con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return p;
        }


        public void RemovePhotographer(String UserName)
        {
            String query = "DELETE FROM Photographer WHERE UserNameDB='" + UserName + "';";
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

        public void UpdatePhotographer(Photographers p)
        {
            String query = "UPDATE Photographer SET UserNameDB='" + p.UserName + "',ExperienceDB=" + p.Experience + ",GenresDB='" + p.Genres + "',FeesDB=" + p.Fees + ";";
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
        public DataTable ShowAllData()
        {
            String query = "SELECT Person.UserNameDB,Person.FullNameDB,Person.AgeDB,Person.AddressDB,Person.MailDB,Person.PhoneDB, Photographer.ExperienceDB, Photographer.GenresDB,Photographer.FeesDB FROM Person inner join Photographer on Person.UserNameDB=Photographer.UserNameDB";
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
        public int GetPhotographerCount()
        {
            int result=0;
            String query = "SELECT COUNT(*) FROM Photographer";
            try
            {
                dbc.cmd = new SqlCommand(query,dbc.con);
                dbc.con.Open();
                result = Convert.ToInt32(dbc.cmd.ExecuteScalar());
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
