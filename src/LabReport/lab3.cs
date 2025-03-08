using System;
namespace dotnet.src.LabReport;

class Adder{
    public int Add(){
        int sum = 0;
        Console.WriteLine("No parameters provided. Sum is " + sum);
        return sum;
    }
    public int Add(int x)   {
        int sum = x;
        Console.WriteLine("Sum of " + x + " = " + sum);
        return sum;
    }
    public int Add(int x, int y) {
        int sum = x + y;
        Console.WriteLine("Sum of " + x + " and " + y + " = " + sum);
        return sum;
    }
    public int Add(int x, int y, int z){
        int sum = x + y + z;
        Console.WriteLine("Sum of " + x + ", " + y + " and " + z + " = " + sum);
        return sum;
    }
} 
