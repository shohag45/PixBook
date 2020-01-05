using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace RepositoryPackages
{
    class DatabaseConnectionClass
    {
        public String conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\WorkPlace\\ProjectFiles\\PixBook\\Test_UI\\Test_UI\\TestDB.mdf;Integrated Security=True";
        public  SqlConnection con;
        public SqlCommand cmd;
        public DatabaseConnectionClass()
        {
            con = new SqlConnection(conString);
        }
    }
}
