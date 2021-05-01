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
            Console.ReadKey();
        }
    }
}
