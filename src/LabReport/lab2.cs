using System;

namespace dotnet.src.LabReport
{
    class Lab2
    {
        public static void run()
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
