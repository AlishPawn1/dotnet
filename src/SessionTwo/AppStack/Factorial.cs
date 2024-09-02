using System;
using System.Text;

namespace dotnet.src.SessionTwo.AppStack;

public class Factorial{

    // stack memory
    public static void run(){
        int factorialNumber = 5;
        int result = GetFactorial(factorialNumber);

        System.Console.WriteLine($"\nFactorial of {factorialNumber} = {result}");

        BuildString();
    }

    private static int GetFactorial(int number){
        if (number == 0) return 1;
        return number * GetFactorial(number - 1);
    }

    // heap mempry
    private static void BuildString(){
        StringBuilder name = new StringBuilder("John");
        System.Console.WriteLine(name); 
        // name is now eligible for Grabage Collector (GC)

        StringBuilder address = new StringBuilder("London");
        StringBuilder street = address;
        // address is not yet eligibal for GC

        System.Console.WriteLine(street);
    }
}