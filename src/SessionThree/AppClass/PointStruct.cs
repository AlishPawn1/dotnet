using System;
using System.Drawing;
namespace dotnet.src.SessionThree.AppClass;
public class PointStruct{
    // public int X { get; set; }
    public int X{
        get { return this.X; }

        set {
            if(value < 0){
                throw new ArithmeticException("X cannot be negative");
            }
            this.X = value;
        }
    }
    // public int Y { get; set; }

    public int Y{
        get { return this.Y; }

        set {
            if(value < 0){
                throw new ArithmeticException("Y cannot be negative");
            }
            this.Y = value;
        }
    }

    public PointStruct(int x, int y){
        X = x;
        Y = y;
    }
    // invalid : cannot have a constructor without parameters
    // public PointStruct(){}

    // invalid: cannot have field initializer
    // public int X = 0;
    // public int Y = 0;

    // Invalid: cannot have a finalizers
    // ~PointStruct()

    // invalid: cannot have virtual or protected method
    // public virtual void DoSomething()

}