using System;
using dotnet.src.SessionThree.AppClass;
namespace dotnet.src.SessionThree.AppClass;

public class Optimus{
    // public member are accessible from anywhere
    public int publicField = 10;
    public void PublicMethod(){ System.Console.WriteLine("Public method");}

    // private member are only accessible in the same class
    private int privateField = 15;
    private void privateMethod(){ System.Console.WriteLine("private method");}

    // internal member are accessibale within the same assembly (project)

    internal int internalField = 20;
    internal void internalMethod(){ System.Console.WriteLine("internal method");}

    // protected member are accessible within the class and its derived classes   
    protected int protectedField = 30;
    protected void protectedMethod(){ System.Console.WriteLine("protected method");}

    private protected class Helper{
        public void Info(){
            System.Console.WriteLine("This is a internal method");
        }
    }

    public void check(){
        Helper helper = new();
        helper.Info();
    }
}

// derive class extending / inheriting from Optimus
public class Derived : Optimus{
    // derived class can access public, internal, and protected members from the base
    public void checkInfo(){
        Helper db = new();

        System.Console.WriteLine($"PublicField: {publicField}");
        System.Console.WriteLine($"internalField: {internalField}");
        System.Console.WriteLine($"protectedField: {protectedField}");
        // System.Console.WriteLine($"privateField: {privateField}");

        PublicMethod();
        internalMethod();
        protectedMethod();
        // privateMethod();
    }
}

public class Magatron{
    // separate class can access public and internal nmember
    public void checkIsAuthenticated(){
        Optimus prime = new();

        System.Console.WriteLine($"PublicField:  {prime.publicField}");
        System.Console.WriteLine($"internalField:  {prime.internalField}");
        // System.Console.WriteLine($"protectedField:  {prime.protectedField}");
        // System.Console.WriteLine($"privateField:  {prime.privateField}");

        prime.PublicMethod();
        prime.internalMethod();
        // prime.protectedMethod();
        // prime.privateMethod();
    }
}