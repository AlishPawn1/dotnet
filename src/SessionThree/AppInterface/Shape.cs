using System;
namespace dotnet.src.SessionThree.AppInterface
{
    public interface IShapeArea
    {
        // only method signature, abstract by default
        public double getArea();
    }

    public interface IShapeDraw
    {
        public void getPosition();
    }

    // Multiple inheritance
    public abstract class CommonShape : IShapeArea, IShapeDraw
    {
        private int id;

        public abstract string Name { get; set; }

        public abstract double getArea();
        public abstract void getPosition();

        public int getId()
        {
            return this.id;
        }
    }

    // Hybrid inheritance
    public class Circle : CommonShape
    {
        // Fields
        public double Radius;
        private string _name = "Circle";

        // Property with accessors
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override double getArea()
        {
            double area = Math.PI * Radius * Radius;
            return Math.Round(area, 2);
        }

        public override void getPosition()
        {
            System.Console.WriteLine($"/-----drawing a {Name}-----/");
        }
    }

    public static class ShapeManager
    {
        public static void PrintShapeInfo(CommonShape shape)
        {
            shape.getPosition();
            System.Console.WriteLine($"Shape Name: {shape.Name}");
            System.Console.WriteLine($"Area: {shape.getArea()}");
        }
    }
}
