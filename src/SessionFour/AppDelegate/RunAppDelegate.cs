using System;
namespace dotnet.src.SessionFour.AppDelegate;

public class RunDelegate{

    // Creating anonymous function using delegate and statement lamda 
    private static readonly MathDelegate AddNumbers = (a, b) => {
        System.Console.WriteLine($"Sum from anonymous function is {a + b}");
        return a + b;
    };
    public static void RunSimpleDelegate(){
        MathDelegate addNum = new(MathOperations.Add);

        int addResult = addNum(5, 18);
        System.Console.WriteLine($"Addition result = {addResult}");

        MathDelegate multicast = new(MathOperations.Add);
        multicast += MathOperations.Subtract;
        multicast += MathOperations.Multiply;

        int multicastResult = multicast(2,2);
        System.Console.WriteLine($"Multicast result = {multicastResult}");
    }

    public static void RunFuncDelegate(){
        // first two int define and last is reture type
        Func<int, int, int> addDelegete = MathOperations.Add;
        int addResult = addDelegete(5,10);
        System.Console.WriteLine($"Addition result = {addResult}");

        // action delegate can only be used with void return type
        Action<string> greet = BasicOperations.GreetUser;
        greet("Alish");

        AddNumbers(10, 10);
    }

}