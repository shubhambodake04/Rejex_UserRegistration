using System;

namespace Rejex_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo userinfo = new UserInfo();
            bool result = userinfo.ValidateFirstName("Shubham");
            Console.WriteLine(result);
            bool result1 = userinfo.ValidateLastName("Bodake");
            Console.WriteLine(result1);
            bool result2 = userinfo.ValidateEmail("Shubham@gmail.com");
            Console.WriteLine(result2);
            bool result3 = userinfo.ValidateMobileNumber("91 7757929383");
            Console.WriteLine(result3);
            bool result4 = userinfo.ValidatePasswordRule1("shubhambodake");
            Console.WriteLine(result4);
            Console.ReadKey();

        }
    }
}
