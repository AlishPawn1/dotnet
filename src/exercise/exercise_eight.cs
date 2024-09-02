using System;
namespace dotnet.src.exercise;

class exercise_eight{
    public static void run(){
        byte varA = 10;
        byte varB = 20;
        long result = varA & varB;
        System.Console.WriteLine("{0} AND {1} Result: {2}", varA, varB, result);

        varA = 10;
        varB = 10;
        result = varA & varB;
        System.Console.WriteLine("{0} AND {1} Result: {2}", varA, varB, result);
        Console.ReadLine();
    }
}