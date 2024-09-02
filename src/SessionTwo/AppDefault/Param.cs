using System;
using System.ComponentModel;

namespace dotnet.src.SessionTwo.AppDefault;

public class Param{
    public static void run() {
        int point = 10; // when ref

        AddNumber(1, 2);

        IncrementByOne(ref point);
        System.Console.WriteLine($"old number is {point}");

        // JumbleNumber(5, 6, out int numOne, out int numTwo);
        
        // System.Console.WriteLine($"Sum of params = {MajorSum(1, 1, 1, 1)}");


    }

    // pass by value
    private static void AddNumber(int numOne, int numTwo){
        int result = numOne + numTwo;
        System.Console.WriteLine($"result = {result}");
    }

    // pass by referance
    // it make copy to receive

    private static void IncrementByOne(ref int num){
        num += 1;
        System.Console.WriteLine($"New number is {num}");
    }
}