using System;
using System.Net.Sockets;
using System.Threading.Channels;

namespace dotnet.src.SessionOne.AppOperater
{
    public class User
    {
        private const int Age = 30;
        private const bool IsMarried = true;
        // private const string Name = "John Doe";

        public string? Name { get; set; }
        public Address? Address { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age}\nIsMarried: {IsMarried}\nAddress: {Address}");
        }
    }
    public class Address
    {
        public string? street { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("This is inside Address");
        }
    }


    public class Theme
    {
        public void ShowInfo()
        {
            Console.WriteLine("This is inside Theme");
        }
    }

    public static class Miscellaneous
    {
        public static unsafe void Run()
        {
            int year = 2024;
            int intSize = sizeof(int);
            int charSize = sizeof(char);
            int floatSize = sizeof(float);
            int doubleSize = sizeof(double);

            int* yearPtr = &year;

            Console.WriteLine(
                $"sizeof(int) = {intSize}\n" +
                $"sizeof(char) = {charSize}\n" +
                $"sizeof(float) = {floatSize}\n" +
                $"sizeof(double) = {doubleSize}\n"
            );

            Console.WriteLine($"type of int = {typeof(int)}");
            Console.WriteLine($"type of char = {typeof(char)}");

            Console.WriteLine($"'year' address in memory = " + (int)yearPtr);
            Console.WriteLine($"'year' value in memory = " + *yearPtr);

            User john = new User();

            // exercise 1

            if (john is User)
            {
                Console.WriteLine();
                john.ShowInfo();
            }

            object? planet = null;
            string? mercury = planet as string ?? "Earth";

            Console.WriteLine($"\nmercury = {mercury}");
            
            // int maxResult = CheckMax(a: 40, b: 40);

            int maxResult = CheckMax(a: 42, b: 41, c: 43);

            Console.WriteLine($"\n MAx is {maxResult}");

        }

        // exercise 2

        //private static int CheckMax(int a, int b)
        //{
            // return a > b ? a : b;

          //  return a == b ? 0 : a > b ? a : b;

//        }
        private static int CheckMax(int a , int b, int c)
        {
        return  (a == b && a == c)  ? 0 : (a > b && a > c) ? a : (b > a && b > c) ? b : c;
        }
    }
}
