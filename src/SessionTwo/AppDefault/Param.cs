using System;
using System.ComponentModel;

namespace dotnet.src.SessionTwo.AppDefault;

public class Param{
    public static void run() {
        int mainNumber = 10; // when ref

        AddNumber(1, 2);

        IncrementByOne(ref mainNumber);
        System.Console.WriteLine($"old number is {mainNumber}");

        JumbleNumber(5, 6, out int numOne, out int numTwo);
        
        // Exercise 2.1
        System.Console.WriteLine($"Sum of params = {MajorSum(1, 1, 1, 1)}");
 
        // Exercise 2.2
        MajorMultiplication(6,1,2,3,4,5,6);

    }

    // pass by value
    private static void AddNumber(int numOne, int numTwo){
        int result = numOne + numTwo;
        System.Console.WriteLine($"result = {result}");
    }

    // pass by referance
    // it make copy to receive
    // orginal

    private static void IncrementByOne(ref int num){
        num += 1;
        System.Console.WriteLine($"New number is {num}");
    }

    // Out param modifier
    private static bool JumbleNumber(int a, int b, out int x, out int y){
        x = b;
        y = a;
        return true;
    }

    private static int MajorSum(params int[] numbers){ // params should be in last
        int sum = 0;
        foreach (int number in numbers) sum += number;
        return sum;
    }

    private static void MajorMultiplication(params int[] numbers){
        // int[] result;
        System.Console.WriteLine("enter the number time you want to multiple:");
        // string total_calculate = Console.ReadLine() ?? string.Empty;

        // int total_calculate;

        bool number_c = int.TryParse(Console.ReadLine(), out int total_calculate);
        System.Console.WriteLine(number_c);
        if(number_c){
            foreach (int number in numbers){
                System.Console.Write("the multiple of " + number + " is : ");

                for(int i=1 ; i <= total_calculate ; i++){
                    System.Console.Write(number * i + " ");
                }
                System.Console.WriteLine();
            }
        }
        else{
            System.Console.WriteLine("Error Value Found");
        }
    }

    // private static void MajorMultiplication(params int[] numbers){
    // System.Console.WriteLine("enter the number time you want to multiple:");
    // int total_calculate = Convert.ToInt32(Console.Read());
    // int[,] result = new int[numbers.Length, 5];


    // for(int i = 0; i < numbers.Length; i++){
    //     System.Console.Write($"Multiplication of {numbers[i]} is: ");
        
    //     for(int j = 0; j < total_calculate; j++){
    //         result[i, j] = numbers[i] * (j + 1);
    //         System.Console.Write(result[i, j] + " ");
    //     }

    //     System.Console.WriteLine();
    // }
    // }

}