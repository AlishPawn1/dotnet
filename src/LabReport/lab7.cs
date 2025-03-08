using System;
namespace dotnet.src.LabReport;
class BaseClass{
    public int Calculate(int x, int y){
        return x + y;
    }
    public int Calculate(int x, int y, int z){
        return x + y + z;
    }
    public virtual void Display(){
        Console.WriteLine("Display method in BaseClass");
    }
}
class DerivedClass : BaseClass{
    public override void Display(){
        Console.WriteLine("Display method in DerivedClass");
    }
}
