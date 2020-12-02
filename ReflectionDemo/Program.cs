using System;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to demo project on reflection !!!");
            ReflectionOnCustomer reflection = new ReflectionOnCustomer();
            reflection.Test();
        }
    }
}
