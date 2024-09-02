using System;

namespace dotnet.src.SessionOne.AppArray
{
    public static class NormalArray
    {
        public static void run()
        {
            int[] numbers = new int[5];
            char[] letters = new char[] {'a', 'e', 'i', 'o', 'u'};
            int sum = 0;
            int sumEach = 0;

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            System.Console.WriteLine("Elements in numbers list: ");
            for(int i = 0; i < numbers.Length; i++){
                System.Console.WriteLine(numbers[i]);
            }

            // System.Console.WriteLine("\nadding number using loop");
            for(int i = 0; i < numbers.Length; i++){
                sum += numbers[i];
            }
            System.Console.WriteLine("\nSum of number using for is :" + sum);

            System.Console.WriteLine("\nElements in letter list: ");
            foreach(char letter in letters){
                System.Console.WriteLine(letter + "");
            }

            foreach(int number in numbers){
                sumEach += number; 
            }
            System.Console.WriteLine("\nSum of number using foreach is :" + sumEach);

        }
    }
}
