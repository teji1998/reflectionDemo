using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionDemo
{
    class ReflectionOnCustomer
    {
        public void Test() {
            Type type = Type.GetType("ReflectionDemo.CustomerInfo");//Path
            Console.WriteLine("full name:{0}", type.FullName);
            Console.WriteLine("class name:{0}", type.Name);
            Console.WriteLine("method in customer class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name +" " + method.Name);

            }
            Console.WriteLine(  "properties");
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);

            }
            Console.WriteLine("constructor");
            ConstructorInfo[] constructor = type.GetConstructors();
            foreach (ConstructorInfo method in constructor)
            {
                Console.WriteLine(constructor.ToString());

            }



        }
    }
}
