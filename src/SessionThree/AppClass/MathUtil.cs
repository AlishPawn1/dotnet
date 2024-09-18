using System;
namespace dotnet.src.SessionThree.AppClass;

public class MathUtil{
    public static readonly double pi = 3.14;
    // static method with one parameter
    public double CalculateArea(double radius) => pi * radius * radius; 
}