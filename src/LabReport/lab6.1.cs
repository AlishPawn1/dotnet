// Multiple inheritance 
using System;
namespace dotnet.src.LabReport;
interface IAnimal{
    void Eat();
}
interface IDomestic{
    void Sleep();
}
class Dog : IAnimal, IDomestic{
    public void Eat(){
        Console.WriteLine("Dog is eating.");
    }
    public void Sleep(){
        Console.WriteLine("Dog is sleeping.");
    }
}
