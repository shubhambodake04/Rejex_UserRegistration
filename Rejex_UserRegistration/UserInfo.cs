using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Rejex_UserRegistration
{
    class UserInfo
    {
        string FirstName = "^[A-Z][a-z]{2,}$";
        string LastName = "^[A-Z][a-z]{2,}$";
        string Email = "^[a-z0-9A-Z]+([._+-@][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        string MobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";

        public bool validateUserInfo(string input)
        {
            return Regex.IsMatch(input, MobileNumber);
        }
    }
}
