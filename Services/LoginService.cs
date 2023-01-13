using Donation_Management_System_alpha_ver.Entities;
using Donation_Management_System_alpha_ver.Repsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_Management_System_alpha_ver.Services
{
    public class LoginService
    {
        LoginRepo loginRepo;
        public LoginService()
        {
            loginRepo = new LoginRepo();
        }

        public int LoginServiceValidation(string username, string password)
        {
            return loginRepo.LoginRepoValidation(new User() { Username = username, Password = password });
        }
    }
}
