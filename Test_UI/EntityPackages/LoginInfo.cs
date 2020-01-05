using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityPackages
{
    public class LoginInfo
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public int VerificationCode { get; set; }
        public LoginInfo()
        {

        }
        public LoginInfo(String UserName, String Password, int VerificationCode)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.VerificationCode = VerificationCode;
        }
    }
}
