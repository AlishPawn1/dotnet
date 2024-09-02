using System;

namespace dotnet.src.SessionOne.AppOperater
{
    public static class Character
    {
        public static void run()
        {
            int numOne = 10;
            char copyright = '\u00A9';
            char trademark = '\u2122';
            char dollor = '\u0024';
            char hash = '\u0023';
            string lastName = "Pawn";
            string firstName = "Pawn";
            string directoryPath = @"src\SessionOne\AppBasic\Character.cs";

            string fullName = firstName + " " + lastName + " " + numOne;
            bool resultName = firstName == lastName;

            Console.WriteLine("Result of comparison " + firstName.CompareTo(lastName));

            // firstname is larger/smaller/equal => 1/-1/0

            if(firstName.CompareTo(lastName) == 0){
                Console.WriteLine("First name is equal to last name");
            }

            Console.WriteLine($"Full name {{{copyright}}} is {fullName} {trademark}");
            Console.WriteLine($"Current directory is " + directoryPath);
            Console.WriteLine($"Comparison result is {resultName}");
            Console.WriteLine($"dollor result is {dollor}");
            Console.WriteLine($"hash result is {hash}");
            Console.WriteLine($"hash result is {hash}");
        }
    }
}
