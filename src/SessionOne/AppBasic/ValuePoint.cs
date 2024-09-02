// using System;
using System;

namespace dotnet.src.SessionOne.AppBasic;

public struct ValuePoint{
    public int X { get; set;}
    public int Y { get; set;}
}

public class ValuePointRun{

    // reference type
    // value type
    public static void run(){
        // ValuePoint point = new ValuePoint() { X = 10, Y = 20 };

        ValuePoint pointOne = new ValuePoint();
        pointOne.X = 10;

        ValuePoint pointTwo = pointOne;

        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");

        pointOne.X = 20;

        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");


    }
}