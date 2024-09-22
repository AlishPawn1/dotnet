
namespace dotnet.src.SessionThree.AppInterface;
using System;
public static class RunAppInterface{
    public static void RunShape() {
        Circle ball = new();
        ball.Radius = 10;
        ball.Name = "aakash";

        ShapeManager.PrintShapeInfo(ball);

    }
}
