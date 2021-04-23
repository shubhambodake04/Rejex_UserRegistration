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

        public bool validateUserInfo(string input)
        {
            return Regex.IsMatch(input, Email);
        }
    }
}
