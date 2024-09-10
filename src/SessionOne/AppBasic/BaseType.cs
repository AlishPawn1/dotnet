using System;

namespace dotnet.src.SessionOne.AppBasic
{
    public static class BaseType
    {
        public static void Run()
        {
            int numOne = 10;
            int numTwo = 20;
            int sum = numOne + numTwo;

            DateTime currentTime = DateTime.Now;


            const string firstName = "Jone";

            Console.WriteLine("the sum is :" + sum);
            Console.WriteLine("the name is :" + firstName.ToLower());
            Console.WriteLine($"Time:{currentTime}");
            Console.WriteLine("Types");
            Console.WriteLine($"numOne >> {numOne.GetType()}");
        }
    }
}
