using System;
namespace dotnet.src.LabReport;

class RunLab
{
    public static void runLab()
    {
        Adder adder = new Adder();
        adder.Add();
        adder.Add(5);
        adder.Add(5, 6);
        adder.Add(5, 6, 7);
    }

    public static void runLab4(){
        Lab4 instance1 = new Lab4();  
        Lab4 instance2 = new Lab4(10, 20);  
    }

    public static void runLab5(){
        Point p1 = new Point(3, 4);
        Point p2 = new Point(5, 6);
        Point result = p1 + p2;
        Console.WriteLine($"First Point: {p1}");
        Console.WriteLine($"Second Point: {p2}");
        Console.WriteLine($"Sum: {result}");
    }

    public static void runLab6() {
        ChildClass childObj = new ChildClass();
        childObj.Grandparent(); 
        childObj.Parent();      
        childObj.Child();      
    }
    public static void runLab6_1() {
        Dog dog = new Dog();
        dog.Eat(); 
        dog.Sleep(); 
    }
    public static void runLab7() {
        BaseClass baseObj = new BaseClass();
        Console.WriteLine("Sum of x and y: " + baseObj.Calculate(5, 10));
        Console.WriteLine("Sum of x, y and z: " + baseObj.Calculate(5, 10, 15));

        BaseClass baseReference = new BaseClass();
        baseReference.Display();

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.Display();
    }

}