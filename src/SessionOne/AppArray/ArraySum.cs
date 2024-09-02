using System;

namespace dotnet.src.SessionOne.AppArray
{
    public static class ArraySum
    {
        public static void run()
        {
            int totalNumber, sum = 0;
            int[] numberToAdd = new int[5]; 

            System.Console.WriteLine("Enter the number of element (5 max)");
            string totalNumberInput = Console.ReadLine() ?? string.Empty;

            if(!int.TryParse(totalNumberInput, out totalNumber ) || totalNumber < 0 || totalNumber > 5 ){
                System.Console.WriteLine("\nInvalid input. Please enter a number and try again");
                return;
            }
            // else{
            //     System.Console.WriteLine();
            // }

            System.Console.WriteLine("\nEnter numerical element:");
            for(int i = 0; i< totalNumber; i++){
                bool isConversionSuccessfull = int.TryParse(Console.ReadLine(), out int convertedNumber);

                if(isConversionSuccessfull){
                    numberToAdd[i] = convertedNumber;
                    // sum += convertedNumber;
                }
                else{
                    numberToAdd[i] = 0;
                }
            }

            // for(int i = 0; i < numberToAdd[i]; i++){
            //     sum += numberToAdd[i];
            // }

            foreach(int number in numberToAdd){
                sum += number; 
            }

            System.Console.WriteLine("\nThe sum is: " + sum);
        }
    }
}
