// Iteration statement enable program execution to repeat: for, foreach, while, do while

using System;
using System.Numerics;

namespace dotnet.src.SessionTwo.Appcontrol;

public static class Iteration{
    public static void run(){
        int number;
        int counter = 1;
        string userInput;
        bool isValidInput;

        while (counter <= 5){
            System.Console.WriteLine($"Counter - {counter}");
            counter ++;
        }

        System.Console.WriteLine("\nEnter your name");
        while ((userInput = Console.ReadLine() ?? "") != "exit"){
            System.Console.WriteLine($"\nYou enter: {userInput}");
        }

        // do something while condition is true

        do{
            System.Console.WriteLine("\nPlease enter a valid integer: ");
            isValidInput = int.TryParse(Console.ReadLine(), out number);
            if(!isValidInput){
                System.Console.WriteLine("please try again");
            }
        }
        while(!isValidInput);

        System.Console.WriteLine($"You enterd a valid number: {number}");

        // Fix the printer pattern
        for(int i = 1; i < 5; i++){
            for(int j = 1; j < i; j++){
                System.Console.Write("*\t");
            }
            Console.WriteLine();
        } 
    }
}