using System;
namespace dotnet.src.LabReport;

class Lab4 {
    public static int staticValue;
    public int a;
    public int b;
    public Lab4(){
        Console.WriteLine("No Parameter Constructor");
    }
    public Lab4(int a, int b){
        this.a = a;
        this.b = b;
        Console.WriteLine("Two Parameter Constructor  : a = " + this.a + ", b = " + this.b);
    }
    static Lab4(){
        staticValue = 100;
        Console.WriteLine("Static method = " + staticValue);
    }
}