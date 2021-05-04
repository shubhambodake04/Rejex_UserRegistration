using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Rejex_UserRegistration
{
    public class UserInfo
    {
       const string FIRSTNAME = "^[A-Z][a-z]{2,}$";

        public Func<string, bool> ValidateFirstName = (input) =>
        {return Regex.IsMatch(input, FIRSTNAME);};
        }
}
