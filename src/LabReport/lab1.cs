using System;

namespace dotnet.src.LabReport
{
    class Lab1
    {
        public static void run()
        {
            Console.WriteLine("Enter a single character: ");
            int character = Console.Read();
            Console.WriteLine("You entered the character: " + (char)character);
            
            Console.ReadLine();

            Console.WriteLine("Enter a line of text: ");
            string inputLine = Console.ReadLine();
            Console.WriteLine("You entered: " + inputLine);

            Console.Write("This text ");
            Console.Write("is printed ");
            Console.Write("on the same line.");

            Console.WriteLine("\nNow printing on a new line.");
            Console.WriteLine("Each time we use Console.WriteLine, it starts a new line.");
        }
    }
}
