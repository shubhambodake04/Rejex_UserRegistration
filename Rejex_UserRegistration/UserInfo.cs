﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Rejex_UserRegistration
{
    public class UserInfo
    {
<<<<<<< HEAD
       public string FirstName = "^[A-Z][a-z]{2,}$";
       public string LastName = "^[A-Z][a-z]{2,}$";
       public string Email = "^[a-z0-9A-Z]+([._+-@][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
       public string MobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";
       public string Password = "^[a-zA-Z]{8,}$";
       public string PasswordRule2 = "^[A-Z]+[a-zA-Z]{8,}$";
       public string PasswordRule3 = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8,20}$";


=======
       const string FIRSTNAME = "^[A-Z][a-z]{2,}$";
>>>>>>> UC1_FIRSTNAME

        public Func<string, bool> ValidateFirstName = (input) =>
        {
<<<<<<< HEAD
            return Regex.IsMatch(input, FirstName);
        }
        public bool ValidateLastName(string input)
        {
            return Regex.IsMatch(input, LastName);
        }
        public bool ValidateEmail(string input)
        {
            return Regex.IsMatch(input, Email);
        }
        public bool ValidateMobileNumber(string input)
        {
            return Regex.IsMatch(input, MobileNumber);
        }
        public bool ValidatePassword(string input)
        {
            return Regex.IsMatch(input, Password);
        }
        public bool ValidatePasswordRule2(string input)
        {
            return Regex.IsMatch(input, PasswordRule2);
        }
        public bool ValidatePasswordRule3(string input)
        {
            return Regex.IsMatch(input, PasswordRule3);
        }

       
=======
            return Regex.IsMatch(input, FIRSTNAME);
        };
        
>>>>>>> UC1_FIRSTNAME
    }
}
