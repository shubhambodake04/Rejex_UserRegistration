using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Rejex_UserRegistration
{
    class UserInfo
    {
        const string FIRSTNAME = "^[A-Z][a-z]{2,}$";
        const string LASTNAME = "^[A-Z][a-z]{2,}$";
        const string EMAIL = "^[a-z0-9A-Z]+([._+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

        public Func<string, bool> ValidateFirstName = (input) =>
        { return Regex.IsMatch(input, FIRSTNAME); };
        public Func<string, bool> ValidateLastName = (input) =>
        { return Regex.IsMatch(input, LASTNAME); };
        public Func<string, bool> ValidateEmail = (input) =>
        { return Regex.IsMatch(input, EMAIL); };
    }
}
