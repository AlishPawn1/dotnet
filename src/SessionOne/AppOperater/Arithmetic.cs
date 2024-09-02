namespace dotnet.src.SessionOne.AppOperater;
using System;

public static class Arithmetic{
    public static void run(){
        int numTwo = 20;
        int numOne = 12;
        int numFour = 0;
        int numThree = 4;

        int sum = numOne + numTwo;
        int product = numOne * numTwo;
        int quotient = numOne / numTwo;
        int remainder = numOne % numTwo;
        int diffrence = numOne - numTwo;


        Console.WriteLine(
            $"{numOne} + {numTwo} = {sum}\n " +
            $"{numOne} * {numTwo} = {product}\n " +
            $"{numOne} / {numTwo} = {quotient}\n " +
            $"{numOne} % {numTwo} = {remainder}\n " +
            $"{numOne} - {numTwo} = {diffrence}\n " +
            $" numFour = {numFour}\n " +
            $"numFour = {numFour}\n " +
            $"numThree = {numThree}\n "
        );
        numOne++;
        numTwo--;

        Console.WriteLine(
            $"After increment numOne = {numOne}\n " +
            $"After decreasement numTwo = {numTwo}\n "
        );
    }
}