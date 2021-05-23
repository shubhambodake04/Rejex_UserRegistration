using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Rejex_UserRegistration
{
    class Reflection
    {
        public static void ReflectionDemo()
        {
            Type type = Type.GetType("Rejex_UserRegistration.UserInfo");
            Console.WriteLine("----Class: " +type.Name);
            Console.WriteLine("----Class: " + type.FullName);

            Console.WriteLine("Methods in customerInfo class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("----method:  " + method.Name);
                ParameterInfo[] parameters = method.GetParameters();
                foreach(var parm in parameters)
                {
                    Console.WriteLine("---Parameter: " +parm.Name + " : " +parm.ParameterType);
                }
            }
           

        }
    }
}
