using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using EntityPackages;
using System.Data;


namespace RepositoryPackages
{
    public class PersonRepo
    {
        DatabaseConnectionClass dbc;
        public PersonRepo()
        {
            dbc = new DatabaseConnectionClass();
        }

        public void InsertPerson(Persons p)
        {
            String query = "INSERT INTO Person(UserNameDB,FullNameDB,PasswordDB,AgeDB,GenderDB,AddressDB,MailDB,PhoneDB,PersonTypeDB,ProfilePic) VALUES('" + p.UserName + "','" + p.FullName + "','" + p.Password + "'," + p.Age + "," + p.Gender + ",'" + p.Address + "','" + p.Mail + "'," + p.Phone + "," + p.PersonType + ",'" + p.ProfilePic + "');";
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

        public Persons GetPerson(String UserName, String Password)
        {
            Persons p = null;
            String query = "SELECT UserNameDB,FullNameDB,PasswordDB,AgeDB,GenderDB,AddressDB,MailDB,PhoneDB,PersonTypeDB, ProfilePic FROM Person WHERE UserNameDB='" + UserName + "' AND PasswordDB='" + Password + "';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    p = new Persons();
                    p.UserName = reader.GetString(0);
                    p.FullName = reader.GetString(1);
                    p.Password = reader.GetString(2);
                    p.Age = reader.GetInt32(3);
                    p.Gender = reader.GetInt32(4);
                    p.Address = reader.GetString(5);
                    p.Mail = reader.GetString(6);
                    p.Phone = reader.GetInt32(7);
                    p.PersonType = reader.GetInt32(8);
                    p.ProfilePic = reader.GetString(9).Trim();
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

        public Persons GetPersonInfo(String UserName)
        {
            Persons p = null;
            String query = "SELECT UserNameDB,FullNameDB,PasswordDB,AgeDB,GenderDB,AddressDB,MailDB,PhoneDB,PersonTypeDB,ProfilePic FROM Person WHERE UserNameDB='" + UserName + "';";
            try
            {
                dbc.cmd = new SqlCommand(query, dbc.con);
                dbc.con.Open();
                SqlDataReader reader = dbc.cmd.ExecuteReader();
                while (reader.Read())
                {
                    p = new Persons();
                    p.UserName = reader.GetString(0);
                    p.FullName = reader.GetString(1);
                    p.Password = reader.GetString(2);
                    p.Age = reader.GetInt32(3);
                    p.Gender = reader.GetInt32(4);
                    p.Address = reader.GetString(5);
                    p.Mail = reader.GetString(6);
                    p.Phone = reader.GetInt32(7);
                    p.PersonType = reader.GetInt32(8);
                    p.ProfilePic = reader.GetString(9).Trim();
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

        public void RemovePerson(String UserName)
        {
            try
            {
                String query = "DELETE FROM Person WHERE UserNameDB='" + UserName + "'";
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
        public void UpdatePerson(Persons p)
        {
            String query = "UPDATE Person SET UserNameDB='" + p.UserName + "',PasswordDB='" + p.Password + "',FullNameDB='" + p.FullName + "',AgeDB=" + p.Age + ",GenderDB=" + p.Gender + ",AddressDB='" + p.Address + "',MailDB='" + p.Mail + "',PhoneDB=" + p.Phone + ",ProfilePic='"+p.ProfilePic+"' WHERE UserNameDB='" + p.UserName + "';";
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
            String query = "SELECT UserNameDB,FullNameDB,AgeDB,AddressDB,MailDB,PhoneDB FROM Person";
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
        public DataTable ShowAllData(int PersonType)
        {
            String query = "SELECT UserNameDB,FullNameDB,AgeDB,AddressDB,MailDB,PhoneDB FROM Person WHERE PersonTypeDB="+PersonType+";";
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

        public int GetPeronsCount()
        {
            int result = 0;
            String query = "SELECT COUNT(*) FROM Person;";
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
