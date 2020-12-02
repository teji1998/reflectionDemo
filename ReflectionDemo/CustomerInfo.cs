using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    public class CustomerInfo
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public CustomerInfo(int id, string name)
        {
            this.Id = id;
            this.ClassName = name;
        }

        public CustomerInfo()
        {
            this.Id = -1;
            this.ClassName = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("Id is : {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is : {0}", this.ClassName);
        }
    }
}
