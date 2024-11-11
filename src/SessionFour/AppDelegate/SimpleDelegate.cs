using System;
namespace dotnet.src.SessionFour.AppDelegate;

// [modifier] delegate [return_type] [delegate_name] ([paremeter_list])
public delegate int MathDelegate( int x,int y);

public static class MathOperations{
    // Expression Lambda
    public static int Add(int x, int y) => x + y ;
    public static int Subtract(int x, int y){
        System.Console.WriteLine("subtract");
        return x - y ;
    }
    public static int Multiply(int x, int y) => x * y ;
}

public static class BasicOperations{
    public static void GreetUser(string name) => System.Console.WriteLine($"Hello {name} :)");
}