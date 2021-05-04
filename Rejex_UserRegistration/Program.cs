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
            Console.ReadKey();
        }
    }
}
