// Multilevel inheritance
using System;
namespace dotnet.src.LabReport;
class GrandClass{
    public void Grandparent(){
        Console.WriteLine("Grandparent class.");
    }
}
class ParentClass : GrandClass{
    public void Parent(){
        Console.WriteLine("Parent class.");
    }
}
class ChildClass : ParentClass{
    public void Child(){
        Console.WriteLine("Grand Child class.");
    }
}
