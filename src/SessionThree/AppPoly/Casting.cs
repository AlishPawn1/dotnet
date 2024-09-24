namespace dotnet.src.SessionThree.AppPoly;
using System;

public class User{
    public virtual void Greet() => Console.WriteLine("hello");
}
public class Admin : User{
    public override void Greet() => Console.WriteLine("Greeting, Administeator");
}
public class Guest : User{
    public override void Greet() => Console.WriteLine("Welcome, Guess");
}