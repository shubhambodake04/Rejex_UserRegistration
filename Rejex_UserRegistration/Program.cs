﻿using System;

namespace Rejex_UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInfo userinfo = new UserInfo();
            bool result = userinfo.validateUserInfo("7757929383");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
