using System;

namespace dotnet.src.SessionOne.AppArray
{
    public class JaggedArray
    {
        public static void run()
        {
            int[][] numbers = new int[3][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5},
                new int[] {7}
            };

            char[][] letters = {
                new char[] {'a', 'e', 'i', 'o', 'u'},
                new char[] {'b', 'c'}
            };

            System.Console.WriteLine("Element in numbers list: ");
            int rowNumber = 1;
            foreach (int[] rows in numbers)
            {
                int sum = 0;
                foreach (int item in rows)
                {
                    sum += item;
                    System.Console.WriteLine(item + " "); 
                }
                System.Console.WriteLine(); 
                System.Console.WriteLine($"Sum of row {rowNumber} is: {sum}");
                rowNumber += 1;
            }
        }
    }
}
