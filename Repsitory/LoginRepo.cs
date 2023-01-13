using Donation_Management_System_alpha_ver.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management_System_alpha_ver.Repsitory
{
    public class LoginRepo
    {
        DataAccessRepo dataAccess;
        public LoginRepo()
        {
            dataAccess = new DataAccessRepo();
        }

        public int LoginRepoValidation(User user)
        {
            dataAccess = new DataAccessRepo();
            string sql = "SELECT * FROM Users WHERE Username='"+user.Username+"' AND Password='"+user.Password+"'";
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();

            // system check change
            string status = (string)reader["UserType"]; //(int)reader["UserType"];
            if (status == "admin")
            {
                return 1;
            }
            else if (status == "user")
            {
                return 2;
            }
            else if (status == "volunteer")
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
