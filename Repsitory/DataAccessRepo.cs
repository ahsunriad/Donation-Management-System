using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management_System_alpha_ver.Repsitory
{
    public class DataAccessRepo: IDisposable
    {
        private SqlConnection connection;
        private SqlCommand command;
        public DataAccessRepo()
        {
            this.connection = new SqlConnection(@"data source=DESKTOP-Q3BOB8E;initial catalog=DonationManagementSystem;integrated security=true;");
           
            //this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SuperShop"].ConnectionString);
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql,this.connection);
            return this.command.ExecuteReader();
        }

        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql,this.connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
