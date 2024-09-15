// transfer control to another part of your program: break, continue, goto, return

using System;
using System.Diagnostics;

namespace dotnet.src.SessionTwo.Appcontrol;

public class Foo{}

public static class Jump{
    public static void run(){
        int count = 1, number = 1, age = 20;
        int[] numbers = new int[]{2,4,11,6,12,8,10};

        // using break to terminate a loop
        for(int i = 0; i < numbers.Length; i++){
            if(numbers[i] > 10){
                System.Console.WriteLine($"Number greater than 10 found : {numbers[i]}");
                System.Console.WriteLine(age);
                break;
            }
            System.Console.WriteLine($"Number {numbers[i]} at index {i}");
        }

        System.Console.WriteLine();
        System.Console.Write("odd number: ");
        while(count <= 10){
            if(count % 2 == 0){
                count++;
                continue; // skip the rest of loop body for this iteration
            }

            Console.Write(count + " ");
            count++;
        }

        // throw new ArithmeticException("New exception encountered");
        
        Console.WriteLine();
        ProcessNumber();
        System.Console.WriteLine();

        System.Console.WriteLine("\nFrom goto statement");
        startLoop:
        if(number <= 5){
            Console.Write(number + " ");
            number++;
            goto startLoop;
        }
    }

    private static void ProcessNumber(){
        Console.Write("Numbers from function: ");
        for(int i = 1; i <= 10; i++){
            if(i == 5){
                break;
                // continue;
                // return;
            }

            Console.Write(i + " ");
        }

        Console.Write("\nWhen does this get printed?");
    }
}