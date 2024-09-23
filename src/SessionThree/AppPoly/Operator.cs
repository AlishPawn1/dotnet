namespace dotnet.src.SessionThree.AppPoly;
using System;

public class Increment{
    private int value;

    public Increment(int value){
        this.value = value;
    }

    // overloading the unary increment operator
    public static Increment operator ++(Increment obj){
        return new Increment(obj.value + 10);
    }
}

// overloading binary operator
public class ComplexNumber{
    public double Real{ get; set;}
    public double Imaginary{ get; set;}

    public ComplexNumber (double real , double imaginary){
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2){
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }

}