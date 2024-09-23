using System;
namespace dotnet.src.SessionThree.AppPoly;

public  class RunPoly{
    public static void runOperatorOverloading(){
        ComplexNumber c1 = new(2, 3);
        ComplexNumber c2 = new(4, 5);

        // result 6, 8
        //  14
        ComplexNumber result = c1 + c2;
        Console.WriteLine(result.ToString());

        Increment inc = new(5);
        Console.WriteLine($"This is imcremented value {inc++}");
    }
}
