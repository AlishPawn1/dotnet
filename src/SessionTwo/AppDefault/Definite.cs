using System;

namespace dotnet.src.SessionTwo.AppDefault
{
    public class Definite
    {
        // fields are initialized with default values
        private static int age = 0;
        private static bool isOn = false;
        private static string? name = null;

        public static void run()
        {
            // local variable must be assigned a value
            int point = 10;

            // arrays are initialized with default values
            int[] numbers = new int[5];
            string[] sports = new string[2];

            Console.WriteLine($"Is on? = {isOn}");
            Console.WriteLine($"Point is {point}");
            Console.WriteLine($"Name = {name ?? "Empty"}\tAge = {age}");
            Console.WriteLine($"The first value of sports =  {sports[0] ?? "None"}");
            Console.WriteLine($"The first value of numbers =  {numbers[0]}");

            // Call the AddTwoNumber method
            AddTwoNumber(1, 2);
        }

        // Argument must be supplied when a method is called
        private static void AddTwoNumber(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine($"Sum of {a} and {b} is {sum}");
        }
    }
}
